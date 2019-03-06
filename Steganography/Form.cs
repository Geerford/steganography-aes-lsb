using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Bitmap bitmapOriginal;
        private Bitmap bitmapModified;
        private SymmetricAlgorithm algorithm;
        private static AES.Rijndael rijndael = new AES.Rijndael();

        public Form()
        {
            InitializeComponent();
            algorithm = rijndael.AlgorithmInit();
        }

        private void LoadPicture(bool type)
        {
            try
            {
                OpenFileDialog dialog = openFileDialog;
                dialog.ShowDialog();
                if (type)
                {
                    bitmapOriginal = (Bitmap)Image.FromFile(dialog.FileName);
                }
                else
                {
                    bitmapModified = (Bitmap)Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Choose a original image");
            }
        }

        private static Bitmap ScaleImage(Bitmap image)
        {
            int maxWidth = 350, maxHeight = 350;
            double ratioX = (double)maxWidth / image.Width,
                ratioY = (double)maxHeight / image.Height,
                ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(image.Width * ratio),
                newHeight = (int)(image.Height * ratio);

            Bitmap scaledImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(scaledImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return scaledImage;
        }

        private string LoadMessage()
        {
            string message = "";
            try
            {
                OpenFileDialog dialog = openFileDialog;
                dialog.ShowDialog();
                message = File.ReadAllText(dialog.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Choose a file");
            }
            return message;
        }
        
        private void HidingMessage()
        {
            if(bitmapOriginal != null)
            {
                string message = richTextBoxMsg.Text;
                if (message != "")
                {
                    try
                    {
                        string password = textBoxPassword.Text;
                        bitmapModified = new Bitmap(bitmapOriginal, bitmapOriginal.Width, bitmapOriginal.Height);
                        byte[] old = rijndael.Encrypt(message, password);
                        int bytesCount = old.Length;
                        byte[] bytesOriginal = new byte[bytesCount + 4]; // 4 - META
                        for(int i = 4; i < bytesOriginal.Length; i++)
                        {
                            bytesOriginal[i] = old[i - 4];
                        }
                        int byteCount = 0;

                        for (int i = 0; i < bitmapOriginal.Width; i++)
                        {
                            for (int j = 0; j < bitmapOriginal.Height; j++)
                            {
                                if (bytesOriginal.Length == byteCount)
                                {
                                    int intValue = bytesOriginal.Length;
                                    byte[] intBytes = BitConverter.GetBytes(intValue);
                                    int counter = 0;
                                    for(int m = 0; m < bitmapOriginal.Width; m++)
                                    {
                                        for(int n = 0; n < bitmapOriginal.Height; n++)
                                        {
                                            Color pixelFromOriginalFirst = bitmapOriginal.GetPixel(m, n);
                                            byte rr = (byte)((pixelFromOriginalFirst.R & ~0x7) | (intBytes[counter] >> 0) & 0x7);
                                            byte gg = (byte)((pixelFromOriginalFirst.G & ~0x7) | (intBytes[counter] >> 3) & 0x7);
                                            byte bb = (byte)((pixelFromOriginalFirst.B & ~0x3) | (intBytes[counter] >> 6) & 0x3);
                                            bitmapModified.SetPixel(m, n, Color.FromArgb(rr, gg, bb));
                                            counter++;
                                            if(counter == 4)
                                            {
                                                return;
                                            }
                                        }
                                    }
                                }
                                if(byteCount > 3)
                                {
                                    //set 1, 2, 3 from red LSB
                                    //set 4, 5, 6 from green LSB
                                    //set 7 and 8 from blue LSB
                                    Color pixelFromOriginal = bitmapOriginal.GetPixel(i, j);
                                    byte r = (byte)((pixelFromOriginal.R & ~0x7) | (bytesOriginal[byteCount] >> 0) & 0x7);
                                    byte g = (byte)((pixelFromOriginal.G & ~0x7) | (bytesOriginal[byteCount] >> 3) & 0x7);
                                    byte b = (byte)((pixelFromOriginal.B & ~0x3) | (bytesOriginal[byteCount] >> 6) & 0x3);
                                    bitmapModified.SetPixel(i, j, Color.FromArgb(r, g, b));
                                }
                                byteCount++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error hiding message");
                    }
                }
                else
                {
                    MessageBox.Show("Choose or enter a message");
                }
            }
            else
            {
                MessageBox.Show("Choose a original image");
            }
        }

        private byte[] ExtractMessage()
        {
            byte[] bytesExtracted = null;
            byte[] result = null;
            try
            {
                //get 1, 2, 3 from red LSB
                //get 4, 5, 6 from green LSB
                //get 7 and 8 from blue LSB
                int byteCount = 0;
                byte[] bytesCountArray= new byte[4];

                for (int i = 0; i < bitmapModified.Width; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (bytesCountArray.Length == byteCount)
                        {
                            break;
                        }
                        Color pixelFromModified = bitmapModified.GetPixel(i, j);
                        byte bits123 = (byte)((pixelFromModified.R & 0x7) << 0);
                        byte bits456 = (byte)((pixelFromModified.G & 0x7) << 3);
                        byte bits78 = (byte)((pixelFromModified.B & 0x3) << 6);

                        bytesCountArray[byteCount] = (byte)(bits78 | bits456 | bits123);
                        byteCount++;
                    }
                }
                int byteInPicture = BitConverter.ToInt32(bytesCountArray, 0);

                bytesExtracted = new byte[byteInPicture];

                byteCount = 0;

                for (int i = 0; i < bitmapModified.Width; i++)
                {
                    for (int j = 0; j < bitmapModified.Height; j++)
                    {
                        if (bytesExtracted.Length == byteCount)
                        {
                            break;
                        }
                        if(byteCount > 3)
                        {
                            Color pixelFromModified = bitmapModified.GetPixel(i, j);
                            byte bits123 = (byte)((pixelFromModified.R & 0x7) << 0);
                            byte bits456 = (byte)((pixelFromModified.G & 0x7) << 3);
                            byte bits78 = (byte)((pixelFromModified.B & 0x3) << 6);

                            bytesExtracted[byteCount] = (byte)(bits78 | bits456 | bits123);
                        }

                        byteCount++;
                    }
                }
                result = new byte[bytesExtracted.Length - 4];
                for(int i = 0; i < result.Length; i++)
                {
                    result[i] = bytesExtracted[i + 4];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error extracting message");
            }
            return result;
        }

        private void buttonLoadOriginal_Click(object sender, EventArgs e)
        {
            LoadPicture(true);
            panelOriginal.Invalidate();
        }

        private void panelOriginal_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (bitmapOriginal != null)
                {
                    Graphics panelOriginalObj = Graphics.FromHwnd(panelOriginal.Handle);
                    panelOriginalObj.DrawImage(ScaleImage(bitmapOriginal), new Point(0, 0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error drawing ogrinal image");
            }
        }

        private void buttonLoadModified_Click(object sender, EventArgs e)
        {
            LoadPicture(false);
            panelModified.Invalidate();
        }

        private void panelModified_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (bitmapModified != null)
                {
                    Graphics panelModifiedObj = Graphics.FromHwnd(panelModified.Handle);
                    panelModifiedObj.DrawImage(ScaleImage(bitmapModified), new Point(0, 0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error drawing modified image");
            }
        }

        private void buttonLoadMsg_Click(object sender, EventArgs e)
        {
            
            richTextBoxMsg.Text = LoadMessage();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            HidingMessage();
            panelModified.Invalidate();
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string decrypted = rijndael.Decrypt(ExtractMessage(), password);
            richTextBoxMsgExtract.Text = decrypted;
        }

        private void buttonSaveModified_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("bitmapModified.jpg"))
                {
                    File.Delete("bitmapModified.jpg");
                }
                bitmapModified.Save("bitmapModified.jpg", ImageFormat.Png);
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving file\n");
            }
        }

        private void buttonSaveText_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("data.txt");
                writer.Write(richTextBoxMsgExtract.Text);
                writer.Close();
                MessageBox.Show("Saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving file\n");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            bitmapOriginal = null;
            bitmapModified = null;
            panelOriginal.Invalidate();
            panelModified.Invalidate();
            richTextBoxMsg.Text = "";
            richTextBoxMsgExtract.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
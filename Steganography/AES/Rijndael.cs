using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Steganography.AES
{
    public class Rijndael
    {
        private readonly int blockLength = 16;
        private readonly byte[] SALT = new byte[16];
        private MemoryStream ms;
        private CryptoStream cs;
        private SymmetricAlgorithm algorithm;

        public SymmetricAlgorithm AlgorithmInit()
        {
            Random random = new Random();
            random.NextBytes(SALT);
            SymmetricAlgorithm algorithm = System.Security.Cryptography.Rijndael.Create();
            algorithm.Mode = CipherMode.CFB;
            algorithm.KeySize = 256;
            this.algorithm = algorithm;
            return algorithm;
        }

        public byte[] Encrypt(string message, string password)
        {
            byte[] cipherbytes = null;
            try
            {
                byte[] plainbytes = Normalize(message);
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, SALT);
                algorithm.Key = pdb.GetBytes(32);
                algorithm.IV = pdb.GetBytes(16);
                algorithm.Padding = PaddingMode.None;
                ms = new MemoryStream();
                cs = new CryptoStream(ms, algorithm.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(plainbytes, 0, plainbytes.Length);
                cs.Close();
                cipherbytes = ms.ToArray();
                ms.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Encrypting error");
            }
            return cipherbytes;
        }

        public string Decrypt(byte[] cipherbytes, string password)
        {
            byte[] plainbytes = null;
            try
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, SALT);
                algorithm.Key = pdb.GetBytes(32);
                algorithm.IV = pdb.GetBytes(16);
                algorithm.Padding = PaddingMode.None;
                ms = new MemoryStream(cipherbytes);
                cs = new CryptoStream(ms, algorithm.CreateDecryptor(), CryptoStreamMode.Read);
                plainbytes = new byte[cipherbytes.Length];
                cs.Read(plainbytes, 0, cipherbytes.Length);
                cs.Close();
                ms.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Decrypting error");
            }
            return Encoding.UTF8.GetString(plainbytes);
        }

        private byte[] Normalize(string message)
        {
            byte[] plainbytes = Encoding.UTF8.GetBytes(message);
            int remainder = plainbytes.Length % blockLength;
            if (remainder != 0)
            {
                var length = plainbytes.Length;
                Array.Resize(ref plainbytes, plainbytes.Length + (blockLength - remainder));
                for (int i = length; i < plainbytes.Length; i++)
                {
                    plainbytes[i] = 0;
                }
            }
            return plainbytes;
        }
    }
}
namespace Steganography
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadOriginal = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxOriginal = new System.Windows.Forms.GroupBox();
            this.panelOriginal = new System.Windows.Forms.Panel();
            this.groupBoxModified = new System.Windows.Forms.GroupBox();
            this.panelModified = new System.Windows.Forms.Panel();
            this.buttonLoadMsg = new System.Windows.Forms.Button();
            this.buttonLoadModified = new System.Windows.Forms.Button();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.richTextBoxMsg = new System.Windows.Forms.RichTextBox();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.groupBoxMsgExtract = new System.Windows.Forms.GroupBox();
            this.richTextBoxMsgExtract = new System.Windows.Forms.RichTextBox();
            this.groupBoxButtonPanel = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.buttonSaveModified = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.groupBoxOriginal.SuspendLayout();
            this.groupBoxModified.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.groupBoxMsgExtract.SuspendLayout();
            this.groupBoxButtonPanel.SuspendLayout();
            this.groupBoxPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadOriginal
            // 
            this.buttonLoadOriginal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadOriginal.Location = new System.Drawing.Point(6, 19);
            this.buttonLoadOriginal.Name = "buttonLoadOriginal";
            this.buttonLoadOriginal.Size = new System.Drawing.Size(108, 40);
            this.buttonLoadOriginal.TabIndex = 0;
            this.buttonLoadOriginal.Text = "Load Original";
            this.buttonLoadOriginal.UseVisualStyleBackColor = true;
            this.buttonLoadOriginal.Click += new System.EventHandler(this.buttonLoadOriginal_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBoxOriginal
            // 
            this.groupBoxOriginal.Controls.Add(this.panelOriginal);
            this.groupBoxOriginal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOriginal.Name = "groupBoxOriginal";
            this.groupBoxOriginal.Size = new System.Drawing.Size(350, 370);
            this.groupBoxOriginal.TabIndex = 1;
            this.groupBoxOriginal.TabStop = false;
            this.groupBoxOriginal.Text = "Original Image";
            // 
            // panelOriginal
            // 
            this.panelOriginal.AutoSize = true;
            this.panelOriginal.Location = new System.Drawing.Point(6, 20);
            this.panelOriginal.Name = "panelOriginal";
            this.panelOriginal.Size = new System.Drawing.Size(340, 340);
            this.panelOriginal.TabIndex = 0;
            this.panelOriginal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOriginal_Paint);
            // 
            // groupBoxModified
            // 
            this.groupBoxModified.Controls.Add(this.panelModified);
            this.groupBoxModified.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxModified.Location = new System.Drawing.Point(368, 12);
            this.groupBoxModified.Name = "groupBoxModified";
            this.groupBoxModified.Size = new System.Drawing.Size(350, 370);
            this.groupBoxModified.TabIndex = 2;
            this.groupBoxModified.TabStop = false;
            this.groupBoxModified.Text = "Modified Image";
            // 
            // panelModified
            // 
            this.panelModified.Location = new System.Drawing.Point(4, 20);
            this.panelModified.Name = "panelModified";
            this.panelModified.Size = new System.Drawing.Size(340, 340);
            this.panelModified.TabIndex = 0;
            this.panelModified.Paint += new System.Windows.Forms.PaintEventHandler(this.panelModified_Paint);
            // 
            // buttonLoadMsg
            // 
            this.buttonLoadMsg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadMsg.Location = new System.Drawing.Point(4, 111);
            this.buttonLoadMsg.Name = "buttonLoadMsg";
            this.buttonLoadMsg.Size = new System.Drawing.Size(108, 40);
            this.buttonLoadMsg.TabIndex = 3;
            this.buttonLoadMsg.Text = "Load Message";
            this.buttonLoadMsg.UseVisualStyleBackColor = true;
            this.buttonLoadMsg.Click += new System.EventHandler(this.buttonLoadMsg_Click);
            // 
            // buttonLoadModified
            // 
            this.buttonLoadModified.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadModified.Location = new System.Drawing.Point(4, 65);
            this.buttonLoadModified.Name = "buttonLoadModified";
            this.buttonLoadModified.Size = new System.Drawing.Size(108, 40);
            this.buttonLoadModified.TabIndex = 4;
            this.buttonLoadModified.Text = "Load Modified";
            this.buttonLoadModified.UseVisualStyleBackColor = true;
            this.buttonLoadModified.Click += new System.EventHandler(this.buttonLoadModified_Click);
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.richTextBoxMsg);
            this.groupBoxMsg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMsg.Location = new System.Drawing.Point(12, 388);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(350, 113);
            this.groupBoxMsg.TabIndex = 5;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "Message";
            // 
            // richTextBoxMsg
            // 
            this.richTextBoxMsg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMsg.Location = new System.Drawing.Point(8, 20);
            this.richTextBoxMsg.Name = "richTextBoxMsg";
            this.richTextBoxMsg.Size = new System.Drawing.Size(337, 87);
            this.richTextBoxMsg.TabIndex = 0;
            this.richTextBoxMsg.Text = "";
            // 
            // buttonHide
            // 
            this.buttonHide.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHide.Location = new System.Drawing.Point(4, 157);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(108, 40);
            this.buttonHide.TabIndex = 6;
            this.buttonHide.Text = "Hide Message";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtract.Location = new System.Drawing.Point(4, 203);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(108, 40);
            this.buttonExtract.TabIndex = 7;
            this.buttonExtract.Text = "Extract Message";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // groupBoxMsgExtract
            // 
            this.groupBoxMsgExtract.Controls.Add(this.richTextBoxMsgExtract);
            this.groupBoxMsgExtract.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMsgExtract.Location = new System.Drawing.Point(368, 388);
            this.groupBoxMsgExtract.Name = "groupBoxMsgExtract";
            this.groupBoxMsgExtract.Size = new System.Drawing.Size(350, 113);
            this.groupBoxMsgExtract.TabIndex = 8;
            this.groupBoxMsgExtract.TabStop = false;
            this.groupBoxMsgExtract.Text = "Extracted Message";
            // 
            // richTextBoxMsgExtract
            // 
            this.richTextBoxMsgExtract.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMsgExtract.Location = new System.Drawing.Point(8, 20);
            this.richTextBoxMsgExtract.Name = "richTextBoxMsgExtract";
            this.richTextBoxMsgExtract.Size = new System.Drawing.Size(337, 87);
            this.richTextBoxMsgExtract.TabIndex = 0;
            this.richTextBoxMsgExtract.Text = "";
            // 
            // groupBoxButtonPanel
            // 
            this.groupBoxButtonPanel.Controls.Add(this.buttonClear);
            this.groupBoxButtonPanel.Controls.Add(this.buttonSaveText);
            this.groupBoxButtonPanel.Controls.Add(this.buttonSaveModified);
            this.groupBoxButtonPanel.Controls.Add(this.buttonLoadOriginal);
            this.groupBoxButtonPanel.Controls.Add(this.buttonLoadModified);
            this.groupBoxButtonPanel.Controls.Add(this.buttonExtract);
            this.groupBoxButtonPanel.Controls.Add(this.buttonLoadMsg);
            this.groupBoxButtonPanel.Controls.Add(this.buttonHide);
            this.groupBoxButtonPanel.Location = new System.Drawing.Point(724, 13);
            this.groupBoxButtonPanel.Name = "groupBoxButtonPanel";
            this.groupBoxButtonPanel.Size = new System.Drawing.Size(118, 385);
            this.groupBoxButtonPanel.TabIndex = 9;
            this.groupBoxButtonPanel.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(6, 341);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(106, 40);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear UI";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveText.Location = new System.Drawing.Point(6, 295);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(108, 40);
            this.buttonSaveText.TabIndex = 9;
            this.buttonSaveText.Text = "Save Text";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.buttonSaveText_Click);
            // 
            // buttonSaveModified
            // 
            this.buttonSaveModified.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveModified.Location = new System.Drawing.Point(4, 249);
            this.buttonSaveModified.Name = "buttonSaveModified";
            this.buttonSaveModified.Size = new System.Drawing.Size(108, 40);
            this.buttonSaveModified.TabIndex = 8;
            this.buttonSaveModified.Text = "Save Modified";
            this.buttonSaveModified.UseVisualStyleBackColor = true;
            this.buttonSaveModified.Click += new System.EventHandler(this.buttonSaveModified_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(6, 19);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxPassword.TabIndex = 10;
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPassword.Location = new System.Drawing.Point(725, 401);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Size = new System.Drawing.Size(111, 100);
            this.groupBoxPassword.TabIndex = 10;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "Password";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(848, 513);
            this.Controls.Add(this.groupBoxPassword);
            this.Controls.Add(this.groupBoxButtonPanel);
            this.Controls.Add(this.groupBoxMsgExtract);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.groupBoxModified);
            this.Controls.Add(this.groupBoxOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "Steganography with Rijndael";
            this.groupBoxOriginal.ResumeLayout(false);
            this.groupBoxOriginal.PerformLayout();
            this.groupBoxModified.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsgExtract.ResumeLayout(false);
            this.groupBoxButtonPanel.ResumeLayout(false);
            this.groupBoxPassword.ResumeLayout(false);
            this.groupBoxPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadOriginal;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBoxOriginal;
        private System.Windows.Forms.Panel panelOriginal;
        private System.Windows.Forms.GroupBox groupBoxModified;
        private System.Windows.Forms.Panel panelModified;
        private System.Windows.Forms.Button buttonLoadMsg;
        private System.Windows.Forms.Button buttonLoadModified;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.RichTextBox richTextBoxMsg;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.GroupBox groupBoxMsgExtract;
        private System.Windows.Forms.RichTextBox richTextBoxMsgExtract;
        private System.Windows.Forms.GroupBox groupBoxButtonPanel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSaveText;
        private System.Windows.Forms.Button buttonSaveModified;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxPassword;
    }
}


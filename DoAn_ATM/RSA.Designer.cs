namespace DoAn_ATM
{
    partial class RSA
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
            bt_RSA_Encrypt = new Button();
            bt_RSA_Decrypt = new Button();
            SuspendLayout();
            // 
            // bt_RSA_Encrypt
            // 
            bt_RSA_Encrypt.Location = new Point(255, 107);
            bt_RSA_Encrypt.Name = "bt_RSA_Encrypt";
            bt_RSA_Encrypt.Size = new Size(265, 78);
            bt_RSA_Encrypt.TabIndex = 0;
            bt_RSA_Encrypt.Text = "Encrypt";
            bt_RSA_Encrypt.UseVisualStyleBackColor = true;
            bt_RSA_Encrypt.Click += bt_RSA_Encrypt_Click;
            // 
            // bt_RSA_Decrypt
            // 
            bt_RSA_Decrypt.Location = new Point(255, 261);
            bt_RSA_Decrypt.Name = "bt_RSA_Decrypt";
            bt_RSA_Decrypt.Size = new Size(265, 78);
            bt_RSA_Decrypt.TabIndex = 1;
            bt_RSA_Decrypt.Text = "Decrypt";
            bt_RSA_Decrypt.UseVisualStyleBackColor = true;
            bt_RSA_Decrypt.Click += bt_RSA_Decrypt_Click;
            // 
            // RSA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_RSA_Decrypt);
            Controls.Add(bt_RSA_Encrypt);
            Name = "RSA";
            Text = "RSA";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_RSA_Encrypt;
        private Button bt_RSA_Decrypt;
    }
}
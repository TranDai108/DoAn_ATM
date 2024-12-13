namespace DoAn_ATM
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_PlayFair = new Button();
            bt_RSA = new Button();
            SuspendLayout();
            // 
            // bt_PlayFair
            // 
            bt_PlayFair.Location = new Point(337, 153);
            bt_PlayFair.Name = "bt_PlayFair";
            bt_PlayFair.Size = new Size(112, 34);
            bt_PlayFair.TabIndex = 0;
            bt_PlayFair.Text = "PlayFair";
            bt_PlayFair.UseVisualStyleBackColor = true;
            bt_PlayFair.Click += bt_PlayFair_Click;
            // 
            // bt_RSA
            // 
            bt_RSA.Location = new Point(339, 223);
            bt_RSA.Name = "bt_RSA";
            bt_RSA.Size = new Size(112, 34);
            bt_RSA.TabIndex = 1;
            bt_RSA.Text = "RSA";
            bt_RSA.UseVisualStyleBackColor = true;
            bt_RSA.Click += bt_RSA_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_RSA);
            Controls.Add(bt_PlayFair);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_PlayFair;
        private Button bt_RSA;
    }
}

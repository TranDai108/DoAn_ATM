namespace DoAn_ATM
{
    partial class RSA_Encryption
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
        private void InitializeComponent() {
            label1 = new Label();
            rtb_Input = new RichTextBox();
            lb_Input = new Label();
            tb_p = new TextBox();
            tb_q = new TextBox();
            tb_e = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bt_GenRan = new Button();
            btnClear = new Button();
            rtb_Output = new RichTextBox();
            label6 = new Label();
            bt_Encrypt = new Button();
            rtb_PublicKey = new RichTextBox();
            rtb_PrivateKey = new RichTextBox();
            bt_KeyPair_Gen = new Button();
            label7 = new Label();
            label8 = new Label();
            lb_n = new Label();
            tb_n = new TextBox();
            bt_Decrypt = new Button();
            lblAlertP = new Label();
            lblAlertQ = new Label();
            lblAlertE = new Label();
            btnExport = new Button();
            btnImport = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "RSA ENCRYPTION";
            // 
            // rtb_Input
            // 
            rtb_Input.Location = new Point(56, 67);
            rtb_Input.Margin = new Padding(2);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(335, 128);
            rtb_Input.TabIndex = 2;
            rtb_Input.Text = "";
            // 
            // lb_Input
            // 
            lb_Input.AutoSize = true;
            lb_Input.Location = new Point(200, 49);
            lb_Input.Margin = new Padding(2, 0, 2, 0);
            lb_Input.Name = "lb_Input";
            lb_Input.Size = new Size(35, 15);
            lb_Input.TabIndex = 3;
            lb_Input.Text = "Input";
            // 
            // tb_p
            // 
            tb_p.Location = new Point(54, 253);
            tb_p.Margin = new Padding(2);
            tb_p.Name = "tb_p";
            tb_p.Size = new Size(207, 23);
            tb_p.TabIndex = 4;
            tb_p.TextChanged += tb_p_TextChanged;
            // 
            // tb_q
            // 
            tb_q.Location = new Point(321, 253);
            tb_q.Margin = new Padding(2);
            tb_q.Name = "tb_q";
            tb_q.Size = new Size(220, 23);
            tb_q.TabIndex = 5;
            tb_q.TextChanged += tb_q_TextChanged;
            // 
            // tb_e
            // 
            tb_e.Location = new Point(588, 253);
            tb_e.Margin = new Padding(2);
            tb_e.Name = "tb_e";
            tb_e.Size = new Size(134, 23);
            tb_e.TabIndex = 6;
            tb_e.TextChanged += tb_e_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 236);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 7;
            label2.Text = "p";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 236);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "q";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 236);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 9;
            label4.Text = "e";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 206);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 10;
            label5.Text = "Create Key-Pair";
            // 
            // bt_GenRan
            // 
            bt_GenRan.Location = new Point(673, 331);
            bt_GenRan.Margin = new Padding(2);
            bt_GenRan.Name = "bt_GenRan";
            bt_GenRan.Size = new Size(208, 31);
            bt_GenRan.TabIndex = 11;
            bt_GenRan.Text = "Generate Random Value";
            bt_GenRan.UseVisualStyleBackColor = true;
            bt_GenRan.Click += bt_GenRan_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(675, 365);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(208, 25);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rtb_Output
            // 
            rtb_Output.Location = new Point(535, 65);
            rtb_Output.Margin = new Padding(2);
            rtb_Output.Name = "rtb_Output";
            rtb_Output.ReadOnly = true;
            rtb_Output.Size = new Size(335, 128);
            rtb_Output.TabIndex = 13;
            rtb_Output.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(685, 49);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 14;
            label6.Text = "Output";
            // 
            // bt_Encrypt
            // 
            bt_Encrypt.Location = new Point(407, 57);
            bt_Encrypt.Margin = new Padding(2);
            bt_Encrypt.Name = "bt_Encrypt";
            bt_Encrypt.Size = new Size(106, 29);
            bt_Encrypt.TabIndex = 15;
            bt_Encrypt.Text = "Encrypt";
            bt_Encrypt.UseVisualStyleBackColor = true;
            bt_Encrypt.Click += bt_Encrypt_Click;
            // 
            // rtb_PublicKey
            // 
            rtb_PublicKey.Location = new Point(54, 335);
            rtb_PublicKey.Margin = new Padding(2);
            rtb_PublicKey.Name = "rtb_PublicKey";
            rtb_PublicKey.ReadOnly = true;
            rtb_PublicKey.Size = new Size(207, 59);
            rtb_PublicKey.TabIndex = 16;
            rtb_PublicKey.Text = "";
            // 
            // rtb_PrivateKey
            // 
            rtb_PrivateKey.Location = new Point(322, 334);
            rtb_PrivateKey.Margin = new Padding(2);
            rtb_PrivateKey.Name = "rtb_PrivateKey";
            rtb_PrivateKey.ReadOnly = true;
            rtb_PrivateKey.Size = new Size(219, 59);
            rtb_PrivateKey.TabIndex = 17;
            rtb_PrivateKey.Text = "";
            // 
            // bt_KeyPair_Gen
            // 
            bt_KeyPair_Gen.Location = new Point(591, 331);
            bt_KeyPair_Gen.Margin = new Padding(2);
            bt_KeyPair_Gen.Name = "bt_KeyPair_Gen";
            bt_KeyPair_Gen.Size = new Size(78, 59);
            bt_KeyPair_Gen.TabIndex = 18;
            bt_KeyPair_Gen.Text = "Generate Key-Pair";
            bt_KeyPair_Gen.UseVisualStyleBackColor = true;
            bt_KeyPair_Gen.Click += bt_KeyPair_Gen_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 313);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 19;
            label7.Text = "Public Key (e,n)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 313);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 20;
            label8.Text = "Private Key (d,n)";
            // 
            // lb_n
            // 
            lb_n.AutoSize = true;
            lb_n.Location = new Point(748, 236);
            lb_n.Margin = new Padding(2, 0, 2, 0);
            lb_n.Name = "lb_n";
            lb_n.Size = new Size(53, 15);
            lb_n.TabIndex = 22;
            lb_n.Text = "n = p * q";
            // 
            // tb_n
            // 
            tb_n.Location = new Point(748, 253);
            tb_n.Margin = new Padding(2);
            tb_n.Name = "tb_n";
            tb_n.ReadOnly = true;
            tb_n.Size = new Size(134, 23);
            tb_n.TabIndex = 21;
            // 
            // bt_Decrypt
            // 
            bt_Decrypt.Location = new Point(407, 98);
            bt_Decrypt.Margin = new Padding(2);
            bt_Decrypt.Name = "bt_Decrypt";
            bt_Decrypt.Size = new Size(106, 29);
            bt_Decrypt.TabIndex = 23;
            bt_Decrypt.Text = "Decrypt";
            bt_Decrypt.UseVisualStyleBackColor = true;
            bt_Decrypt.Click += bt_Decrypt_Click;
            // 
            // lblAlertP
            // 
            lblAlertP.AutoSize = true;
            lblAlertP.BackColor = Color.Transparent;
            lblAlertP.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblAlertP.ForeColor = Color.Red;
            lblAlertP.Location = new Point(54, 278);
            lblAlertP.Name = "lblAlertP";
            lblAlertP.Size = new Size(36, 13);
            lblAlertP.TabIndex = 48;
            lblAlertP.Text = "label1";
            lblAlertP.Visible = false;
            // 
            // lblAlertQ
            // 
            lblAlertQ.AutoSize = true;
            lblAlertQ.BackColor = Color.Transparent;
            lblAlertQ.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblAlertQ.ForeColor = Color.Red;
            lblAlertQ.Location = new Point(321, 278);
            lblAlertQ.Name = "lblAlertQ";
            lblAlertQ.Size = new Size(36, 13);
            lblAlertQ.TabIndex = 49;
            lblAlertQ.Text = "label1";
            lblAlertQ.Visible = false;
            // 
            // lblAlertE
            // 
            lblAlertE.AutoSize = true;
            lblAlertE.BackColor = Color.Transparent;
            lblAlertE.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblAlertE.ForeColor = Color.Red;
            lblAlertE.Location = new Point(588, 278);
            lblAlertE.Name = "lblAlertE";
            lblAlertE.Size = new Size(36, 13);
            lblAlertE.TabIndex = 50;
            lblAlertE.Text = "label1";
            lblAlertE.Visible = false;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(407, 182);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(106, 29);
            btnExport.TabIndex = 52;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(407, 141);
            btnImport.Margin = new Padding(2);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(106, 29);
            btnImport.TabIndex = 51;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // RSA_Encryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 414);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(lblAlertE);
            Controls.Add(lblAlertQ);
            Controls.Add(lblAlertP);
            Controls.Add(bt_Decrypt);
            Controls.Add(lb_n);
            Controls.Add(tb_n);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(bt_KeyPair_Gen);
            Controls.Add(rtb_PrivateKey);
            Controls.Add(rtb_PublicKey);
            Controls.Add(bt_Encrypt);
            Controls.Add(label6);
            Controls.Add(rtb_Output);
            Controls.Add(btnClear);
            Controls.Add(bt_GenRan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_e);
            Controls.Add(tb_q);
            Controls.Add(tb_p);
            Controls.Add(lb_Input);
            Controls.Add(rtb_Input);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "RSA_Encryption";
            Text = "RSA_Encryption";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtb_Input;
        private Label lb_Input;
        private TextBox tb_p;
        private TextBox tb_q;
        private TextBox tb_e;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button bt_GenRan;
        private Button btnClear;
        private RichTextBox rtb_Output;
        private Label label6;
        private Button bt_Encrypt;
        private RichTextBox rtb_PublicKey;
        private RichTextBox rtb_PrivateKey;
        private Button bt_KeyPair_Gen;
        private Label label7;
        private Label label8;
        private Label lb_n;
        private TextBox tb_n;
        private Button bt_Decrypt;
        private Label lblAlertP;
        private Label lblAlertQ;
        private Label lblAlertE;
        private Button btnExport;
        private Button btnImport;
    }
}
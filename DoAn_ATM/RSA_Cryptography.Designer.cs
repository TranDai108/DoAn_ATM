namespace DoAn_ATM
{
    partial class RSA_Cryptography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA_Cryptography));
            rtb_Input = new RichTextBox();
            lb_Input = new Label();
            tb_p = new TextBox();
            tb_q = new TextBox();
            tb_e = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rtb_Output = new RichTextBox();
            lb_res = new Label();
            rtb_PublicKey = new RichTextBox();
            rtb_PrivateKey = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            lblAlertP = new Label();
            lblAlertQ = new Label();
            lblAlertE = new Label();
            bt_Encrypt = new Button();
            bt_Decrypt = new Button();
            bt_Gen_Ran = new Button();
            bt_Gen_Key = new Button();
            bt_Clear = new Button();
            bt_Import = new Button();
            bt_Export = new Button();
            SuspendLayout();
            // 
            // rtb_Input
            // 
            rtb_Input.BackColor = Color.PapayaWhip;
            rtb_Input.BorderStyle = BorderStyle.None;
            rtb_Input.Cursor = Cursors.IBeam;
            rtb_Input.Font = new Font("Playfair Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb_Input.Location = new Point(136, 216);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(330, 114);
            rtb_Input.TabIndex = 2;
            rtb_Input.Text = "";
            // 
            // lb_Input
            // 
            lb_Input.AutoSize = true;
            lb_Input.BackColor = Color.Transparent;
            lb_Input.Font = new Font("Playfair Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Input.ForeColor = Color.Red;
            lb_Input.Location = new Point(120, 175);
            lb_Input.Name = "lb_Input";
            lb_Input.Size = new Size(76, 28);
            lb_Input.TabIndex = 3;
            lb_Input.Text = "Dữ liệu";
            // 
            // tb_p
            // 
            tb_p.BackColor = Color.Linen;
            tb_p.BorderStyle = BorderStyle.None;
            tb_p.Cursor = Cursors.IBeam;
            tb_p.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tb_p.Location = new Point(732, 466);
            tb_p.Multiline = true;
            tb_p.Name = "tb_p";
            tb_p.ScrollBars = ScrollBars.Horizontal;
            tb_p.Size = new Size(212, 23);
            tb_p.TabIndex = 4;
            tb_p.TextChanged += tb_p_TextChanged;
            // 
            // tb_q
            // 
            tb_q.BackColor = Color.Linen;
            tb_q.BorderStyle = BorderStyle.None;
            tb_q.Cursor = Cursors.IBeam;
            tb_q.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tb_q.Location = new Point(731, 535);
            tb_q.Multiline = true;
            tb_q.Name = "tb_q";
            tb_q.ScrollBars = ScrollBars.Horizontal;
            tb_q.Size = new Size(215, 22);
            tb_q.TabIndex = 5;
            tb_q.TextChanged += tb_q_TextChanged;
            // 
            // tb_e
            // 
            tb_e.BackColor = Color.Linen;
            tb_e.BorderStyle = BorderStyle.None;
            tb_e.Cursor = Cursors.IBeam;
            tb_e.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tb_e.Location = new Point(733, 603);
            tb_e.Multiline = true;
            tb_e.Name = "tb_e";
            tb_e.ScrollBars = ScrollBars.Horizontal;
            tb_e.Size = new Size(210, 21);
            tb_e.TabIndex = 6;
            tb_e.TextChanged += tb_e_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(689, 465);
            label2.Name = "label2";
            label2.Size = new Size(21, 22);
            label2.TabIndex = 7;
            label2.Text = "p";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(686, 534);
            label3.Name = "label3";
            label3.Size = new Size(25, 22);
            label3.TabIndex = 8;
            label3.Text = "q";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(690, 603);
            label4.Name = "label4";
            label4.Size = new Size(20, 22);
            label4.TabIndex = 9;
            label4.Text = "e";
            // 
            // rtb_Output
            // 
            rtb_Output.BackColor = Color.PapayaWhip;
            rtb_Output.BorderStyle = BorderStyle.None;
            rtb_Output.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb_Output.Location = new Point(936, 216);
            rtb_Output.Name = "rtb_Output";
            rtb_Output.ReadOnly = true;
            rtb_Output.Size = new Size(298, 135);
            rtb_Output.TabIndex = 13;
            rtb_Output.Text = "";
            // 
            // lb_res
            // 
            lb_res.AutoSize = true;
            lb_res.BackColor = Color.Transparent;
            lb_res.Font = new Font("Playfair Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_res.ForeColor = Color.Red;
            lb_res.Location = new Point(887, 171);
            lb_res.Name = "lb_res";
            lb_res.Size = new Size(80, 28);
            lb_res.TabIndex = 14;
            lb_res.Text = "Kết quả";
            // 
            // rtb_PublicKey
            // 
            rtb_PublicKey.BackColor = Color.PapayaWhip;
            rtb_PublicKey.BorderStyle = BorderStyle.None;
            rtb_PublicKey.Cursor = Cursors.IBeam;
            rtb_PublicKey.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rtb_PublicKey.Location = new Point(147, 482);
            rtb_PublicKey.Name = "rtb_PublicKey";
            rtb_PublicKey.ReadOnly = true;
            rtb_PublicKey.Size = new Size(199, 136);
            rtb_PublicKey.TabIndex = 16;
            rtb_PublicKey.Text = "";
            // 
            // rtb_PrivateKey
            // 
            rtb_PrivateKey.BackColor = Color.PapayaWhip;
            rtb_PrivateKey.BorderStyle = BorderStyle.None;
            rtb_PrivateKey.Cursor = Cursors.IBeam;
            rtb_PrivateKey.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rtb_PrivateKey.Location = new Point(444, 482);
            rtb_PrivateKey.Name = "rtb_PrivateKey";
            rtb_PrivateKey.ReadOnly = true;
            rtb_PrivateKey.Size = new Size(198, 136);
            rtb_PrivateKey.TabIndex = 17;
            rtb_PrivateKey.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Dancing Script", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(156, 639);
            label7.Name = "label7";
            label7.Size = new Size(150, 26);
            label7.TabIndex = 19;
            label7.Text = "Khóa công khai (e,n)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Dancing Script", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(456, 637);
            label8.Name = "label8";
            label8.Size = new Size(142, 28);
            label8.TabIndex = 20;
            label8.Text = "Khóa bí mật (d,n)";
            // 
            // lblAlertP
            // 
            lblAlertP.AutoSize = true;
            lblAlertP.BackColor = Color.Transparent;
            lblAlertP.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblAlertP.ForeColor = Color.Red;
            lblAlertP.Location = new Point(686, 500);
            lblAlertP.Margin = new Padding(4, 0, 4, 0);
            lblAlertP.Name = "lblAlertP";
            lblAlertP.Size = new Size(53, 21);
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
            lblAlertQ.Location = new Point(689, 568);
            lblAlertQ.Margin = new Padding(4, 0, 4, 0);
            lblAlertQ.Name = "lblAlertQ";
            lblAlertQ.Size = new Size(53, 21);
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
            lblAlertE.Location = new Point(690, 637);
            lblAlertE.Margin = new Padding(4, 0, 4, 0);
            lblAlertE.Name = "lblAlertE";
            lblAlertE.Size = new Size(53, 21);
            lblAlertE.TabIndex = 50;
            lblAlertE.Text = "label1";
            lblAlertE.Visible = false;
            // 
            // bt_Encrypt
            // 
            bt_Encrypt.BackColor = Color.Transparent;
            bt_Encrypt.FlatStyle = FlatStyle.Flat;
            bt_Encrypt.Font = new Font("Dancing Script", 14F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Encrypt.ForeColor = Color.Gold;
            bt_Encrypt.Location = new Point(616, 213);
            bt_Encrypt.Name = "bt_Encrypt";
            bt_Encrypt.Size = new Size(125, 50);
            bt_Encrypt.TabIndex = 61;
            bt_Encrypt.Text = "Mã hóa";
            bt_Encrypt.UseVisualStyleBackColor = false;
            bt_Encrypt.Click += bt_Encrypt_Click;
            // 
            // bt_Decrypt
            // 
            bt_Decrypt.BackColor = Color.Transparent;
            bt_Decrypt.FlatStyle = FlatStyle.Flat;
            bt_Decrypt.Font = new Font("Dancing Script", 14F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Decrypt.ForeColor = Color.Yellow;
            bt_Decrypt.Location = new Point(617, 305);
            bt_Decrypt.Name = "bt_Decrypt";
            bt_Decrypt.Size = new Size(125, 50);
            bt_Decrypt.TabIndex = 62;
            bt_Decrypt.Text = "Giải mã";
            bt_Decrypt.UseVisualStyleBackColor = false;
            bt_Decrypt.Click += bt_Decrypt_Click;
            // 
            // bt_Gen_Ran
            // 
            bt_Gen_Ran.BackColor = Color.Transparent;
            bt_Gen_Ran.FlatStyle = FlatStyle.Flat;
            bt_Gen_Ran.Font = new Font("Dancing Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Gen_Ran.ForeColor = Color.Gold;
            bt_Gen_Ran.Location = new Point(992, 459);
            bt_Gen_Ran.Name = "bt_Gen_Ran";
            bt_Gen_Ran.Size = new Size(165, 87);
            bt_Gen_Ran.TabIndex = 63;
            bt_Gen_Ran.Text = "Tạo giá trị ngẫu nhiên";
            bt_Gen_Ran.UseVisualStyleBackColor = false;
            bt_Gen_Ran.Click += bt_Gen_Ran_Click;
            // 
            // bt_Gen_Key
            // 
            bt_Gen_Key.BackColor = Color.Transparent;
            bt_Gen_Key.FlatStyle = FlatStyle.Flat;
            bt_Gen_Key.Font = new Font("Dancing Script", 14F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Gen_Key.ForeColor = Color.Gold;
            bt_Gen_Key.Location = new Point(992, 566);
            bt_Gen_Key.Name = "bt_Gen_Key";
            bt_Gen_Key.Size = new Size(165, 63);
            bt_Gen_Key.TabIndex = 64;
            bt_Gen_Key.Text = "Tạo khóa";
            bt_Gen_Key.UseVisualStyleBackColor = false;
            bt_Gen_Key.Click += bt_Gen_Key_Click;
            // 
            // bt_Clear
            // 
            bt_Clear.BackColor = Color.Transparent;
            bt_Clear.FlatStyle = FlatStyle.Flat;
            bt_Clear.Font = new Font("Dancing Script", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Clear.ForeColor = Color.Gold;
            bt_Clear.Location = new Point(1176, 459);
            bt_Clear.Name = "bt_Clear";
            bt_Clear.Size = new Size(87, 170);
            bt_Clear.TabIndex = 65;
            bt_Clear.Text = "Xóa";
            bt_Clear.TextAlign = ContentAlignment.BottomCenter;
            bt_Clear.UseVisualStyleBackColor = false;
            bt_Clear.Click += bt_Clear_Click;
            // 
            // bt_Import
            // 
            bt_Import.BackColor = Color.Transparent;
            bt_Import.FlatStyle = FlatStyle.Flat;
            bt_Import.Font = new Font("Dancing Script", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Import.ForeColor = Color.Gold;
            bt_Import.Location = new Point(255, 385);
            bt_Import.Name = "bt_Import";
            bt_Import.Size = new Size(96, 35);
            bt_Import.TabIndex = 66;
            bt_Import.Text = "Thêm file";
            bt_Import.UseVisualStyleBackColor = false;
            bt_Import.Click += bt_Import_Click;
            // 
            // bt_Export
            // 
            bt_Export.BackColor = Color.Transparent;
            bt_Export.FlatStyle = FlatStyle.Flat;
            bt_Export.Font = new Font("Dancing Script", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Export.ForeColor = Color.Gold;
            bt_Export.Location = new Point(1035, 379);
            bt_Export.Name = "bt_Export";
            bt_Export.Size = new Size(96, 35);
            bt_Export.TabIndex = 67;
            bt_Export.Text = "Xuất file";
            bt_Export.UseVisualStyleBackColor = false;
            bt_Export.Click += bt_Export_Click;
            // 
            // RSA_Cryptography
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1306, 690);
            Controls.Add(bt_Export);
            Controls.Add(bt_Import);
            Controls.Add(bt_Clear);
            Controls.Add(bt_Gen_Key);
            Controls.Add(bt_Gen_Ran);
            Controls.Add(bt_Decrypt);
            Controls.Add(bt_Encrypt);
            Controls.Add(lblAlertE);
            Controls.Add(lblAlertQ);
            Controls.Add(lblAlertP);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(rtb_PrivateKey);
            Controls.Add(rtb_PublicKey);
            Controls.Add(lb_res);
            Controls.Add(rtb_Output);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_e);
            Controls.Add(tb_q);
            Controls.Add(tb_p);
            Controls.Add(lb_Input);
            Controls.Add(rtb_Input);
            MaximizeBox = false;
            Name = "RSA_Cryptography";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSA Cryptography";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtb_Input;
        private Label lb_Input;
        private TextBox tb_p;
        private TextBox tb_q;
        private TextBox tb_e;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox rtb_Output;
        private Label lb_res;
        private RichTextBox rtb_PublicKey;
        private RichTextBox rtb_PrivateKey;
        private Label label7;
        private Label label8;
        private Label lblAlertP;
        private Label lblAlertQ;
        private Label lblAlertE;
        private Button bt_Encrypt;
        private Button bt_Decrypt;
        private Button bt_Gen_Ran;
        private Button bt_Gen_Key;
        private Button bt_Clear;
        private Button bt_Import;
        private Button bt_Export;
    }
}
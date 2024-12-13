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
        private void InitializeComponent()
        {
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
            button1 = new Button();
            rtb_Output = new RichTextBox();
            label6 = new Label();
            bt_Encrypt = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(578, 34);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 1;
            label1.Text = "RSA ENCRYPTION";
            // 
            // rtb_Input
            // 
            rtb_Input.Location = new Point(80, 111);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(477, 211);
            rtb_Input.TabIndex = 2;
            rtb_Input.Text = "";
            // 
            // lb_Input
            // 
            lb_Input.AutoSize = true;
            lb_Input.Location = new Point(286, 81);
            lb_Input.Name = "lb_Input";
            lb_Input.Size = new Size(54, 25);
            lb_Input.TabIndex = 3;
            lb_Input.Text = "Input";
            // 
            // tb_p
            // 
            tb_p.Location = new Point(77, 421);
            tb_p.Name = "tb_p";
            tb_p.Size = new Size(294, 31);
            tb_p.TabIndex = 4;
            // 
            // tb_q
            // 
            tb_q.Location = new Point(459, 421);
            tb_q.Name = "tb_q";
            tb_q.Size = new Size(312, 31);
            tb_q.TabIndex = 5;
            // 
            // tb_e
            // 
            tb_e.Location = new Point(840, 421);
            tb_e.Name = "tb_e";
            tb_e.Size = new Size(190, 31);
            tb_e.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 393);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 7;
            label2.Text = "p";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 393);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 8;
            label3.Text = "q";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(840, 393);
            label4.Name = "label4";
            label4.Size = new Size(21, 25);
            label4.TabIndex = 9;
            label4.Text = "e";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 344);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 10;
            label5.Text = "Create Key-Pair";
            // 
            // bt_GenRan
            // 
            bt_GenRan.Location = new Point(962, 508);
            bt_GenRan.Name = "bt_GenRan";
            bt_GenRan.Size = new Size(297, 51);
            bt_GenRan.TabIndex = 11;
            bt_GenRan.Text = "Generate Random Value";
            bt_GenRan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(964, 565);
            button1.Name = "button1";
            button1.Size = new Size(297, 41);
            button1.TabIndex = 12;
            button1.Text = "Save Key-Pair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rtb_Output
            // 
            rtb_Output.Location = new Point(764, 109);
            rtb_Output.Name = "rtb_Output";
            rtb_Output.Size = new Size(477, 211);
            rtb_Output.TabIndex = 13;
            rtb_Output.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(979, 81);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 14;
            label6.Text = "Output";
            // 
            // bt_Encrypt
            // 
            bt_Encrypt.Location = new Point(582, 167);
            bt_Encrypt.Name = "bt_Encrypt";
            bt_Encrypt.Size = new Size(151, 94);
            bt_Encrypt.TabIndex = 15;
            bt_Encrypt.Text = "Encrypt";
            bt_Encrypt.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(77, 515);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(294, 96);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(460, 513);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(311, 96);
            richTextBox2.TabIndex = 17;
            richTextBox2.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(844, 508);
            button2.Name = "button2";
            button2.Size = new Size(112, 98);
            button2.TabIndex = 18;
            button2.Text = "Generate Key-Pair";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(175, 479);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 19;
            label7.Text = "Public Key";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(565, 479);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 20;
            label8.Text = "Private Key";
            // 
            // RSA_Encryption
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 690);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(bt_Encrypt);
            Controls.Add(label6);
            Controls.Add(rtb_Output);
            Controls.Add(button1);
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
        private Button button1;
        private RichTextBox rtb_Output;
        private Label label6;
        private Button bt_Encrypt;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button2;
        private Label label7;
        private Label label8;
    }
}
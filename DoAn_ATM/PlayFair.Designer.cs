namespace DoAn_ATM
{
    partial class PlayFair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayFair));
            label = new Label();
            labelText = new Label();
            labelKey = new Label();
            tbText = new TextBox();
            labelKeymatrix = new Label();
            btEncrypt = new Button();
            btDecrypt = new Button();
            btClear = new Button();
            tbKey = new TextBox();
            tb00 = new TextBox();
            tb01 = new TextBox();
            tb02 = new TextBox();
            tb03 = new TextBox();
            tb04 = new TextBox();
            tb05 = new TextBox();
            tb15 = new TextBox();
            tb14 = new TextBox();
            tb13 = new TextBox();
            tb12 = new TextBox();
            tb11 = new TextBox();
            tb10 = new TextBox();
            tb25 = new TextBox();
            tb24 = new TextBox();
            tb23 = new TextBox();
            tb22 = new TextBox();
            tb21 = new TextBox();
            tb20 = new TextBox();
            tb35 = new TextBox();
            tb34 = new TextBox();
            tb33 = new TextBox();
            tb32 = new TextBox();
            tb31 = new TextBox();
            tb30 = new TextBox();
            tb45 = new TextBox();
            tb44 = new TextBox();
            tb43 = new TextBox();
            tb42 = new TextBox();
            tb41 = new TextBox();
            tb40 = new TextBox();
            labelResult = new Label();
            tbResult = new TextBox();
            pnlMatrix = new Panel();
            tb55 = new TextBox();
            tb54 = new TextBox();
            tb53 = new TextBox();
            tb52 = new TextBox();
            tb51 = new TextBox();
            tb50 = new TextBox();
            lblAlertKey = new Label();
            rb5x5 = new RadioButton();
            rb6x6 = new RadioButton();
            btImport = new Button();
            btExport = new Button();
            pnlMatrix.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Black;
            label.Location = new Point(411, 19);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(594, 159);
            label.TabIndex = 0;
            label.Text = "PLAYFAIR";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.BackColor = Color.Transparent;
            labelText.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            labelText.ForeColor = Color.Red;
            labelText.Location = new Point(178, 266);
            labelText.Margin = new Padding(4, 0, 4, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(97, 53);
            labelText.TabIndex = 1;
            labelText.Text = "Text";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.BackColor = Color.Transparent;
            labelKey.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            labelKey.ForeColor = Color.Red;
            labelKey.Location = new Point(34, 400);
            labelKey.Margin = new Padding(4, 0, 4, 0);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(246, 53);
            labelKey.TabIndex = 2;
            labelKey.Text = "PlayFair Key";
            // 
            // tbText
            // 
            tbText.BackColor = Color.LavenderBlush;
            tbText.Font = new Font("Segoe UI", 10.875F);
            tbText.Location = new Point(287, 272);
            tbText.Margin = new Padding(4, 2, 4, 2);
            tbText.Name = "tbText";
            tbText.Size = new Size(383, 46);
            tbText.TabIndex = 3;
            tbText.TextChanged += tbText_TextChanged;
            // 
            // labelKeymatrix
            // 
            labelKeymatrix.AutoSize = true;
            labelKeymatrix.BackColor = Color.Transparent;
            labelKeymatrix.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKeymatrix.Location = new Point(725, 204);
            labelKeymatrix.Margin = new Padding(4, 0, 4, 0);
            labelKeymatrix.Name = "labelKeymatrix";
            labelKeymatrix.Size = new Size(153, 43);
            labelKeymatrix.TabIndex = 4;
            labelKeymatrix.Text = "Key Matrix";
            // 
            // btEncrypt
            // 
            btEncrypt.BackColor = Color.LightPink;
            btEncrypt.Font = new Font("Segoe Print", 10.875F, FontStyle.Bold);
            btEncrypt.Location = new Point(108, 551);
            btEncrypt.Margin = new Padding(4, 2, 4, 2);
            btEncrypt.Name = "btEncrypt";
            btEncrypt.Size = new Size(167, 74);
            btEncrypt.TabIndex = 5;
            btEncrypt.Text = "Encrypt";
            btEncrypt.UseVisualStyleBackColor = false;
            btEncrypt.Click += btEncrypt_Click;
            // 
            // btDecrypt
            // 
            btDecrypt.BackColor = Color.LightPink;
            btDecrypt.Font = new Font("Segoe Print", 10.875F, FontStyle.Bold);
            btDecrypt.Location = new Point(304, 551);
            btDecrypt.Margin = new Padding(4, 2, 4, 2);
            btDecrypt.Name = "btDecrypt";
            btDecrypt.Size = new Size(167, 74);
            btDecrypt.TabIndex = 6;
            btDecrypt.Text = "Decrypt";
            btDecrypt.UseVisualStyleBackColor = false;
            btDecrypt.Click += btDecrypt_Click;
            // 
            // btClear
            // 
            btClear.BackColor = Color.LightPink;
            btClear.Font = new Font("Segoe Print", 10.875F, FontStyle.Bold);
            btClear.Location = new Point(896, 703);
            btClear.Margin = new Padding(4, 2, 4, 2);
            btClear.Name = "btClear";
            btClear.Size = new Size(170, 74);
            btClear.TabIndex = 7;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // tbKey
            // 
            tbKey.BackColor = Color.LavenderBlush;
            tbKey.CharacterCasing = CharacterCasing.Upper;
            tbKey.Font = new Font("Segoe UI", 10.875F);
            tbKey.Location = new Point(287, 404);
            tbKey.Margin = new Padding(4, 2, 4, 2);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(383, 46);
            tbKey.TabIndex = 10;
            tbKey.TextChanged += tbKey_TextChanged;
            // 
            // tb00
            // 
            tb00.BackColor = Color.LavenderBlush;
            tb00.Location = new Point(20, 19);
            tb00.Margin = new Padding(4, 2, 4, 2);
            tb00.Name = "tb00";
            tb00.ReadOnly = true;
            tb00.Size = new Size(49, 39);
            tb00.TabIndex = 12;
            tb00.TextAlign = HorizontalAlignment.Center;
            // 
            // tb01
            // 
            tb01.BackColor = Color.LavenderBlush;
            tb01.Location = new Point(87, 19);
            tb01.Margin = new Padding(4, 2, 4, 2);
            tb01.Name = "tb01";
            tb01.ReadOnly = true;
            tb01.Size = new Size(49, 39);
            tb01.TabIndex = 13;
            tb01.TextAlign = HorizontalAlignment.Center;
            // 
            // tb02
            // 
            tb02.BackColor = Color.LavenderBlush;
            tb02.Location = new Point(150, 19);
            tb02.Margin = new Padding(4, 2, 4, 2);
            tb02.Name = "tb02";
            tb02.ReadOnly = true;
            tb02.Size = new Size(49, 39);
            tb02.TabIndex = 14;
            tb02.TextAlign = HorizontalAlignment.Center;
            // 
            // tb03
            // 
            tb03.BackColor = Color.LavenderBlush;
            tb03.Location = new Point(217, 19);
            tb03.Margin = new Padding(4, 2, 4, 2);
            tb03.Name = "tb03";
            tb03.ReadOnly = true;
            tb03.Size = new Size(49, 39);
            tb03.TabIndex = 15;
            tb03.TextAlign = HorizontalAlignment.Center;
            // 
            // tb04
            // 
            tb04.BackColor = Color.LavenderBlush;
            tb04.Location = new Point(284, 19);
            tb04.Margin = new Padding(4, 2, 4, 2);
            tb04.Name = "tb04";
            tb04.ReadOnly = true;
            tb04.Size = new Size(49, 39);
            tb04.TabIndex = 16;
            tb04.TextAlign = HorizontalAlignment.Center;
            // 
            // tb05
            // 
            tb05.BackColor = Color.LavenderBlush;
            tb05.Location = new Point(353, 19);
            tb05.Margin = new Padding(4, 2, 4, 2);
            tb05.Name = "tb05";
            tb05.ReadOnly = true;
            tb05.Size = new Size(49, 39);
            tb05.TabIndex = 17;
            tb05.TextAlign = HorizontalAlignment.Center;
            // 
            // tb15
            // 
            tb15.BackColor = Color.LavenderBlush;
            tb15.Location = new Point(353, 79);
            tb15.Margin = new Padding(4, 2, 4, 2);
            tb15.Name = "tb15";
            tb15.ReadOnly = true;
            tb15.Size = new Size(49, 39);
            tb15.TabIndex = 23;
            tb15.TextAlign = HorizontalAlignment.Center;
            // 
            // tb14
            // 
            tb14.BackColor = Color.LavenderBlush;
            tb14.Location = new Point(284, 79);
            tb14.Margin = new Padding(4, 2, 4, 2);
            tb14.Name = "tb14";
            tb14.ReadOnly = true;
            tb14.Size = new Size(49, 39);
            tb14.TabIndex = 22;
            tb14.TextAlign = HorizontalAlignment.Center;
            // 
            // tb13
            // 
            tb13.BackColor = Color.LavenderBlush;
            tb13.Location = new Point(217, 79);
            tb13.Margin = new Padding(4, 2, 4, 2);
            tb13.Name = "tb13";
            tb13.ReadOnly = true;
            tb13.Size = new Size(49, 39);
            tb13.TabIndex = 21;
            tb13.TextAlign = HorizontalAlignment.Center;
            // 
            // tb12
            // 
            tb12.BackColor = Color.LavenderBlush;
            tb12.Location = new Point(150, 79);
            tb12.Margin = new Padding(4, 2, 4, 2);
            tb12.Name = "tb12";
            tb12.ReadOnly = true;
            tb12.Size = new Size(49, 39);
            tb12.TabIndex = 20;
            tb12.TextAlign = HorizontalAlignment.Center;
            // 
            // tb11
            // 
            tb11.BackColor = Color.LavenderBlush;
            tb11.Location = new Point(87, 79);
            tb11.Margin = new Padding(4, 2, 4, 2);
            tb11.Name = "tb11";
            tb11.ReadOnly = true;
            tb11.Size = new Size(49, 39);
            tb11.TabIndex = 19;
            tb11.TextAlign = HorizontalAlignment.Center;
            // 
            // tb10
            // 
            tb10.BackColor = Color.LavenderBlush;
            tb10.Location = new Point(20, 79);
            tb10.Margin = new Padding(4, 2, 4, 2);
            tb10.Name = "tb10";
            tb10.ReadOnly = true;
            tb10.Size = new Size(49, 39);
            tb10.TabIndex = 18;
            tb10.TextAlign = HorizontalAlignment.Center;
            // 
            // tb25
            // 
            tb25.BackColor = Color.LavenderBlush;
            tb25.Location = new Point(353, 139);
            tb25.Margin = new Padding(4, 2, 4, 2);
            tb25.Name = "tb25";
            tb25.ReadOnly = true;
            tb25.Size = new Size(49, 39);
            tb25.TabIndex = 29;
            tb25.TextAlign = HorizontalAlignment.Center;
            // 
            // tb24
            // 
            tb24.BackColor = Color.LavenderBlush;
            tb24.Location = new Point(284, 139);
            tb24.Margin = new Padding(4, 2, 4, 2);
            tb24.Name = "tb24";
            tb24.ReadOnly = true;
            tb24.Size = new Size(49, 39);
            tb24.TabIndex = 28;
            tb24.TextAlign = HorizontalAlignment.Center;
            // 
            // tb23
            // 
            tb23.BackColor = Color.LavenderBlush;
            tb23.Location = new Point(217, 139);
            tb23.Margin = new Padding(4, 2, 4, 2);
            tb23.Name = "tb23";
            tb23.ReadOnly = true;
            tb23.Size = new Size(49, 39);
            tb23.TabIndex = 27;
            tb23.TextAlign = HorizontalAlignment.Center;
            // 
            // tb22
            // 
            tb22.BackColor = Color.LavenderBlush;
            tb22.Location = new Point(150, 139);
            tb22.Margin = new Padding(4, 2, 4, 2);
            tb22.Name = "tb22";
            tb22.ReadOnly = true;
            tb22.Size = new Size(49, 39);
            tb22.TabIndex = 26;
            tb22.TextAlign = HorizontalAlignment.Center;
            // 
            // tb21
            // 
            tb21.BackColor = Color.LavenderBlush;
            tb21.Location = new Point(87, 139);
            tb21.Margin = new Padding(4, 2, 4, 2);
            tb21.Name = "tb21";
            tb21.ReadOnly = true;
            tb21.Size = new Size(49, 39);
            tb21.TabIndex = 25;
            tb21.TextAlign = HorizontalAlignment.Center;
            // 
            // tb20
            // 
            tb20.BackColor = Color.LavenderBlush;
            tb20.Location = new Point(20, 139);
            tb20.Margin = new Padding(4, 2, 4, 2);
            tb20.Name = "tb20";
            tb20.ReadOnly = true;
            tb20.Size = new Size(49, 39);
            tb20.TabIndex = 24;
            tb20.TextAlign = HorizontalAlignment.Center;
            // 
            // tb35
            // 
            tb35.BackColor = Color.LavenderBlush;
            tb35.Location = new Point(353, 201);
            tb35.Margin = new Padding(4, 2, 4, 2);
            tb35.Name = "tb35";
            tb35.ReadOnly = true;
            tb35.Size = new Size(49, 39);
            tb35.TabIndex = 35;
            tb35.TextAlign = HorizontalAlignment.Center;
            // 
            // tb34
            // 
            tb34.BackColor = Color.LavenderBlush;
            tb34.Location = new Point(284, 201);
            tb34.Margin = new Padding(4, 2, 4, 2);
            tb34.Name = "tb34";
            tb34.ReadOnly = true;
            tb34.Size = new Size(49, 39);
            tb34.TabIndex = 34;
            tb34.TextAlign = HorizontalAlignment.Center;
            // 
            // tb33
            // 
            tb33.BackColor = Color.LavenderBlush;
            tb33.Location = new Point(217, 201);
            tb33.Margin = new Padding(4, 2, 4, 2);
            tb33.Name = "tb33";
            tb33.ReadOnly = true;
            tb33.Size = new Size(49, 39);
            tb33.TabIndex = 33;
            tb33.TextAlign = HorizontalAlignment.Center;
            // 
            // tb32
            // 
            tb32.BackColor = Color.LavenderBlush;
            tb32.Location = new Point(150, 201);
            tb32.Margin = new Padding(4, 2, 4, 2);
            tb32.Name = "tb32";
            tb32.ReadOnly = true;
            tb32.Size = new Size(49, 39);
            tb32.TabIndex = 32;
            tb32.TextAlign = HorizontalAlignment.Center;
            // 
            // tb31
            // 
            tb31.BackColor = Color.LavenderBlush;
            tb31.Location = new Point(87, 201);
            tb31.Margin = new Padding(4, 2, 4, 2);
            tb31.Name = "tb31";
            tb31.ReadOnly = true;
            tb31.Size = new Size(49, 39);
            tb31.TabIndex = 31;
            tb31.TextAlign = HorizontalAlignment.Center;
            // 
            // tb30
            // 
            tb30.BackColor = Color.LavenderBlush;
            tb30.Location = new Point(20, 201);
            tb30.Margin = new Padding(4, 2, 4, 2);
            tb30.Name = "tb30";
            tb30.ReadOnly = true;
            tb30.Size = new Size(49, 39);
            tb30.TabIndex = 30;
            tb30.TextAlign = HorizontalAlignment.Center;
            // 
            // tb45
            // 
            tb45.BackColor = Color.LavenderBlush;
            tb45.Location = new Point(353, 265);
            tb45.Margin = new Padding(4, 2, 4, 2);
            tb45.Name = "tb45";
            tb45.ReadOnly = true;
            tb45.Size = new Size(49, 39);
            tb45.TabIndex = 41;
            tb45.TextAlign = HorizontalAlignment.Center;
            // 
            // tb44
            // 
            tb44.BackColor = Color.LavenderBlush;
            tb44.Location = new Point(284, 265);
            tb44.Margin = new Padding(4, 2, 4, 2);
            tb44.Name = "tb44";
            tb44.ReadOnly = true;
            tb44.Size = new Size(49, 39);
            tb44.TabIndex = 40;
            tb44.TextAlign = HorizontalAlignment.Center;
            // 
            // tb43
            // 
            tb43.BackColor = Color.LavenderBlush;
            tb43.Location = new Point(217, 265);
            tb43.Margin = new Padding(4, 2, 4, 2);
            tb43.Name = "tb43";
            tb43.ReadOnly = true;
            tb43.Size = new Size(49, 39);
            tb43.TabIndex = 39;
            tb43.TextAlign = HorizontalAlignment.Center;
            // 
            // tb42
            // 
            tb42.BackColor = Color.LavenderBlush;
            tb42.Location = new Point(150, 265);
            tb42.Margin = new Padding(4, 2, 4, 2);
            tb42.Name = "tb42";
            tb42.ReadOnly = true;
            tb42.Size = new Size(49, 39);
            tb42.TabIndex = 38;
            tb42.TextAlign = HorizontalAlignment.Center;
            // 
            // tb41
            // 
            tb41.BackColor = Color.LavenderBlush;
            tb41.Location = new Point(87, 265);
            tb41.Margin = new Padding(4, 2, 4, 2);
            tb41.Name = "tb41";
            tb41.ReadOnly = true;
            tb41.Size = new Size(49, 39);
            tb41.TabIndex = 37;
            tb41.TextAlign = HorizontalAlignment.Center;
            // 
            // tb40
            // 
            tb40.BackColor = Color.LavenderBlush;
            tb40.Location = new Point(20, 265);
            tb40.Margin = new Padding(4, 2, 4, 2);
            tb40.Name = "tb40";
            tb40.ReadOnly = true;
            tb40.Size = new Size(49, 39);
            tb40.TabIndex = 36;
            tb40.TextAlign = HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.Transparent;
            labelResult.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            labelResult.ForeColor = Color.Red;
            labelResult.Location = new Point(341, 717);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(133, 53);
            labelResult.TabIndex = 44;
            labelResult.Text = "Result";
            // 
            // tbResult
            // 
            tbResult.BackColor = Color.LavenderBlush;
            tbResult.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbResult.Location = new Point(482, 723);
            tbResult.Margin = new Padding(4, 2, 4, 2);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(383, 43);
            tbResult.TabIndex = 45;
            tbResult.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlMatrix
            // 
            pnlMatrix.BackColor = Color.LavenderBlush;
            pnlMatrix.Controls.Add(tb55);
            pnlMatrix.Controls.Add(tb54);
            pnlMatrix.Controls.Add(tb53);
            pnlMatrix.Controls.Add(tb52);
            pnlMatrix.Controls.Add(tb51);
            pnlMatrix.Controls.Add(tb50);
            pnlMatrix.Controls.Add(tb45);
            pnlMatrix.Controls.Add(tb44);
            pnlMatrix.Controls.Add(tb43);
            pnlMatrix.Controls.Add(tb42);
            pnlMatrix.Controls.Add(tb41);
            pnlMatrix.Controls.Add(tb40);
            pnlMatrix.Controls.Add(tb35);
            pnlMatrix.Controls.Add(tb34);
            pnlMatrix.Controls.Add(tb33);
            pnlMatrix.Controls.Add(tb32);
            pnlMatrix.Controls.Add(tb31);
            pnlMatrix.Controls.Add(tb30);
            pnlMatrix.Controls.Add(tb25);
            pnlMatrix.Controls.Add(tb24);
            pnlMatrix.Controls.Add(tb23);
            pnlMatrix.Controls.Add(tb22);
            pnlMatrix.Controls.Add(tb21);
            pnlMatrix.Controls.Add(tb20);
            pnlMatrix.Controls.Add(tb15);
            pnlMatrix.Controls.Add(tb14);
            pnlMatrix.Controls.Add(tb13);
            pnlMatrix.Controls.Add(tb12);
            pnlMatrix.Controls.Add(tb11);
            pnlMatrix.Controls.Add(tb10);
            pnlMatrix.Controls.Add(tb05);
            pnlMatrix.Controls.Add(tb04);
            pnlMatrix.Controls.Add(tb03);
            pnlMatrix.Controls.Add(tb02);
            pnlMatrix.Controls.Add(tb01);
            pnlMatrix.Controls.Add(tb00);
            pnlMatrix.Location = new Point(733, 262);
            pnlMatrix.Margin = new Padding(4, 2, 4, 2);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(426, 389);
            pnlMatrix.TabIndex = 46;
            // 
            // tb55
            // 
            tb55.BackColor = Color.LavenderBlush;
            tb55.Location = new Point(353, 324);
            tb55.Margin = new Padding(4, 2, 4, 2);
            tb55.Name = "tb55";
            tb55.ReadOnly = true;
            tb55.Size = new Size(49, 39);
            tb55.TabIndex = 47;
            tb55.TextAlign = HorizontalAlignment.Center;
            // 
            // tb54
            // 
            tb54.BackColor = Color.LavenderBlush;
            tb54.Location = new Point(284, 324);
            tb54.Margin = new Padding(4, 2, 4, 2);
            tb54.Name = "tb54";
            tb54.ReadOnly = true;
            tb54.Size = new Size(49, 39);
            tb54.TabIndex = 46;
            tb54.TextAlign = HorizontalAlignment.Center;
            // 
            // tb53
            // 
            tb53.BackColor = Color.LavenderBlush;
            tb53.Location = new Point(217, 324);
            tb53.Margin = new Padding(4, 2, 4, 2);
            tb53.Name = "tb53";
            tb53.ReadOnly = true;
            tb53.Size = new Size(49, 39);
            tb53.TabIndex = 45;
            tb53.TextAlign = HorizontalAlignment.Center;
            // 
            // tb52
            // 
            tb52.BackColor = Color.LavenderBlush;
            tb52.Location = new Point(150, 324);
            tb52.Margin = new Padding(4, 2, 4, 2);
            tb52.Name = "tb52";
            tb52.ReadOnly = true;
            tb52.Size = new Size(49, 39);
            tb52.TabIndex = 44;
            tb52.TextAlign = HorizontalAlignment.Center;
            // 
            // tb51
            // 
            tb51.BackColor = Color.LavenderBlush;
            tb51.Location = new Point(87, 324);
            tb51.Margin = new Padding(4, 2, 4, 2);
            tb51.Name = "tb51";
            tb51.ReadOnly = true;
            tb51.Size = new Size(49, 39);
            tb51.TabIndex = 43;
            tb51.TextAlign = HorizontalAlignment.Center;
            // 
            // tb50
            // 
            tb50.BackColor = Color.LavenderBlush;
            tb50.Location = new Point(20, 324);
            tb50.Margin = new Padding(4, 2, 4, 2);
            tb50.Name = "tb50";
            tb50.ReadOnly = true;
            tb50.Size = new Size(49, 39);
            tb50.TabIndex = 42;
            tb50.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAlertKey
            // 
            lblAlertKey.AutoSize = true;
            lblAlertKey.BackColor = Color.Transparent;
            lblAlertKey.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblAlertKey.ForeColor = Color.Red;
            lblAlertKey.Location = new Point(287, 452);
            lblAlertKey.Margin = new Padding(6, 0, 6, 0);
            lblAlertKey.Name = "lblAlertKey";
            lblAlertKey.Size = new Size(66, 30);
            lblAlertKey.TabIndex = 47;
            lblAlertKey.Text = "label1";
            lblAlertKey.Visible = false;
            // 
            // rb5x5
            // 
            rb5x5.AutoSize = true;
            rb5x5.BackColor = Color.Transparent;
            rb5x5.Checked = true;
            rb5x5.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            rb5x5.Location = new Point(1188, 253);
            rb5x5.Margin = new Padding(6);
            rb5x5.Name = "rb5x5";
            rb5x5.Size = new Size(187, 47);
            rb5x5.TabIndex = 48;
            rb5x5.TabStop = true;
            rb5x5.Text = "Matrix 5x5";
            rb5x5.UseVisualStyleBackColor = false;
            rb5x5.CheckedChanged += rb5x5_CheckedChanged;
            // 
            // rb6x6
            // 
            rb6x6.AutoSize = true;
            rb6x6.BackColor = Color.Transparent;
            rb6x6.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            rb6x6.Location = new Point(1188, 321);
            rb6x6.Margin = new Padding(6);
            rb6x6.Name = "rb6x6";
            rb6x6.Size = new Size(187, 47);
            rb6x6.TabIndex = 48;
            rb6x6.Text = "Matrix 6x6";
            rb6x6.UseVisualStyleBackColor = false;
            rb6x6.CheckedChanged += rb6x6_CheckedChanged;
            // 
            // btImport
            // 
            btImport.BackColor = Color.LightPink;
            btImport.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btImport.Location = new Point(550, 327);
            btImport.Name = "btImport";
            btImport.Size = new Size(120, 53);
            btImport.TabIndex = 49;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = false;
            // 
            // btExport
            // 
            btExport.BackColor = Color.LightPink;
            btExport.Font = new Font("Segoe Print", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btExport.Location = new Point(502, 551);
            btExport.Name = "btExport";
            btExport.Size = new Size(170, 74);
            btExport.TabIndex = 50;
            btExport.Text = "Export";
            btExport.UseVisualStyleBackColor = false;
            // 
            // PlayFair
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1427, 820);
            Controls.Add(btExport);
            Controls.Add(btImport);
            Controls.Add(rb6x6);
            Controls.Add(rb5x5);
            Controls.Add(lblAlertKey);
            Controls.Add(pnlMatrix);
            Controls.Add(tbResult);
            Controls.Add(labelResult);
            Controls.Add(tbKey);
            Controls.Add(btClear);
            Controls.Add(btDecrypt);
            Controls.Add(btEncrypt);
            Controls.Add(labelKeymatrix);
            Controls.Add(tbText);
            Controls.Add(labelKey);
            Controls.Add(labelText);
            Controls.Add(label);
            DoubleBuffered = true;
            Margin = new Padding(4, 2, 4, 2);
            Name = "PlayFair";
            Text = "PlayFair";
            pnlMatrix.ResumeLayout(false);
            pnlMatrix.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label labelText;
        private Label labelKey;
        private TextBox tbText;
        private Label labelKeymatrix;
        private Button btEncrypt;
        private Button btDecrypt;
        private Button btClear;
        private TextBox tbKey;
        private TextBox tb00;
        private TextBox tb01;
        private TextBox tb02;
        private TextBox tb03;
        private TextBox tb04;
        private TextBox tb05;
        private TextBox tb15;
        private TextBox tb14;
        private TextBox tb13;
        private TextBox tb12;
        private TextBox tb11;
        private TextBox tb10;
        private TextBox tb25;
        private TextBox tb24;
        private TextBox tb23;
        private TextBox tb22;
        private TextBox tb21;
        private TextBox tb20;
        private TextBox tb35;
        private TextBox tb34;
        private TextBox tb33;
        private TextBox tb32;
        private TextBox tb31;
        private TextBox tb30;
        private TextBox tb45;
        private TextBox tb44;
        private TextBox tb43;
        private TextBox tb42;
        private TextBox tb41;
        private TextBox tb40;
        private Label labelResult;
        private TextBox tbResult;
        private Panel pnlMatrix;
        private TextBox tb55;
        private TextBox tb54;
        private TextBox tb53;
        private TextBox tb52;
        private TextBox tb51;
        private TextBox tb50;
        private Label lblAlertKey;
        private RadioButton rb5x5;
        private RadioButton rb6x6;
        private Button btImport;
        private Button btExport;
    }
}
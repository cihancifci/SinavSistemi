namespace SinavSistemi.Presentation
{
    partial class frmOgretmen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgretmen));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.istatistlik = new DevExpress.XtraTab.XtraTabControl();
            this.soruekle = new DevExpress.XtraTab.XtraTabPage();
            this.txt_resimYolu = new MetroFramework.Controls.MetroTextBox();
            this.resim = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_soruekle = new ns1.BunifuFlatButton();
            this.cmb_konu = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rctxt_onbilgi = new System.Windows.Forms.RichTextBox();
            this.txt_D = new MetroFramework.Controls.MetroTextBox();
            this.txt_C = new MetroFramework.Controls.MetroTextBox();
            this.txt_B = new MetroFramework.Controls.MetroTextBox();
            this.txt_A = new MetroFramework.Controls.MetroTextBox();
            this.txt_icerik = new MetroFramework.Controls.MetroTextBox();
            this.cmb_dogrucevap = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.İstatistlikler = new DevExpress.XtraTab.XtraTabPage();
            this.btn_OgrenciIstatistlikGetir = new ns1.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Ogrenciler = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pctr_Ogrenci = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cikis = new ns1.BunifuImageButton();
            this.lbl_OgretmenAna = new ns1.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istatistlik)).BeginInit();
            this.istatistlik.SuspendLayout();
            this.soruekle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.İstatistlikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Ogrenci)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.istatistlik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 415);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // istatistlik
            // 
            this.istatistlik.Location = new System.Drawing.Point(0, 0);
            this.istatistlik.Name = "istatistlik";
            this.istatistlik.SelectedTabPage = this.soruekle;
            this.istatistlik.Size = new System.Drawing.Size(777, 415);
            this.istatistlik.TabIndex = 0;
            this.istatistlik.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.soruekle,
            this.İstatistlikler});
            // 
            // soruekle
            // 
            this.soruekle.Appearance.PageClient.BackColor = System.Drawing.Color.DimGray;
            this.soruekle.Appearance.PageClient.Options.UseBackColor = true;
            this.soruekle.Controls.Add(this.txt_resimYolu);
            this.soruekle.Controls.Add(this.resim);
            this.soruekle.Controls.Add(this.button1);
            this.soruekle.Controls.Add(this.label10);
            this.soruekle.Controls.Add(this.btn_soruekle);
            this.soruekle.Controls.Add(this.cmb_konu);
            this.soruekle.Controls.Add(this.label8);
            this.soruekle.Controls.Add(this.rctxt_onbilgi);
            this.soruekle.Controls.Add(this.txt_D);
            this.soruekle.Controls.Add(this.txt_C);
            this.soruekle.Controls.Add(this.txt_B);
            this.soruekle.Controls.Add(this.txt_A);
            this.soruekle.Controls.Add(this.txt_icerik);
            this.soruekle.Controls.Add(this.cmb_dogrucevap);
            this.soruekle.Controls.Add(this.label7);
            this.soruekle.Controls.Add(this.label6);
            this.soruekle.Controls.Add(this.label5);
            this.soruekle.Controls.Add(this.label4);
            this.soruekle.Controls.Add(this.label3);
            this.soruekle.Controls.Add(this.label2);
            this.soruekle.Controls.Add(this.label1);
            this.soruekle.Name = "soruekle";
            this.soruekle.Size = new System.Drawing.Size(771, 387);
            this.soruekle.Text = "Soru Ekle";
            // 
            // txt_resimYolu
            // 
            // 
            // 
            // 
            this.txt_resimYolu.CustomButton.Image = null;
            this.txt_resimYolu.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_resimYolu.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_resimYolu.CustomButton.Name = "";
            this.txt_resimYolu.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_resimYolu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_resimYolu.CustomButton.TabIndex = 1;
            this.txt_resimYolu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_resimYolu.CustomButton.UseSelectable = true;
            this.txt_resimYolu.CustomButton.Visible = false;
            this.txt_resimYolu.Lines = new string[0];
            this.txt_resimYolu.Location = new System.Drawing.Point(111, 204);
            this.txt_resimYolu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_resimYolu.MaxLength = 32767;
            this.txt_resimYolu.Name = "txt_resimYolu";
            this.txt_resimYolu.PasswordChar = '\0';
            this.txt_resimYolu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_resimYolu.SelectedText = "";
            this.txt_resimYolu.SelectionLength = 0;
            this.txt_resimYolu.SelectionStart = 0;
            this.txt_resimYolu.ShortcutsEnabled = true;
            this.txt_resimYolu.Size = new System.Drawing.Size(100, 19);
            this.txt_resimYolu.TabIndex = 41;
            this.txt_resimYolu.UseSelectable = true;
            this.txt_resimYolu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_resimYolu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // resim
            // 
            this.resim.Location = new System.Drawing.Point(55, 227);
            this.resim.Margin = new System.Windows.Forms.Padding(2);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(133, 104);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim.TabIndex = 40;
            this.resim.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "---";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(39, 207);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Soru Resmi :";
            // 
            // btn_soruekle
            // 
            this.btn_soruekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_soruekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_soruekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_soruekle.BorderRadius = 0;
            this.btn_soruekle.ButtonText = "Soru Ekle";
            this.btn_soruekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_soruekle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_soruekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_soruekle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_soruekle.Iconimage")));
            this.btn_soruekle.Iconimage_right = null;
            this.btn_soruekle.Iconimage_right_Selected = null;
            this.btn_soruekle.Iconimage_Selected = null;
            this.btn_soruekle.IconMarginLeft = 0;
            this.btn_soruekle.IconMarginRight = 0;
            this.btn_soruekle.IconRightVisible = false;
            this.btn_soruekle.IconRightZoom = 0D;
            this.btn_soruekle.IconVisible = false;
            this.btn_soruekle.IconZoom = 90D;
            this.btn_soruekle.IsTab = false;
            this.btn_soruekle.Location = new System.Drawing.Point(293, 267);
            this.btn_soruekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_soruekle.Name = "btn_soruekle";
            this.btn_soruekle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_soruekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_soruekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_soruekle.selected = false;
            this.btn_soruekle.Size = new System.Drawing.Size(142, 48);
            this.btn_soruekle.TabIndex = 37;
            this.btn_soruekle.Text = "Soru Ekle";
            this.btn_soruekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_soruekle.Textcolor = System.Drawing.Color.White;
            this.btn_soruekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soruekle.Click += new System.EventHandler(this.btn_soruekle_Click);
            // 
            // cmb_konu
            // 
            this.cmb_konu.FormattingEnabled = true;
            this.cmb_konu.ItemHeight = 23;
            this.cmb_konu.Location = new System.Drawing.Point(110, 26);
            this.cmb_konu.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_konu.Name = "cmb_konu";
            this.cmb_konu.Size = new System.Drawing.Size(158, 29);
            this.cmb_konu.TabIndex = 35;
            this.cmb_konu.UseSelectable = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sorunun Konusu :";
            // 
            // rctxt_onbilgi
            // 
            this.rctxt_onbilgi.Location = new System.Drawing.Point(92, 87);
            this.rctxt_onbilgi.Margin = new System.Windows.Forms.Padding(2);
            this.rctxt_onbilgi.Name = "rctxt_onbilgi";
            this.rctxt_onbilgi.Size = new System.Drawing.Size(251, 70);
            this.rctxt_onbilgi.TabIndex = 33;
            this.rctxt_onbilgi.Text = "";
            // 
            // txt_D
            // 
            // 
            // 
            // 
            this.txt_D.CustomButton.Image = null;
            this.txt_D.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_D.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_D.CustomButton.Name = "";
            this.txt_D.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_D.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_D.CustomButton.TabIndex = 1;
            this.txt_D.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_D.CustomButton.UseSelectable = true;
            this.txt_D.CustomButton.Visible = false;
            this.txt_D.Lines = new string[0];
            this.txt_D.Location = new System.Drawing.Point(514, 144);
            this.txt_D.Margin = new System.Windows.Forms.Padding(2);
            this.txt_D.MaxLength = 32767;
            this.txt_D.Name = "txt_D";
            this.txt_D.PasswordChar = '\0';
            this.txt_D.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_D.SelectedText = "";
            this.txt_D.SelectionLength = 0;
            this.txt_D.SelectionStart = 0;
            this.txt_D.ShortcutsEnabled = true;
            this.txt_D.Size = new System.Drawing.Size(100, 19);
            this.txt_D.TabIndex = 32;
            this.txt_D.UseSelectable = true;
            this.txt_D.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_D.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_C
            // 
            // 
            // 
            // 
            this.txt_C.CustomButton.Image = null;
            this.txt_C.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_C.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_C.CustomButton.Name = "";
            this.txt_C.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_C.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_C.CustomButton.TabIndex = 1;
            this.txt_C.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_C.CustomButton.UseSelectable = true;
            this.txt_C.CustomButton.Visible = false;
            this.txt_C.Lines = new string[0];
            this.txt_C.Location = new System.Drawing.Point(514, 113);
            this.txt_C.Margin = new System.Windows.Forms.Padding(2);
            this.txt_C.MaxLength = 32767;
            this.txt_C.Name = "txt_C";
            this.txt_C.PasswordChar = '\0';
            this.txt_C.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_C.SelectedText = "";
            this.txt_C.SelectionLength = 0;
            this.txt_C.SelectionStart = 0;
            this.txt_C.ShortcutsEnabled = true;
            this.txt_C.Size = new System.Drawing.Size(100, 19);
            this.txt_C.TabIndex = 31;
            this.txt_C.UseSelectable = true;
            this.txt_C.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_C.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_B
            // 
            // 
            // 
            // 
            this.txt_B.CustomButton.Image = null;
            this.txt_B.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_B.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_B.CustomButton.Name = "";
            this.txt_B.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_B.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_B.CustomButton.TabIndex = 1;
            this.txt_B.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_B.CustomButton.UseSelectable = true;
            this.txt_B.CustomButton.Visible = false;
            this.txt_B.Lines = new string[0];
            this.txt_B.Location = new System.Drawing.Point(514, 83);
            this.txt_B.Margin = new System.Windows.Forms.Padding(2);
            this.txt_B.MaxLength = 32767;
            this.txt_B.Name = "txt_B";
            this.txt_B.PasswordChar = '\0';
            this.txt_B.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_B.SelectedText = "";
            this.txt_B.SelectionLength = 0;
            this.txt_B.SelectionStart = 0;
            this.txt_B.ShortcutsEnabled = true;
            this.txt_B.Size = new System.Drawing.Size(100, 19);
            this.txt_B.TabIndex = 30;
            this.txt_B.UseSelectable = true;
            this.txt_B.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_B.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_A
            // 
            // 
            // 
            // 
            this.txt_A.CustomButton.Image = null;
            this.txt_A.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_A.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_A.CustomButton.Name = "";
            this.txt_A.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_A.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_A.CustomButton.TabIndex = 1;
            this.txt_A.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_A.CustomButton.UseSelectable = true;
            this.txt_A.CustomButton.Visible = false;
            this.txt_A.Lines = new string[0];
            this.txt_A.Location = new System.Drawing.Point(514, 55);
            this.txt_A.Margin = new System.Windows.Forms.Padding(2);
            this.txt_A.MaxLength = 32767;
            this.txt_A.Name = "txt_A";
            this.txt_A.PasswordChar = '\0';
            this.txt_A.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_A.SelectedText = "";
            this.txt_A.SelectionLength = 0;
            this.txt_A.SelectionStart = 0;
            this.txt_A.ShortcutsEnabled = true;
            this.txt_A.Size = new System.Drawing.Size(100, 19);
            this.txt_A.TabIndex = 29;
            this.txt_A.UseSelectable = true;
            this.txt_A.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_A.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_icerik
            // 
            // 
            // 
            // 
            this.txt_icerik.CustomButton.Image = null;
            this.txt_icerik.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_icerik.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_icerik.CustomButton.Name = "";
            this.txt_icerik.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_icerik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_icerik.CustomButton.TabIndex = 1;
            this.txt_icerik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_icerik.CustomButton.UseSelectable = true;
            this.txt_icerik.CustomButton.Visible = false;
            this.txt_icerik.Lines = new string[0];
            this.txt_icerik.Location = new System.Drawing.Point(514, 26);
            this.txt_icerik.Margin = new System.Windows.Forms.Padding(2);
            this.txt_icerik.MaxLength = 32767;
            this.txt_icerik.Name = "txt_icerik";
            this.txt_icerik.PasswordChar = '\0';
            this.txt_icerik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_icerik.SelectedText = "";
            this.txt_icerik.SelectionLength = 0;
            this.txt_icerik.SelectionStart = 0;
            this.txt_icerik.ShortcutsEnabled = true;
            this.txt_icerik.Size = new System.Drawing.Size(100, 19);
            this.txt_icerik.TabIndex = 28;
            this.txt_icerik.UseSelectable = true;
            this.txt_icerik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_icerik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmb_dogrucevap
            // 
            this.cmb_dogrucevap.FormattingEnabled = true;
            this.cmb_dogrucevap.ItemHeight = 23;
            this.cmb_dogrucevap.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmb_dogrucevap.Location = new System.Drawing.Point(518, 191);
            this.cmb_dogrucevap.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_dogrucevap.Name = "cmb_dogrucevap";
            this.cmb_dogrucevap.Size = new System.Drawing.Size(59, 29);
            this.cmb_dogrucevap.TabIndex = 27;
            this.cmb_dogrucevap.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Doğru Cevap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Soru İçeriği :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "B Şıkkı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "C Şıkkı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "D Şıkkı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "A Şıkkı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Soru Ön Bilgisi";
            // 
            // İstatistlikler
            // 
            this.İstatistlikler.Appearance.PageClient.BackColor = System.Drawing.Color.DimGray;
            this.İstatistlikler.Appearance.PageClient.Options.UseBackColor = true;
            this.İstatistlikler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.İstatistlikler.Controls.Add(this.btn_OgrenciIstatistlikGetir);
            this.İstatistlikler.Controls.Add(this.label9);
            this.İstatistlikler.Controls.Add(this.cmb_Ogrenciler);
            this.İstatistlikler.Controls.Add(this.chart1);
            this.İstatistlikler.Name = "İstatistlikler";
            this.İstatistlikler.Size = new System.Drawing.Size(771, 387);
            this.İstatistlikler.Text = "İstatistlikler";
            // 
            // btn_OgrenciIstatistlikGetir
            // 
            this.btn_OgrenciIstatistlikGetir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_OgrenciIstatistlikGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_OgrenciIstatistlikGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OgrenciIstatistlikGetir.BorderRadius = 0;
            this.btn_OgrenciIstatistlikGetir.ButtonText = "   Öğrenci İstatistlik Getir";
            this.btn_OgrenciIstatistlikGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OgrenciIstatistlikGetir.DisabledColor = System.Drawing.Color.Gray;
            this.btn_OgrenciIstatistlikGetir.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_OgrenciIstatistlikGetir.Iconimage = null;
            this.btn_OgrenciIstatistlikGetir.Iconimage_right = null;
            this.btn_OgrenciIstatistlikGetir.Iconimage_right_Selected = null;
            this.btn_OgrenciIstatistlikGetir.Iconimage_Selected = null;
            this.btn_OgrenciIstatistlikGetir.IconMarginLeft = 0;
            this.btn_OgrenciIstatistlikGetir.IconMarginRight = 0;
            this.btn_OgrenciIstatistlikGetir.IconRightVisible = false;
            this.btn_OgrenciIstatistlikGetir.IconRightZoom = 0D;
            this.btn_OgrenciIstatistlikGetir.IconVisible = false;
            this.btn_OgrenciIstatistlikGetir.IconZoom = 90D;
            this.btn_OgrenciIstatistlikGetir.IsTab = false;
            this.btn_OgrenciIstatistlikGetir.Location = new System.Drawing.Point(60, 119);
            this.btn_OgrenciIstatistlikGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OgrenciIstatistlikGetir.Name = "btn_OgrenciIstatistlikGetir";
            this.btn_OgrenciIstatistlikGetir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_OgrenciIstatistlikGetir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_OgrenciIstatistlikGetir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_OgrenciIstatistlikGetir.selected = false;
            this.btn_OgrenciIstatistlikGetir.Size = new System.Drawing.Size(156, 42);
            this.btn_OgrenciIstatistlikGetir.TabIndex = 10;
            this.btn_OgrenciIstatistlikGetir.Text = "   Öğrenci İstatistlik Getir";
            this.btn_OgrenciIstatistlikGetir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OgrenciIstatistlikGetir.Textcolor = System.Drawing.Color.White;
            this.btn_OgrenciIstatistlikGetir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OgrenciIstatistlikGetir.Click += new System.EventHandler(this.btn_OgrenciIstatistlikGetir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Öğrenci Seçiniz :";
            // 
            // cmb_Ogrenciler
            // 
            this.cmb_Ogrenciler.FormattingEnabled = true;
            this.cmb_Ogrenciler.Location = new System.Drawing.Point(59, 63);
            this.cmb_Ogrenciler.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Ogrenciler.Name = "cmb_Ogrenciler";
            this.cmb_Ogrenciler.Size = new System.Drawing.Size(114, 21);
            this.cmb_Ogrenciler.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(293, 63);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "sinav_Istatistik";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(356, 197);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // pctr_Ogrenci
            // 
            this.pctr_Ogrenci.BackColor = System.Drawing.Color.Transparent;
            this.pctr_Ogrenci.Image = ((System.Drawing.Image)(resources.GetObject("pctr_Ogrenci.Image")));
            this.pctr_Ogrenci.Location = new System.Drawing.Point(3, 0);
            this.pctr_Ogrenci.Name = "pctr_Ogrenci";
            this.pctr_Ogrenci.Size = new System.Drawing.Size(86, 56);
            this.pctr_Ogrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctr_Ogrenci.TabIndex = 0;
            this.pctr_Ogrenci.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_Cikis);
            this.panel2.Controls.Add(this.lbl_OgretmenAna);
            this.panel2.Controls.Add(this.pctr_Ogrenci);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 56);
            this.panel2.TabIndex = 3;
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cikis.Image")));
            this.btn_Cikis.ImageActive = null;
            this.btn_Cikis.Location = new System.Drawing.Point(721, 8);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(56, 42);
            this.btn_Cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cikis.TabIndex = 3;
            this.btn_Cikis.TabStop = false;
            this.btn_Cikis.Zoom = 10;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // lbl_OgretmenAna
            // 
            this.lbl_OgretmenAna.AutoSize = true;
            this.lbl_OgretmenAna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OgretmenAna.Location = new System.Drawing.Point(290, 12);
            this.lbl_OgretmenAna.Name = "lbl_OgretmenAna";
            this.lbl_OgretmenAna.Size = new System.Drawing.Size(177, 21);
            this.lbl_OgretmenAna.TabIndex = 2;
            this.lbl_OgretmenAna.Text = "Öğretmen Ana Sayfa";
            // 
            // frmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgretmen";
            this.Load += new System.EventHandler(this.frmOgretmen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.istatistlik)).EndInit();
            this.istatistlik.ResumeLayout(false);
            this.soruekle.ResumeLayout(false);
            this.soruekle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.İstatistlikler.ResumeLayout(false);
            this.İstatistlikler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Ogrenci)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cikis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctr_Ogrenci;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuImageButton btn_Cikis;
        private ns1.BunifuCustomLabel lbl_OgretmenAna;
        private DevExpress.XtraTab.XtraTabControl istatistlik;
        private DevExpress.XtraTab.XtraTabPage soruekle;
        private MetroFramework.Controls.MetroComboBox cmb_konu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rctxt_onbilgi;
        private MetroFramework.Controls.MetroTextBox txt_D;
        private MetroFramework.Controls.MetroTextBox txt_C;
        private MetroFramework.Controls.MetroTextBox txt_B;
        private MetroFramework.Controls.MetroTextBox txt_A;
        private MetroFramework.Controls.MetroTextBox txt_icerik;
        private MetroFramework.Controls.MetroComboBox cmb_dogrucevap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton btn_soruekle;
        private MetroFramework.Controls.MetroTextBox txt_resimYolu;
        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraTab.XtraTabPage İstatistlikler;
        private ns1.BunifuFlatButton btn_OgrenciIstatistlikGetir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Ogrenciler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
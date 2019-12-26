namespace SinavSistemi.Presentation
{
    partial class frmSinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinav));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.rdo_A = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdo_B = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdo_D = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdo_C = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Cevapla = new ns1.BunifuFlatButton();
            this.btn_SinavBitir = new ns1.BunifuFlatButton();
            this.btn_Sonraki = new ns1.BunifuFlatButton();
            this.btn_Onceki = new ns1.BunifuFlatButton();
            this.lbl_A = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_C = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_D = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_B = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_numara = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_onbilgi = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_icerik = new MaterialSkin.Controls.MaterialLabel();
            this.Sure = new System.Windows.Forms.Timer(this.components);
            this.lbl_sure = new System.Windows.Forms.Label();
            this.tbn_Cikis = new ns1.BunifuImageButton();
            this.pctr_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbn_Cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // rdo_A
            // 
            this.rdo_A.AutoSize = true;
            this.rdo_A.Depth = 0;
            this.rdo_A.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdo_A.Location = new System.Drawing.Point(180, 216);
            this.rdo_A.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_A.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_A.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_A.Name = "rdo_A";
            this.rdo_A.Ripple = true;
            this.rdo_A.Size = new System.Drawing.Size(46, 30);
            this.rdo_A.TabIndex = 48;
            this.rdo_A.TabStop = true;
            this.rdo_A.Text = "A:";
            this.rdo_A.UseVisualStyleBackColor = true;
            // 
            // rdo_B
            // 
            this.rdo_B.AutoSize = true;
            this.rdo_B.Depth = 0;
            this.rdo_B.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdo_B.Location = new System.Drawing.Point(430, 216);
            this.rdo_B.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_B.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_B.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_B.Name = "rdo_B";
            this.rdo_B.Ripple = true;
            this.rdo_B.Size = new System.Drawing.Size(45, 30);
            this.rdo_B.TabIndex = 49;
            this.rdo_B.TabStop = true;
            this.rdo_B.Text = "B:";
            this.rdo_B.UseVisualStyleBackColor = true;
            // 
            // rdo_D
            // 
            this.rdo_D.AutoSize = true;
            this.rdo_D.Depth = 0;
            this.rdo_D.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdo_D.Location = new System.Drawing.Point(428, 301);
            this.rdo_D.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_D.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_D.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_D.Name = "rdo_D";
            this.rdo_D.Ripple = true;
            this.rdo_D.Size = new System.Drawing.Size(46, 30);
            this.rdo_D.TabIndex = 50;
            this.rdo_D.TabStop = true;
            this.rdo_D.Text = "D:";
            this.rdo_D.UseVisualStyleBackColor = true;
            // 
            // rdo_C
            // 
            this.rdo_C.AutoSize = true;
            this.rdo_C.Depth = 0;
            this.rdo_C.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdo_C.Location = new System.Drawing.Point(182, 301);
            this.rdo_C.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_C.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_C.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_C.Name = "rdo_C";
            this.rdo_C.Ripple = true;
            this.rdo_C.Size = new System.Drawing.Size(46, 30);
            this.rdo_C.TabIndex = 51;
            this.rdo_C.TabStop = true;
            this.rdo_C.Text = "C:";
            this.rdo_C.UseVisualStyleBackColor = true;
            // 
            // btn_Cevapla
            // 
            this.btn_Cevapla.Activecolor = System.Drawing.Color.White;
            this.btn_Cevapla.BackColor = System.Drawing.Color.DimGray;
            this.btn_Cevapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cevapla.BorderRadius = 0;
            this.btn_Cevapla.ButtonText = "Cevapla";
            this.btn_Cevapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cevapla.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cevapla.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cevapla.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Cevapla.Iconimage")));
            this.btn_Cevapla.Iconimage_right = null;
            this.btn_Cevapla.Iconimage_right_Selected = null;
            this.btn_Cevapla.Iconimage_Selected = null;
            this.btn_Cevapla.IconMarginLeft = 0;
            this.btn_Cevapla.IconMarginRight = 0;
            this.btn_Cevapla.IconRightVisible = true;
            this.btn_Cevapla.IconRightZoom = 0D;
            this.btn_Cevapla.IconVisible = true;
            this.btn_Cevapla.IconZoom = 90D;
            this.btn_Cevapla.IsTab = false;
            this.btn_Cevapla.Location = new System.Drawing.Point(299, 369);
            this.btn_Cevapla.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Cevapla.Name = "btn_Cevapla";
            this.btn_Cevapla.Normalcolor = System.Drawing.Color.DimGray;
            this.btn_Cevapla.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Cevapla.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cevapla.selected = false;
            this.btn_Cevapla.Size = new System.Drawing.Size(236, 59);
            this.btn_Cevapla.TabIndex = 53;
            this.btn_Cevapla.Text = "Cevapla";
            this.btn_Cevapla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cevapla.Textcolor = System.Drawing.Color.White;
            this.btn_Cevapla.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cevapla.Click += new System.EventHandler(this.btn_Cevapla_Click);
            // 
            // btn_SinavBitir
            // 
            this.btn_SinavBitir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SinavBitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SinavBitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SinavBitir.BorderRadius = 0;
            this.btn_SinavBitir.ButtonText = "Sınavı Bitir !";
            this.btn_SinavBitir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SinavBitir.DisabledColor = System.Drawing.Color.Gray;
            this.btn_SinavBitir.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_SinavBitir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_SinavBitir.Iconimage")));
            this.btn_SinavBitir.Iconimage_right = null;
            this.btn_SinavBitir.Iconimage_right_Selected = null;
            this.btn_SinavBitir.Iconimage_Selected = null;
            this.btn_SinavBitir.IconMarginLeft = 0;
            this.btn_SinavBitir.IconMarginRight = 0;
            this.btn_SinavBitir.IconRightVisible = true;
            this.btn_SinavBitir.IconRightZoom = 0D;
            this.btn_SinavBitir.IconVisible = true;
            this.btn_SinavBitir.IconZoom = 90D;
            this.btn_SinavBitir.IsTab = false;
            this.btn_SinavBitir.Location = new System.Drawing.Point(716, 434);
            this.btn_SinavBitir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_SinavBitir.Name = "btn_SinavBitir";
            this.btn_SinavBitir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SinavBitir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_SinavBitir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SinavBitir.selected = false;
            this.btn_SinavBitir.Size = new System.Drawing.Size(236, 59);
            this.btn_SinavBitir.TabIndex = 54;
            this.btn_SinavBitir.Text = "Sınavı Bitir !";
            this.btn_SinavBitir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinavBitir.Textcolor = System.Drawing.Color.White;
            this.btn_SinavBitir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinavBitir.Click += new System.EventHandler(this.btn_SinavBitir_Click);
            // 
            // btn_Sonraki
            // 
            this.btn_Sonraki.Activecolor = System.Drawing.Color.White;
            this.btn_Sonraki.BackColor = System.Drawing.Color.DimGray;
            this.btn_Sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sonraki.BorderRadius = 0;
            this.btn_Sonraki.ButtonText = "";
            this.btn_Sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sonraki.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sonraki.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sonraki.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Sonraki.Iconimage")));
            this.btn_Sonraki.Iconimage_right = null;
            this.btn_Sonraki.Iconimage_right_Selected = null;
            this.btn_Sonraki.Iconimage_Selected = null;
            this.btn_Sonraki.IconMarginLeft = 0;
            this.btn_Sonraki.IconMarginRight = 0;
            this.btn_Sonraki.IconRightVisible = true;
            this.btn_Sonraki.IconRightZoom = 0D;
            this.btn_Sonraki.IconVisible = true;
            this.btn_Sonraki.IconZoom = 90D;
            this.btn_Sonraki.IsTab = false;
            this.btn_Sonraki.Location = new System.Drawing.Point(901, 212);
            this.btn_Sonraki.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Sonraki.Name = "btn_Sonraki";
            this.btn_Sonraki.Normalcolor = System.Drawing.Color.DimGray;
            this.btn_Sonraki.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Sonraki.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sonraki.selected = false;
            this.btn_Sonraki.Size = new System.Drawing.Size(64, 59);
            this.btn_Sonraki.TabIndex = 55;
            this.btn_Sonraki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sonraki.Textcolor = System.Drawing.Color.White;
            this.btn_Sonraki.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sonraki.Click += new System.EventHandler(this.btn_Sonraki_Click);
            // 
            // btn_Onceki
            // 
            this.btn_Onceki.Activecolor = System.Drawing.Color.White;
            this.btn_Onceki.BackColor = System.Drawing.Color.DimGray;
            this.btn_Onceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Onceki.BorderRadius = 0;
            this.btn_Onceki.ButtonText = "";
            this.btn_Onceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Onceki.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Onceki.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Onceki.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Onceki.Iconimage")));
            this.btn_Onceki.Iconimage_right = null;
            this.btn_Onceki.Iconimage_right_Selected = null;
            this.btn_Onceki.Iconimage_Selected = null;
            this.btn_Onceki.IconMarginLeft = 0;
            this.btn_Onceki.IconMarginRight = 0;
            this.btn_Onceki.IconRightVisible = true;
            this.btn_Onceki.IconRightZoom = 0D;
            this.btn_Onceki.IconVisible = true;
            this.btn_Onceki.IconZoom = 90D;
            this.btn_Onceki.IsTab = false;
            this.btn_Onceki.Location = new System.Drawing.Point(1, 212);
            this.btn_Onceki.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Onceki.Name = "btn_Onceki";
            this.btn_Onceki.Normalcolor = System.Drawing.Color.DimGray;
            this.btn_Onceki.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Onceki.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Onceki.selected = false;
            this.btn_Onceki.Size = new System.Drawing.Size(64, 59);
            this.btn_Onceki.TabIndex = 56;
            this.btn_Onceki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Onceki.Textcolor = System.Drawing.Color.White;
            this.btn_Onceki.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Onceki.Click += new System.EventHandler(this.btn_Onceki_Click);
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Depth = 0;
            this.lbl_A.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_A.Location = new System.Drawing.Point(239, 222);
            this.lbl_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_A.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(22, 24);
            this.lbl_A.TabIndex = 57;
            this.lbl_A.Text = "A";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Depth = 0;
            this.lbl_C.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_C.Location = new System.Drawing.Point(242, 307);
            this.lbl_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_C.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(22, 24);
            this.lbl_C.TabIndex = 58;
            this.lbl_C.Text = "C";
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.Depth = 0;
            this.lbl_D.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_D.Location = new System.Drawing.Point(488, 307);
            this.lbl_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_D.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(22, 24);
            this.lbl_D.TabIndex = 59;
            this.lbl_D.Text = "D";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Depth = 0;
            this.lbl_B.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_B.Location = new System.Drawing.Point(490, 222);
            this.lbl_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_B.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(22, 24);
            this.lbl_B.TabIndex = 60;
            this.lbl_B.Text = "B";
            // 
            // lbl_numara
            // 
            this.lbl_numara.AutoSize = true;
            this.lbl_numara.Depth = 0;
            this.lbl_numara.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_numara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_numara.Location = new System.Drawing.Point(99, 78);
            this.lbl_numara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numara.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_numara.Name = "lbl_numara";
            this.lbl_numara.Size = new System.Drawing.Size(135, 24);
            this.lbl_numara.TabIndex = 61;
            this.lbl_numara.Text = "Soru Numarası";
            // 
            // lbl_onbilgi
            // 
            this.lbl_onbilgi.AutoSize = true;
            this.lbl_onbilgi.Depth = 0;
            this.lbl_onbilgi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_onbilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_onbilgi.Location = new System.Drawing.Point(380, 78);
            this.lbl_onbilgi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_onbilgi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_onbilgi.Name = "lbl_onbilgi";
            this.lbl_onbilgi.Size = new System.Drawing.Size(76, 24);
            this.lbl_onbilgi.TabIndex = 62;
            this.lbl_onbilgi.Text = "Ön Bilgi";
            // 
            // lbl_icerik
            // 
            this.lbl_icerik.AutoSize = true;
            this.lbl_icerik.Depth = 0;
            this.lbl_icerik.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_icerik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_icerik.Location = new System.Drawing.Point(275, 150);
            this.lbl_icerik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_icerik.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_icerik.Name = "lbl_icerik";
            this.lbl_icerik.Size = new System.Drawing.Size(105, 24);
            this.lbl_icerik.TabIndex = 63;
            this.lbl_icerik.Text = "Soru İçeriği";
            // 
            // Sure
            // 
            this.Sure.Tick += new System.EventHandler(this.Sure_Tick);
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.Location = new System.Drawing.Point(685, 60);
            this.lbl_sure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(46, 17);
            this.lbl_sure.TabIndex = 64;
            this.lbl_sure.Text = "label1";
            // 
            // tbn_Cikis
            // 
            this.tbn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.tbn_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("tbn_Cikis.Image")));
            this.tbn_Cikis.ImageActive = null;
            this.tbn_Cikis.Location = new System.Drawing.Point(891, 0);
            this.tbn_Cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbn_Cikis.Name = "tbn_Cikis";
            this.tbn_Cikis.Size = new System.Drawing.Size(75, 52);
            this.tbn_Cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tbn_Cikis.TabIndex = 65;
            this.tbn_Cikis.TabStop = false;
            this.tbn_Cikis.Zoom = 10;
            this.tbn_Cikis.Click += new System.EventHandler(this.tbn_Cikis_Click);
            // 
            // pctr_resim
            // 
            this.pctr_resim.Location = new System.Drawing.Point(592, 150);
            this.pctr_resim.Name = "pctr_resim";
            this.pctr_resim.Size = new System.Drawing.Size(196, 181);
            this.pctr_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctr_resim.TabIndex = 66;
            this.pctr_resim.TabStop = false;
            // 
            // frmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(968, 508);
            this.Controls.Add(this.pctr_resim);
            this.Controls.Add(this.tbn_Cikis);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.lbl_icerik);
            this.Controls.Add(this.lbl_onbilgi);
            this.Controls.Add(this.lbl_numara);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_D);
            this.Controls.Add(this.lbl_C);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.btn_Onceki);
            this.Controls.Add(this.btn_Sonraki);
            this.Controls.Add(this.btn_SinavBitir);
            this.Controls.Add(this.btn_Cevapla);
            this.Controls.Add(this.rdo_C);
            this.Controls.Add(this.rdo_D);
            this.Controls.Add(this.rdo_B);
            this.Controls.Add(this.rdo_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSinav";
            this.Load += new System.EventHandler(this.frmSinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbn_Cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private MaterialSkin.Controls.MaterialLabel lbl_icerik;
        private MaterialSkin.Controls.MaterialLabel lbl_onbilgi;
        private MaterialSkin.Controls.MaterialLabel lbl_numara;
        private MaterialSkin.Controls.MaterialLabel lbl_B;
        private MaterialSkin.Controls.MaterialLabel lbl_D;
        private MaterialSkin.Controls.MaterialLabel lbl_C;
        private MaterialSkin.Controls.MaterialLabel lbl_A;
        private ns1.BunifuFlatButton btn_Onceki;
        private ns1.BunifuFlatButton btn_Sonraki;
        private ns1.BunifuFlatButton btn_SinavBitir;
        private ns1.BunifuFlatButton btn_Cevapla;
        private MaterialSkin.Controls.MaterialRadioButton rdo_C;
        private MaterialSkin.Controls.MaterialRadioButton rdo_D;
        private MaterialSkin.Controls.MaterialRadioButton rdo_B;
        private MaterialSkin.Controls.MaterialRadioButton rdo_A;
        private System.Windows.Forms.Timer Sure;
        private System.Windows.Forms.Label lbl_sure;
        private ns1.BunifuImageButton tbn_Cikis;
        private System.Windows.Forms.PictureBox pctr_resim;
    }
}
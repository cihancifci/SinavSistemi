namespace SinavSistemi.Presentation
{
    partial class frmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenci));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Istatistlik = new ns1.BunifuFlatButton();
            this.btn_SinavYap = new ns1.BunifuFlatButton();
            this.pctr_Ogrenci = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbn_Cikis = new ns1.BunifuImageButton();
            this.lbl_OgrenciAna = new ns1.BunifuCustomLabel();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Ogrenci)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbn_Cikis)).BeginInit();
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
            this.panel1.Controls.Add(this.btn_Istatistlik);
            this.panel1.Controls.Add(this.btn_SinavYap);
            this.panel1.Controls.Add(this.pctr_Ogrenci);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 410);
            this.panel1.TabIndex = 0;
            // 
            // btn_Istatistlik
            // 
            this.btn_Istatistlik.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Istatistlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Istatistlik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Istatistlik.BorderRadius = 0;
            this.btn_Istatistlik.ButtonText = "İstatislik Görüntüle";
            this.btn_Istatistlik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Istatistlik.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Istatistlik.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Istatistlik.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Istatistlik.Iconimage")));
            this.btn_Istatistlik.Iconimage_right = null;
            this.btn_Istatistlik.Iconimage_right_Selected = null;
            this.btn_Istatistlik.Iconimage_Selected = null;
            this.btn_Istatistlik.IconMarginLeft = 0;
            this.btn_Istatistlik.IconMarginRight = 0;
            this.btn_Istatistlik.IconRightVisible = true;
            this.btn_Istatistlik.IconRightZoom = 0D;
            this.btn_Istatistlik.IconVisible = true;
            this.btn_Istatistlik.IconZoom = 90D;
            this.btn_Istatistlik.IsTab = false;
            this.btn_Istatistlik.Location = new System.Drawing.Point(0, 174);
            this.btn_Istatistlik.Name = "btn_Istatistlik";
            this.btn_Istatistlik.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Istatistlik.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Istatistlik.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Istatistlik.selected = false;
            this.btn_Istatistlik.Size = new System.Drawing.Size(219, 48);
            this.btn_Istatistlik.TabIndex = 3;
            this.btn_Istatistlik.Text = "İstatislik Görüntüle";
            this.btn_Istatistlik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Istatistlik.Textcolor = System.Drawing.Color.White;
            this.btn_Istatistlik.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Istatistlik.Click += new System.EventHandler(this.btn_Istatistlik_Click);
            // 
            // btn_SinavYap
            // 
            this.btn_SinavYap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SinavYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SinavYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SinavYap.BorderRadius = 0;
            this.btn_SinavYap.ButtonText = "Sınav Yap";
            this.btn_SinavYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SinavYap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_SinavYap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_SinavYap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_SinavYap.Iconimage")));
            this.btn_SinavYap.Iconimage_right = null;
            this.btn_SinavYap.Iconimage_right_Selected = null;
            this.btn_SinavYap.Iconimage_Selected = null;
            this.btn_SinavYap.IconMarginLeft = 0;
            this.btn_SinavYap.IconMarginRight = 0;
            this.btn_SinavYap.IconRightVisible = true;
            this.btn_SinavYap.IconRightZoom = 0D;
            this.btn_SinavYap.IconVisible = true;
            this.btn_SinavYap.IconZoom = 90D;
            this.btn_SinavYap.IsTab = false;
            this.btn_SinavYap.Location = new System.Drawing.Point(0, 120);
            this.btn_SinavYap.Name = "btn_SinavYap";
            this.btn_SinavYap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SinavYap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_SinavYap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SinavYap.selected = false;
            this.btn_SinavYap.Size = new System.Drawing.Size(219, 48);
            this.btn_SinavYap.TabIndex = 2;
            this.btn_SinavYap.Text = "Sınav Yap";
            this.btn_SinavYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinavYap.Textcolor = System.Drawing.Color.White;
            this.btn_SinavYap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinavYap.Click += new System.EventHandler(this.btn_SinavYap_Click);
            // 
            // pctr_Ogrenci
            // 
            this.pctr_Ogrenci.BackColor = System.Drawing.Color.Transparent;
            this.pctr_Ogrenci.Image = ((System.Drawing.Image)(resources.GetObject("pctr_Ogrenci.Image")));
            this.pctr_Ogrenci.Location = new System.Drawing.Point(12, 3);
            this.pctr_Ogrenci.Name = "pctr_Ogrenci";
            this.pctr_Ogrenci.Size = new System.Drawing.Size(192, 101);
            this.pctr_Ogrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctr_Ogrenci.TabIndex = 0;
            this.pctr_Ogrenci.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.tbn_Cikis);
            this.panel2.Controls.Add(this.lbl_OgrenciAna);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 45);
            this.panel2.TabIndex = 1;
            // 
            // tbn_Cikis
            // 
            this.tbn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.tbn_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("tbn_Cikis.Image")));
            this.tbn_Cikis.ImageActive = null;
            this.tbn_Cikis.Location = new System.Drawing.Point(726, 0);
            this.tbn_Cikis.Name = "tbn_Cikis";
            this.tbn_Cikis.Size = new System.Drawing.Size(56, 42);
            this.tbn_Cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tbn_Cikis.TabIndex = 3;
            this.tbn_Cikis.TabStop = false;
            this.tbn_Cikis.Zoom = 10;
            this.tbn_Cikis.Click += new System.EventHandler(this.tbn_Cikis_Click);
            // 
            // lbl_OgrenciAna
            // 
            this.lbl_OgrenciAna.AutoSize = true;
            this.lbl_OgrenciAna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OgrenciAna.Location = new System.Drawing.Point(290, 12);
            this.lbl_OgrenciAna.Name = "lbl_OgrenciAna";
            this.lbl_OgrenciAna.Size = new System.Drawing.Size(158, 21);
            this.lbl_OgrenciAna.TabIndex = 2;
            this.lbl_OgrenciAna.Text = "Öğrenci Ana Sayfa";
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(530, 453);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 2;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(785, 455);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenci";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Ogrenci)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbn_Cikis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuFlatButton btn_Istatistlik;
        private ns1.BunifuFlatButton btn_SinavYap;
        private System.Windows.Forms.PictureBox pctr_Ogrenci;
        private ns1.BunifuImageButton tbn_Cikis;
        private ns1.BunifuCustomLabel lbl_OgrenciAna;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
    }
}
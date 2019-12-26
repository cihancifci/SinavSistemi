namespace SinavSistemi.Presentation
{
    partial class frmgiris
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
            this.txt_KullaniciAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Parola = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Ogrenci = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Ogretmen = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_GirisYap = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txt_KullaniciAd
            // 
            this.txt_KullaniciAd.Depth = 0;
            this.txt_KullaniciAd.Hint = "Kullanıcı Ad";
            this.txt_KullaniciAd.Location = new System.Drawing.Point(108, 135);
            this.txt_KullaniciAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_KullaniciAd.Name = "txt_KullaniciAd";
            this.txt_KullaniciAd.PasswordChar = '\0';
            this.txt_KullaniciAd.SelectedText = "";
            this.txt_KullaniciAd.SelectionLength = 0;
            this.txt_KullaniciAd.SelectionStart = 0;
            this.txt_KullaniciAd.Size = new System.Drawing.Size(192, 23);
            this.txt_KullaniciAd.TabIndex = 15;
            this.txt_KullaniciAd.UseSystemPasswordChar = false;
            // 
            // txt_Parola
            // 
            this.txt_Parola.Depth = 0;
            this.txt_Parola.Hint = "Parola";
            this.txt_Parola.Location = new System.Drawing.Point(108, 173);
            this.txt_Parola.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.PasswordChar = '*';
            this.txt_Parola.SelectedText = "";
            this.txt_Parola.SelectionLength = 0;
            this.txt_Parola.SelectionStart = 0;
            this.txt_Parola.Size = new System.Drawing.Size(192, 23);
            this.txt_Parola.TabIndex = 16;
            this.txt_Parola.UseSystemPasswordChar = false;
            // 
            // btn_Ogrenci
            // 
            this.btn_Ogrenci.AutoSize = true;
            this.btn_Ogrenci.Depth = 0;
            this.btn_Ogrenci.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Ogrenci.Location = new System.Drawing.Point(108, 92);
            this.btn_Ogrenci.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ogrenci.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Ogrenci.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ogrenci.Name = "btn_Ogrenci";
            this.btn_Ogrenci.Ripple = true;
            this.btn_Ogrenci.Size = new System.Drawing.Size(77, 30);
            this.btn_Ogrenci.TabIndex = 17;
            this.btn_Ogrenci.TabStop = true;
            this.btn_Ogrenci.Text = "Öğrenci";
            this.btn_Ogrenci.UseVisualStyleBackColor = true;
            // 
            // btn_Ogretmen
            // 
            this.btn_Ogretmen.AutoSize = true;
            this.btn_Ogretmen.Depth = 0;
            this.btn_Ogretmen.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Ogretmen.Location = new System.Drawing.Point(210, 92);
            this.btn_Ogretmen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ogretmen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Ogretmen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ogretmen.Name = "btn_Ogretmen";
            this.btn_Ogretmen.Ripple = true;
            this.btn_Ogretmen.Size = new System.Drawing.Size(90, 30);
            this.btn_Ogretmen.TabIndex = 18;
            this.btn_Ogretmen.TabStop = true;
            this.btn_Ogretmen.Text = "Öğretmen";
            this.btn_Ogretmen.UseVisualStyleBackColor = true;
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Depth = 0;
            this.btn_GirisYap.Location = new System.Drawing.Point(141, 237);
            this.btn_GirisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Primary = true;
            this.btn_GirisYap.Size = new System.Drawing.Size(123, 49);
            this.btn_GirisYap.TabIndex = 20;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 360);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.btn_Ogretmen);
            this.Controls.Add(this.btn_Ogrenci);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_KullaniciAd);
            this.Name = "frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_KullaniciAd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Parola;
        private MaterialSkin.Controls.MaterialRadioButton btn_Ogrenci;
        private MaterialSkin.Controls.MaterialRadioButton btn_Ogretmen;
        private MaterialSkin.Controls.MaterialRaisedButton btn_GirisYap;
    }
}
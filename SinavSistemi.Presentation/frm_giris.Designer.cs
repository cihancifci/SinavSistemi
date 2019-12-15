namespace SinavSistemi.Presentation
{
    partial class frm_giris
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
            this.txt_ogrenciAd = new MetroFramework.Controls.MetroTextBox();
            this.txt_ogrenciParola = new MetroFramework.Controls.MetroTextBox();
            this.btn_OgrenciGiris = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ogrenciAd
            // 
            // 
            // 
            // 
            this.txt_ogrenciAd.CustomButton.Image = null;
            this.txt_ogrenciAd.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txt_ogrenciAd.CustomButton.Name = "";
            this.txt_ogrenciAd.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txt_ogrenciAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ogrenciAd.CustomButton.TabIndex = 1;
            this.txt_ogrenciAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ogrenciAd.CustomButton.UseSelectable = true;
            this.txt_ogrenciAd.CustomButton.Visible = false;
            this.txt_ogrenciAd.Lines = new string[] {
        "metroTextBox1"};
            this.txt_ogrenciAd.Location = new System.Drawing.Point(148, 68);
            this.txt_ogrenciAd.MaxLength = 32767;
            this.txt_ogrenciAd.Name = "txt_ogrenciAd";
            this.txt_ogrenciAd.PasswordChar = '\0';
            this.txt_ogrenciAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ogrenciAd.SelectedText = "";
            this.txt_ogrenciAd.SelectionLength = 0;
            this.txt_ogrenciAd.SelectionStart = 0;
            this.txt_ogrenciAd.ShortcutsEnabled = true;
            this.txt_ogrenciAd.Size = new System.Drawing.Size(151, 39);
            this.txt_ogrenciAd.TabIndex = 0;
            this.txt_ogrenciAd.Text = "metroTextBox1";
            this.txt_ogrenciAd.UseSelectable = true;
            this.txt_ogrenciAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ogrenciAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ogrenciParola
            // 
            // 
            // 
            // 
            this.txt_ogrenciParola.CustomButton.Image = null;
            this.txt_ogrenciParola.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txt_ogrenciParola.CustomButton.Name = "";
            this.txt_ogrenciParola.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txt_ogrenciParola.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ogrenciParola.CustomButton.TabIndex = 1;
            this.txt_ogrenciParola.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ogrenciParola.CustomButton.UseSelectable = true;
            this.txt_ogrenciParola.CustomButton.Visible = false;
            this.txt_ogrenciParola.Lines = new string[] {
        "metroTextBox2"};
            this.txt_ogrenciParola.Location = new System.Drawing.Point(148, 131);
            this.txt_ogrenciParola.MaxLength = 32767;
            this.txt_ogrenciParola.Name = "txt_ogrenciParola";
            this.txt_ogrenciParola.PasswordChar = '\0';
            this.txt_ogrenciParola.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ogrenciParola.SelectedText = "";
            this.txt_ogrenciParola.SelectionLength = 0;
            this.txt_ogrenciParola.SelectionStart = 0;
            this.txt_ogrenciParola.ShortcutsEnabled = true;
            this.txt_ogrenciParola.Size = new System.Drawing.Size(151, 39);
            this.txt_ogrenciParola.TabIndex = 1;
            this.txt_ogrenciParola.Text = "metroTextBox2";
            this.txt_ogrenciParola.UseSelectable = true;
            this.txt_ogrenciParola.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ogrenciParola.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_OgrenciGiris
            // 
            this.btn_OgrenciGiris.Location = new System.Drawing.Point(137, 217);
            this.btn_OgrenciGiris.Name = "btn_OgrenciGiris";
            this.btn_OgrenciGiris.Size = new System.Drawing.Size(103, 62);
            this.btn_OgrenciGiris.TabIndex = 2;
            this.btn_OgrenciGiris.Text = "Giriş Yap";
            this.btn_OgrenciGiris.UseSelectable = true;
            this.btn_OgrenciGiris.Click += new System.EventHandler(this.btn_OgrenciGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OgrenciGiris);
            this.Controls.Add(this.txt_ogrenciParola);
            this.Controls.Add(this.txt_ogrenciAd);
            this.Name = "frm_giris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_ogrenciAd;
        private MetroFramework.Controls.MetroTextBox txt_ogrenciParola;
        private MetroFramework.Controls.MetroButton btn_OgrenciGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


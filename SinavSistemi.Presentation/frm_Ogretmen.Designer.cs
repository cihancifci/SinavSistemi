namespace SinavSistemi.Presentation
{
    partial class frm_Ogretmen
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
            this.brn_soru = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_dogrucevap = new MetroFramework.Controls.MetroComboBox();
            this.txt_icerik = new MetroFramework.Controls.MetroTextBox();
            this.txt_A = new MetroFramework.Controls.MetroTextBox();
            this.txt_B = new MetroFramework.Controls.MetroTextBox();
            this.txt_C = new MetroFramework.Controls.MetroTextBox();
            this.txt_D = new MetroFramework.Controls.MetroTextBox();
            this.rctxt_onbilgi = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_konu = new MetroFramework.Controls.MetroComboBox();
            this.btn_konu = new MetroFramework.Controls.MetroButton();
            this.btn_soruekle = new MetroFramework.Controls.MetroButton();
            this.btn_konuekle = new MetroFramework.Controls.MetroButton();
            this.txt_konuisim = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brn_soru
            // 
            this.brn_soru.Location = new System.Drawing.Point(90, 29);
            this.brn_soru.Name = "brn_soru";
            this.brn_soru.Size = new System.Drawing.Size(145, 55);
            this.brn_soru.TabIndex = 0;
            this.brn_soru.Text = "Soru Ekle";
            this.brn_soru.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru Ön Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "A Şıkkı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "D Şıkkı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "C Şıkkı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "B Şıkkı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Soru İçeriği :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Doğru Cevap";
            // 
            // cmb_dogrucevap
            // 
            this.cmb_dogrucevap.FormattingEnabled = true;
            this.cmb_dogrucevap.ItemHeight = 24;
            this.cmb_dogrucevap.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmb_dogrucevap.Location = new System.Drawing.Point(200, 450);
            this.cmb_dogrucevap.Name = "cmb_dogrucevap";
            this.cmb_dogrucevap.Size = new System.Drawing.Size(77, 30);
            this.cmb_dogrucevap.TabIndex = 9;
            this.cmb_dogrucevap.UseSelectable = true;
            // 
            // txt_icerik
            // 
            // 
            // 
            // 
            this.txt_icerik.CustomButton.Image = null;
            this.txt_icerik.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txt_icerik.CustomButton.Name = "";
            this.txt_icerik.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_icerik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_icerik.CustomButton.TabIndex = 1;
            this.txt_icerik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_icerik.CustomButton.UseSelectable = true;
            this.txt_icerik.CustomButton.Visible = false;
            this.txt_icerik.Lines = new string[0];
            this.txt_icerik.Location = new System.Drawing.Point(169, 264);
            this.txt_icerik.MaxLength = 32767;
            this.txt_icerik.Name = "txt_icerik";
            this.txt_icerik.PasswordChar = '\0';
            this.txt_icerik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_icerik.SelectedText = "";
            this.txt_icerik.SelectionLength = 0;
            this.txt_icerik.SelectionStart = 0;
            this.txt_icerik.ShortcutsEnabled = true;
            this.txt_icerik.Size = new System.Drawing.Size(134, 23);
            this.txt_icerik.TabIndex = 10;
            this.txt_icerik.UseSelectable = true;
            this.txt_icerik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_icerik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_A
            // 
            // 
            // 
            // 
            this.txt_A.CustomButton.Image = null;
            this.txt_A.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txt_A.CustomButton.Name = "";
            this.txt_A.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_A.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_A.CustomButton.TabIndex = 1;
            this.txt_A.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_A.CustomButton.UseSelectable = true;
            this.txt_A.CustomButton.Visible = false;
            this.txt_A.Lines = new string[0];
            this.txt_A.Location = new System.Drawing.Point(169, 299);
            this.txt_A.MaxLength = 32767;
            this.txt_A.Name = "txt_A";
            this.txt_A.PasswordChar = '\0';
            this.txt_A.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_A.SelectedText = "";
            this.txt_A.SelectionLength = 0;
            this.txt_A.SelectionStart = 0;
            this.txt_A.ShortcutsEnabled = true;
            this.txt_A.Size = new System.Drawing.Size(134, 23);
            this.txt_A.TabIndex = 11;
            this.txt_A.UseSelectable = true;
            this.txt_A.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_A.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_B
            // 
            // 
            // 
            // 
            this.txt_B.CustomButton.Image = null;
            this.txt_B.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txt_B.CustomButton.Name = "";
            this.txt_B.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_B.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_B.CustomButton.TabIndex = 1;
            this.txt_B.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_B.CustomButton.UseSelectable = true;
            this.txt_B.CustomButton.Visible = false;
            this.txt_B.Lines = new string[0];
            this.txt_B.Location = new System.Drawing.Point(169, 334);
            this.txt_B.MaxLength = 32767;
            this.txt_B.Name = "txt_B";
            this.txt_B.PasswordChar = '\0';
            this.txt_B.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_B.SelectedText = "";
            this.txt_B.SelectionLength = 0;
            this.txt_B.SelectionStart = 0;
            this.txt_B.ShortcutsEnabled = true;
            this.txt_B.Size = new System.Drawing.Size(134, 23);
            this.txt_B.TabIndex = 12;
            this.txt_B.UseSelectable = true;
            this.txt_B.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_B.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_C
            // 
            // 
            // 
            // 
            this.txt_C.CustomButton.Image = null;
            this.txt_C.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txt_C.CustomButton.Name = "";
            this.txt_C.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_C.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_C.CustomButton.TabIndex = 1;
            this.txt_C.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_C.CustomButton.UseSelectable = true;
            this.txt_C.CustomButton.Visible = false;
            this.txt_C.Lines = new string[0];
            this.txt_C.Location = new System.Drawing.Point(169, 371);
            this.txt_C.MaxLength = 32767;
            this.txt_C.Name = "txt_C";
            this.txt_C.PasswordChar = '\0';
            this.txt_C.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_C.SelectedText = "";
            this.txt_C.SelectionLength = 0;
            this.txt_C.SelectionStart = 0;
            this.txt_C.ShortcutsEnabled = true;
            this.txt_C.Size = new System.Drawing.Size(134, 23);
            this.txt_C.TabIndex = 13;
            this.txt_C.UseSelectable = true;
            this.txt_C.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_C.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_D
            // 
            // 
            // 
            // 
            this.txt_D.CustomButton.Image = null;
            this.txt_D.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txt_D.CustomButton.Name = "";
            this.txt_D.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_D.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_D.CustomButton.TabIndex = 1;
            this.txt_D.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_D.CustomButton.UseSelectable = true;
            this.txt_D.CustomButton.Visible = false;
            this.txt_D.Lines = new string[0];
            this.txt_D.Location = new System.Drawing.Point(169, 409);
            this.txt_D.MaxLength = 32767;
            this.txt_D.Name = "txt_D";
            this.txt_D.PasswordChar = '\0';
            this.txt_D.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_D.SelectedText = "";
            this.txt_D.SelectionLength = 0;
            this.txt_D.SelectionStart = 0;
            this.txt_D.ShortcutsEnabled = true;
            this.txt_D.Size = new System.Drawing.Size(134, 23);
            this.txt_D.TabIndex = 14;
            this.txt_D.UseSelectable = true;
            this.txt_D.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_D.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rctxt_onbilgi
            // 
            this.rctxt_onbilgi.Location = new System.Drawing.Point(169, 187);
            this.rctxt_onbilgi.Name = "rctxt_onbilgi";
            this.rctxt_onbilgi.Size = new System.Drawing.Size(232, 71);
            this.rctxt_onbilgi.TabIndex = 15;
            this.rctxt_onbilgi.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sorunun Konusu :";
            // 
            // cmb_konu
            // 
            this.cmb_konu.FormattingEnabled = true;
            this.cmb_konu.ItemHeight = 24;
            this.cmb_konu.Location = new System.Drawing.Point(190, 133);
            this.cmb_konu.Name = "cmb_konu";
            this.cmb_konu.Size = new System.Drawing.Size(136, 30);
            this.cmb_konu.TabIndex = 17;
            this.cmb_konu.UseSelectable = true;
            // 
            // btn_konu
            // 
            this.btn_konu.Location = new System.Drawing.Point(628, 29);
            this.btn_konu.Name = "btn_konu";
            this.btn_konu.Size = new System.Drawing.Size(145, 55);
            this.btn_konu.TabIndex = 18;
            this.btn_konu.Text = "Konu Ekle";
            this.btn_konu.UseSelectable = true;
            // 
            // btn_soruekle
            // 
            this.btn_soruekle.Location = new System.Drawing.Point(205, 506);
            this.btn_soruekle.Name = "btn_soruekle";
            this.btn_soruekle.Size = new System.Drawing.Size(98, 42);
            this.btn_soruekle.TabIndex = 19;
            this.btn_soruekle.Text = "EKLE";
            this.btn_soruekle.UseSelectable = true;
            this.btn_soruekle.Click += new System.EventHandler(this.btn_soruekle_Click);
            // 
            // btn_konuekle
            // 
            this.btn_konuekle.Location = new System.Drawing.Point(716, 171);
            this.btn_konuekle.Name = "btn_konuekle";
            this.btn_konuekle.Size = new System.Drawing.Size(98, 42);
            this.btn_konuekle.TabIndex = 20;
            this.btn_konuekle.Text = "EKLE";
            this.btn_konuekle.UseSelectable = true;
            this.btn_konuekle.Click += new System.EventHandler(this.btn_konuekle_Click);
            // 
            // txt_konuisim
            // 
            // 
            // 
            // 
            this.txt_konuisim.CustomButton.Image = null;
            this.txt_konuisim.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txt_konuisim.CustomButton.Name = "";
            this.txt_konuisim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_konuisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_konuisim.CustomButton.TabIndex = 1;
            this.txt_konuisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_konuisim.CustomButton.UseSelectable = true;
            this.txt_konuisim.CustomButton.Visible = false;
            this.txt_konuisim.Lines = new string[0];
            this.txt_konuisim.Location = new System.Drawing.Point(702, 101);
            this.txt_konuisim.MaxLength = 32767;
            this.txt_konuisim.Name = "txt_konuisim";
            this.txt_konuisim.PasswordChar = '\0';
            this.txt_konuisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_konuisim.SelectedText = "";
            this.txt_konuisim.SelectionLength = 0;
            this.txt_konuisim.SelectionStart = 0;
            this.txt_konuisim.ShortcutsEnabled = true;
            this.txt_konuisim.Size = new System.Drawing.Size(112, 23);
            this.txt_konuisim.TabIndex = 22;
            this.txt_konuisim.UseSelectable = true;
            this.txt_konuisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_konuisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Konu İsmi :";
            // 
            // frm_Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 560);
            this.Controls.Add(this.txt_konuisim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_konuekle);
            this.Controls.Add(this.btn_soruekle);
            this.Controls.Add(this.btn_konu);
            this.Controls.Add(this.cmb_konu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rctxt_onbilgi);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.txt_icerik);
            this.Controls.Add(this.cmb_dogrucevap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brn_soru);
            this.Name = "frm_Ogretmen";
            this.Text = "frm_Ogretmen";
            this.Load += new System.EventHandler(this.frm_Ogretmen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton brn_soru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cmb_dogrucevap;
        private MetroFramework.Controls.MetroTextBox txt_icerik;
        private MetroFramework.Controls.MetroTextBox txt_A;
        private MetroFramework.Controls.MetroTextBox txt_B;
        private MetroFramework.Controls.MetroTextBox txt_C;
        private MetroFramework.Controls.MetroTextBox txt_D;
        private System.Windows.Forms.RichTextBox rctxt_onbilgi;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroComboBox cmb_konu;
        private MetroFramework.Controls.MetroButton btn_konu;
        private MetroFramework.Controls.MetroButton btn_soruekle;
        private MetroFramework.Controls.MetroButton btn_konuekle;
        private MetroFramework.Controls.MetroTextBox txt_konuisim;
        private System.Windows.Forms.Label label9;
    }
}
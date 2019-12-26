using SinavSistemi.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi.Presentation
{
    public partial class frmgiris : MaterialSkin.Controls.MaterialForm
    {
        public frmgiris()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600,MaterialSkin.Primary.BlueGrey900,MaterialSkin.Primary.Blue500,MaterialSkin.Accent.Orange700,MaterialSkin.TextShade.WHITE);


        }

        private void frmgiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Ogrenci.Checked)
                {
                    OgrenciBLL ogrenciBll = new OgrenciBLL();
                    int ogrenciID = ogrenciBll.GirisKontrolu(txt_KullaniciAd.Text, txt_Parola.Text);

                    if (ogrenciID == -1)
                    {
                        MessageBox.Show("Kullanıcı Adı/Şifre Hatalıdır..!", "Öğrenci Bilgileri Hatalıdır", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                    else
                    {
                        frmOgrenci ogrenciForm = new frmOgrenci();
                        ogrenciForm.ogrenciID = ogrenciID;
                        ogrenciForm.Show();
                        this.Hide();
                    }
                }
                if (btn_Ogretmen.Checked)
                {
                    OgretmenBLL ogretmenBll = new OgretmenBLL();
                    if (ogretmenBll.GirisKontrolu(txt_KullaniciAd.Text, txt_Parola.Text))
                    {
                        frmOgretmen ogretmen = new frmOgretmen();
                        ogretmen.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı/Şifre Hatalıdır..!", "Öğretmen Bilgileri Hatalıdır", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik veya Hatalı Giriş Yaptınız.!");
            }
        }
    }
}

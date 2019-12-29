using SinavSistemi.BusinessLogicLayer;
using SinavSistemi.DataAccessLayer;
using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi.Presentation
{
    public partial class frmOgretmen : Form
    {
        public frmOgretmen()
        {
            InitializeComponent();
        }

        KonuBLL kbll = new KonuBLL();
        SoruBLL sbll = new SoruBLL();
        OgrenciBLL obll = new OgrenciBLL();
        BasariDAL bdal = new BasariDAL();

        public void KonularıGetir()
        {
            try
            {
                cmb_konu.Items.Clear();
                List<KonuEntity> konular = kbll.KonuGetir();
                for (int i = 0; i < konular.Count; i++)
                {
                    cmb_konu.Items.Add(konular[i].konuAdi);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Konular Getirilirken Hata");
            }
        }
        public void OgrencileriGetir()
        {
            try
            {
                cmb_Ogrenciler.Items.Clear();
                List<OgrenciEntity> ogrenciler = obll.OgrenciGetir();
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    cmb_Ogrenciler.Items.Add(ogrenciler[i].ogrenciAd);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Öğrenciler Getirilirken Hata");
            }
        }

        private void btn_soruekle_Click(object sender, EventArgs e)
        {
            try
            {
                SoruEntity soru = new SoruEntity
                {
                    soruA = txt_A.Text,
                    soruB = txt_B.Text,
                    soruC = txt_C.Text,
                    soruD = txt_D.Text,
                    soruOnBilgi = rctxt_onbilgi.Text,
                    soruDogruCevap = cmb_dogrucevap.Text,
                    soruIcerik = txt_icerik.Text,
                    soruKonuID = cmb_konu.SelectedIndex + 1,
                    resimYolu = txt_resimYolu.Text
                };
                if (soru.soruA == "" || soru.soruB == "" || soru.soruC == "" || soru.soruD == "" || soru.soruDogruCevap == "" || soru.soruIcerik == "" || soru.soruOnBilgi == "" || soru.soruKonuID == null)
                {

                    MessageBox.Show("Boş geçilemez!"); ;
                    
                }
                else
                {
                    sbll.SoruEkle(soru);
                    MessageBox.Show("Başarılı");
                    Temizle();
                }

        }
            catch (Exception)
            {
                MessageBox.Show("Eksik veya hatalı bilgi girdiniz!");
            }
}

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmOgretmen_Load(object sender, EventArgs e)
        {
            KonularıGetir();
            OgrencileriGetir();
        }

        private void btn_OgrenciIstatistlikGetir_Click(object sender, EventArgs e)
        {
            int i = 0;
            chart1.Series["sinav_Istatistik"].Points.Clear();
            SqlDataReader sinavOrtalamalar = bdal.SinavOrtalamalariGetir(cmb_Ogrenciler.SelectedIndex + 1);
            while (sinavOrtalamalar.Read())
            {
                chart1.Series["sinav_Istatistik"].Points.Add(Convert.ToDouble(sinavOrtalamalar[1]));
                chart1.Series["sinav_Istatistik"].Points[i].AxisLabel = sinavOrtalamalar[0].ToString();
                i++;
            }

        }


        public void Temizle()
        {
            txt_A.Text = "";
            txt_B.Text = "";
            txt_C.Text = "";
            txt_D.Text = "";
            rctxt_onbilgi.Text = "";
            cmb_dogrucevap.Text = "";
            txt_icerik.Text = "";
            cmb_konu.Text = "";
            txt_resimYolu.Text = "";
            resim.ImageLocation = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            resim.ImageLocation = fileDialog.FileName;
            txt_resimYolu.Text = fileDialog.FileName;
        }
    }
}

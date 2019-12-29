using SinavSistemi.BusinessLogicLayer;
using SinavSistemi.Entity;
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
    public partial class frmSinav : Form
    {
        public frmSinav()
        {
            InitializeComponent();
        }

        SoruBLL sorubll = new SoruBLL();
        List<SoruEntity> sorular;
        public int ogrenciID;
        int sure = 300;


        CevapBLL cevapBLL = new CevapBLL();
        List<CevapEntity> cevaplar = new List<CevapEntity>();
        int i = 0;

        private void frmSinav_Load(object sender, EventArgs e)
        {
            lbl_sure.Text = "300";
            Sure.Interval = 1000;
            Sure.Start();
            sorular = sorubll.SorularıGetir(ogrenciID);
            SoruGoster(i);
            btn_SinavBitir.Visible = false;

            for (int j = 0; j < sorular.Count; j++)
            {
                CevapEntity cevap = new CevapEntity
                {
                    dogruYanlisKontrol = 0,
                    cevapKonuID = sorular[j].soruKonuID,
                    cevapSoruID = sorular[j].soruID,
                    cevapOgrenciID = ogrenciID,
                };
                cevaplar.Add(cevap);
            }
            
        }

        public void temizle()
        {
            rdo_A.Checked = false;
            rdo_B.Checked = false;
            rdo_C.Checked = false;
            rdo_D.Checked = false;
        }
        public void CevapDoldur(int dogruyanlis)
        {

            try
            {
                cevaplar[i].dogruYanlisKontrol = dogruyanlis;
                cevaplar[i].cevapKonuID = sorular[i].soruKonuID;
                cevaplar[i].cevapSoruID = sorular[i].soruID;
                cevaplar[i].cevapOgrenciID = ogrenciID;
            }
            catch (Exception)
            {
                CevapEntity cevap = new CevapEntity
                {
                    dogruYanlisKontrol = dogruyanlis,
                    cevapKonuID = sorular[i].soruKonuID,
                    cevapSoruID = sorular[i].soruID,
                    cevapOgrenciID = ogrenciID,
                };
                cevaplar.Add(cevap);
            }
        }
        public void SoruGoster(int i)
        {
            temizle();
            try
            {
                lbl_numara.Text = (i + 1).ToString();
                lbl_onbilgi.Text = sorular[i].soruOnBilgi;
                lbl_icerik.Text = sorular[i].soruIcerik;
                lbl_A.Text = sorular[i].soruA;
                lbl_B.Text = sorular[i].soruB;
                lbl_C.Text = sorular[i].soruC;
                lbl_D.Text = sorular[i].soruD;
                pctr_resim.ImageLocation = sorular[i].resimYolu;
            }
            catch (Exception)
            {
                MessageBox.Show("Sınav Bitti..");
                btn_Sonraki.Visible = false;
                btn_SinavBitir.Visible = true;
            }
            
        }

        private void btn_Cevapla_Click(object sender, EventArgs e)
        {
            if (rdo_A.Checked && "A" == sorular[i].soruDogruCevap)
                CevapDoldur(1);

            else if (rdo_B.Checked && "B" == sorular[i].soruDogruCevap)
                CevapDoldur(1);

            else if (rdo_C.Checked && "C" == sorular[i].soruDogruCevap)
                CevapDoldur(1);

            else if (rdo_D.Checked && "D" == sorular[i].soruDogruCevap)
                CevapDoldur(1);
            else
                CevapDoldur(0);

            temizle();
            i++;
            SoruGoster(i);
        }

        private void btn_SinavBitir_Click(object sender, EventArgs e)
        {
            Sure.Stop();
            cevapBLL.CevaplarıEkle(cevaplar);
            MessageBox.Show("Sınav Bitti Cevaplarınız Kaydediliyor..");
            this.Close();
        }

        private void btn_Sonraki_Click(object sender, EventArgs e)
        {
            if (i<19)
            {
                i++;
                temizle();
                SoruGoster(i);
            }
            else if (i==19)
            {
                btn_Sonraki.Visible = false;
                btn_SinavBitir.Visible = true;
            }
            
        }

        private void btn_Onceki_Click(object sender, EventArgs e)
        {
            if (i>0)
            {
                i--;
                btn_Sonraki.Visible = true;
                temizle();
                SoruGoster(i);

            }
            
        }

        private void Sure_Tick(object sender, EventArgs e)
        {
            lbl_sure.Text = sure.ToString();
            sure--;
            if (sure == 9)
            {
                lbl_sure.BackColor = Color.Red;
            }
            if (sure == -1)
            {
                cevapBLL.CevaplarıEkle(cevaplar);
                MessageBox.Show("Sınav Bitti Cevaplarınız Kaydediliyor..");
                Sure.Stop();
                this.Close();
            }
            
        }

        private void tbn_Cikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sınavı iptal etmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Sure.Stop();
                this.Close();
            }
        }
    }
}

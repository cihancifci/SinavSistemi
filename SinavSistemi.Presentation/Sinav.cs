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
    public partial class Sinav : Form
    {
        public Sinav()
        {
            InitializeComponent();
        }
        SoruBLL sorubll = new SoruBLL();
        List<SoruEntity> sorular;
        
        CevapBLL cevapBLL = new CevapBLL();
        List<CevapEntity> cevaplar = new List<CevapEntity>();
        int i = 0;
        private void Sinav_Load(object sender, EventArgs e)
        {
           sorular = sorubll.SorularıGetir();
            SoruGoster(i);
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
                cevaplar[i].cevapOgrenciID = 1;
                cevaplar[i].cevapSinavID = 1;
            }
            catch (Exception)
            {
                CevapEntity cevap = new CevapEntity
                {
                    dogruYanlisKontrol = dogruyanlis,
                    cevapKonuID = sorular[i].soruKonuID,
                    cevapSoruID = sorular[i].soruID,
                    cevapOgrenciID = 1,
                    cevapSinavID = 1
                };
                cevaplar.Add(cevap);
            }
        }
        public void SoruGoster(int i)
        {
            try
            {
                lbl_numara.Text = (i + 1).ToString();
                lbl_onbilgi.Text = sorular[i].soruOnBilgi;
                lbl_icerik.Text = sorular[i].soruIcerik;
                lbl_A.Text = sorular[i].soruA;
                lbl_B.Text = sorular[i].soruB;
                lbl_C.Text = sorular[i].soruC;
                lbl_D.Text = sorular[i].soruD;
            }
            catch (Exception)
            {
                MessageBox.Show("Sınav Bitti..");
                metroButton2.Visible = false;
                btn_SinavBitir.Visible = true;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            i++;
            temizle();
            SoruGoster(i);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            i--;
            temizle();
            SoruGoster(i);
        }

        private void metroButton1_Click(object sender, EventArgs e)
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
            cevapBLL.CevaplarıEkle(cevaplar);
            MessageBox.Show("sınav gg");
            this.Close();
        }
    }
}

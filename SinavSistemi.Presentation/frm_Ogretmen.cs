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
    public partial class frm_Ogretmen : Form
    {
        public frm_Ogretmen()
        {
            InitializeComponent();
        }
        KonuBLL kbll = new KonuBLL();
        SoruBLL sbll = new SoruBLL();
        private void frm_Ogretmen_Load(object sender, EventArgs e)
        {
            KonularıGetir();
        }

        public void KonularıGetir()
        {
            try
            {
                cmb_konu.Items.Clear();
                List<KonuEntity> konular = new List<KonuEntity>();
                konular = kbll.KonuGetir();
                for (int i = 0; i < konular.Count; i++)
                {
                    cmb_konu.Items.Add(konular[i].konuAdi);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
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
                    soruKonuID = cmb_konu.SelectedIndex + 1
                };
                sbll.SoruEkle(soru);
                
            }
            catch (Exception)
            {
                MessageBox.Show("soru eklenirken hata");
            }
            

        }

        private void btn_konuekle_Click(object sender, EventArgs e)
        {
            try
            {
                bool konukontrol = false;
                for (int i = 0; i < cmb_konu.Items.Count; i++)
                {
                    if(cmb_konu.Items[i].ToString().ToUpper() == txt_konuisim.Text.ToUpper())
                    {
                        MessageBox.Show("Konu zaten eklenmiş");
                        konukontrol = true;
                    }
                }
                if (!konukontrol)
                {
                    KonuEntity konu = new KonuEntity
                    {
                        konuAdi = txt_konuisim.Text
                    };
                    kbll.KonuEkle(konu);
                    KonularıGetir();
                    MessageBox.Show("Konu başarı ile eklendi hlll...");
                    txt_konuisim.Text = null;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("konu eklenirken hata");
            }
        }
    }
}

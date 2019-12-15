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
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }

        private void btn_OgrenciGiris_Click(object sender, EventArgs e)
        {
            OgrenciBLL ogrenciBll = new OgrenciBLL();
            int ogrenciID = ogrenciBll.GirisKontrolu(txt_ogrenciAd.Text,txt_ogrenciParola.Text);

            if (ogrenciID == -1)
            {
                MessageBox.Show("Hatalı Giriş");
            }

            else
            {
                frm_Ogrenci ogrenciForm = new frm_Ogrenci();
                ogrenciForm.ogrenciID = ogrenciID;
                ogrenciForm.ShowDialog();
            }

        }
    }
}

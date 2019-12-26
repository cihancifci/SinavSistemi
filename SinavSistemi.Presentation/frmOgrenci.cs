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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        public int ogrenciID;
        private void btn_SinavYap_Click(object sender, EventArgs e)
        {
            frmSinav sinavForm = new frmSinav
            {
                ogrenciID = ogrenciID
            };
            sinavForm.ShowDialog();
            
        }
        private void btn_Istatistlik_Click(object sender, EventArgs e)
        {
            frmIstatistlik istatistikForm = new frmIstatistlik();
            istatistikForm.ogrenciID = ogrenciID;
            istatistikForm.ShowDialog();  
        }
        private void tbn_Cikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

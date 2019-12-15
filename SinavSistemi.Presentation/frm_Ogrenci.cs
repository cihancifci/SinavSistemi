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
    public partial class frm_Ogrenci : Form
    {
        public frm_Ogrenci()
        {
            InitializeComponent();
        }
        public int ogrenciID;

        private void frm_Ogrenci_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frm_Sinav sinavForm = new frm_Sinav();
            sinavForm.ogrenciID = ogrenciID;
            sinavForm.ShowDialog();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frm_Istatistlik istatistikForm = new frm_Istatistlik();
            istatistikForm.ShowDialog();
        }
    }
}

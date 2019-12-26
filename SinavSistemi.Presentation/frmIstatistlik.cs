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
    public partial class frmIstatistlik : Form
    {
        DBHelper dbHelper = new DBHelper();
        public frmIstatistlik()
        {
            InitializeComponent();
        }
        public int ogrenciID;
        BasariDAL dal = new BasariDAL();
        private void frmIstatistlik_Load(object sender, EventArgs e)
        {
            int sinavSayisi = dal.SinavSayisiGetir(ogrenciID);
            for (int i = 1; i <= sinavSayisi; i++)
            {
                cmb_Sinavlar.Items.Add(i);
            }

        }
        private void tbn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_İstatistikGetir_Click_1(object sender, EventArgs e)
        {
            SqlDataReader basarilar = dal.BasariGetir(ogrenciID, cmb_Sinavlar.SelectedIndex + 1);
            chrt_sinav.Series["chrt_Sinav"].Points.Clear();

            while (basarilar.Read())
            {
                chrt_sinav.Series["chrt_Sinav"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(basarilar[0], basarilar[1]));

            }
        }
        private void btn_GenelIstatistik_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            chart1.Series["sinav_Istatistik"].Points.Clear();
            SqlDataReader sinavOrtalamalar = dal.SinavOrtalamalariGetir(ogrenciID);
            while (sinavOrtalamalar.Read())
            {
                chart1.Series["sinav_Istatistik"].Points.Add(Convert.ToDouble(sinavOrtalamalar[1]));
                chart1.Series["sinav_Istatistik"].Points[i].AxisLabel = sinavOrtalamalar[0].ToString();
                i++;
            }
        }
    }
}

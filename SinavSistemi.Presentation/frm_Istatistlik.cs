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
    public partial class frm_Istatistlik : Form
    {
        DBHelper dbHelper = new DBHelper();
        public frm_Istatistlik()
        {
            InitializeComponent();
        }
        BasariDAL dal = new BasariDAL();
        private void frm_Istatistlik_Load(object sender, EventArgs e)
        {
            SqlDataReader basarilar = dal.BasariGetir(1,3);
            
            while (basarilar.Read())
            {
                chrt_sinav.Series["chrt_Sinav"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(basarilar[0], basarilar[1]));

            }
           
            
        }
    }
}

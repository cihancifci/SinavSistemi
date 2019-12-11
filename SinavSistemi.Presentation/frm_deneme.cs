using SinavSistemi.BusinessLogicLayer;
using SinavSistemi.DataAccessLayer;
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
    public partial class frm_deneme : Form
    {
        public frm_deneme()
        {
            InitializeComponent();
        }

        private void frm_deneme_Load(object sender, EventArgs e)
        {
            SoruBLL admin = new SoruBLL();
            SoruEntity entity = new SoruEntity();
            dataGridView1.DataSource = admin.GetAllItems(entity);
        }
    }
}

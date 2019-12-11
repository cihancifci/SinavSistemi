using SinavSistemi.DataAccessLayer;
using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.BusinessLogicLayer
{
   public class SinavBLL
    {
        SinavDAL sinavDAL;
        public SinavBLL()
        {
            sinavDAL = new SinavDAL();
        }
        public DataTable GetAllItems(SinavEntity sinav)
        {
            return sinavDAL.GetAllItems(sinav);
        }
    }
}

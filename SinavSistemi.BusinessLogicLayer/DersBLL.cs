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
    public class DersBLL
    {
        DersDAL dersDAL;
        public DersBLL()
        {
            dersDAL = new DersDAL();
        }
        public DataTable GetAllItems(DersEntity ders)
        {
            return dersDAL.GetAllItems(ders);
        }
    }
}

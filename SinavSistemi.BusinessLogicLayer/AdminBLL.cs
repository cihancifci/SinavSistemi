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
   public class AdminBLL
    {
        AdminDAL adminDAL;
        public AdminBLL()
        {
            adminDAL = new AdminDAL();
        }
        public DataTable GetAllItems(AdminEntity admin)
        {
            return adminDAL.GetAllItems(admin);
        }
    }
}

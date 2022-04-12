using BEL;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class sellerService
    {
        public static bool DeleteSeller(int id)
        {
            bool flag = false;
            flag = DataAccessFactory.Seller().Delete(id);
            return flag;
        }
        public static bool EditSeller(sellerModel obj)
        {
            var r = new seller();
            r.name = obj.name;
            r.email = obj.email;
            r.phone = obj.phone;
            r.presentaddress = obj.presentaddress;
            r.permanentaddress = obj.permanentaddress;
            var flag = DataAccessFactory.Seller().Edit(r);
            return flag;
        }
    }
}

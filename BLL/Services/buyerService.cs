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
    public class buyerService
    {
       
        public static bool DeleteBuyer(int id)
        {
            bool flag = false;
            var buyerD = DataAccessFactory.Buyer().Get(id);
            flag = DataAccessFactory.Buyer().Delete(id);
            if(flag)
            {
                flag = DataAccessFactory.User().Delete(buyerD.uid);
            }
            return flag;
        }
        public static bool EditBuyer(UserBuyerModel obj)
        {
            var flag = false;
            var u = new user();
            u.id = obj.id;
            u.username = obj.username;
            u.password = obj.password;
            flag = DataAccessFactory.User().Edit(u);
            var b = new buyer();
            b.uid = obj.id;
            b.name = obj.buyer.name;
            b.email = obj.buyer.email;
            b.occupation = obj.buyer.occupation;
            b.netincome = obj.buyer.netincome;
            flag = DataAccessFactory.Buyer().Edit(b);
            return flag;
        }

        public static List<UserBuyerModel> AllBuyer()
        {
            var data = DataAccessFactory.Buyer().Get();
            var lst = new List<UserBuyerModel>();
            foreach(var e in data)
            {
                var u = new UserBuyerModel();
                u.id = e.user.id;
                u.username = e.user.username;
                u.password = e.user.password;
                u.role = e.user.role;
                u.status = e.user.status;
                //u.buyer = e.user;
                u.buyer.id = e.id;
                u.buyer.uid = e.uid;
                u.buyer.name = e.name;
                u.buyer.email = e.email;
                u.buyer.occupation = e.occupation;
                u.buyer.netincome = e.netincome;
                lst.Add(u);
            }
            return lst;
        }
    }
}

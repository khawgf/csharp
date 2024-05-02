using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class VIEW_USER_IN_GROUP
    {
        Entities db;
        public VIEW_USER_IN_GROUP() 
        {
            db=Entities.CreateEntities();

        }
        public List<tb_SYS_USER> getgroupbyuser(string macty, string madvi, int iduser)
        {
            List<tb_SYS_USER> lstgroup = new List<tb_SYS_USER>();
            List<V_USER_IN_GROUP> lst = db.V_USER_IN_GROUP.Where(x => x.MEMBER == iduser && x.MACTY == macty && x.MADVI == madvi).ToList();
            tb_SYS_USER u;
            foreach (var item in lst)
            {
                u = new tb_SYS_USER();
                u = db.tb_SYS_USER.FirstOrDefault(x => x.IDUSER == item.GROUP);
                lstgroup.Add(u);

            }
            return lstgroup;
        }

        public List<tb_SYS_USER> getgroupbydonvi(string macty, string madvi)
        {
           return db.tb_SYS_USER.Where(x => x.MACTY == macty && x.MADVI == madvi && x.ISGROUP ==true).ToList();
        }

        public bool checkgroupuser(int iduser, int idgroup)
        {
            var gr = db.tb_SYS_GROUP.FirstOrDefault(x=>x.MEMBER==iduser && x.GROUP ==idgroup);
            if (gr == null)
            {
                return false;
            }
            else
                return true;
        }
        public List<V_USER_IN_GROUP> getuseringroup(string madvi, string macty, int idgroup)
        {
            return db.V_USER_IN_GROUP.Where(x=>x.MACTY == macty&& x.MADVI==madvi && x.GROUP==idgroup &&x.ISGROUP==false && x.DISABLED==false).ToList();
        }
    }
}

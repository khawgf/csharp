using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class SYS_RIGHT_REP
    {
        Entities db;
        public SYS_RIGHT_REP()
        {
            db= Entities.CreateEntities();
        }

        public List<tb_SYS_RIGHT_REP> getlistbyuser(int iduser)
        {
            SYS_GROUP sgroup = new SYS_GROUP();
            var group = sgroup.getgroupbymember(iduser);
            if (group==null)
            {
                return db.tb_SYS_RIGHT_REP.Where(x => x.IDUSER == iduser && x.USER_RIGHT == true).ToList();
            }
            else
            {
                List<tb_SYS_RIGHT_REP> lstbygroup = db.tb_SYS_RIGHT_REP.Where(x=>x.IDUSER==group.GROUP && x.USER_RIGHT ==true).ToList();
                List<tb_SYS_RIGHT_REP> lstbyuser = db.tb_SYS_RIGHT_REP.Where(x => x.IDUSER == iduser && x.USER_RIGHT == true).ToList();
                List<tb_SYS_RIGHT_REP> lstall = lstbyuser.Concat(lstbygroup).ToList();
                return lstall;
            }
        }
        public void update(int iduser, int repcode, bool right)
        {
            tb_SYS_RIGHT_REP sright = db.tb_SYS_RIGHT_REP.FirstOrDefault(x => x.IDUSER == iduser && x.REP_CODE == repcode);
            try
            {
                sright.USER_RIGHT = right;
                db.SaveChanges();


            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}

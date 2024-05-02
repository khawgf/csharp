using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class SYS_GROUP
    {
        Entities db;

        public SYS_GROUP() 
        { 
        
            db = Entities.CreateEntities();
        }
        public tb_SYS_GROUP getgroupbymember(int iduser)
        {
            return db.tb_SYS_GROUP.FirstOrDefault(x=>x.MEMBER==iduser);
        }
        public void add(tb_SYS_GROUP gr)
        {
            try
            {
                db.tb_SYS_GROUP.Add(gr);
                db.SaveChanges();
               
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi khi thêm" + ex.Message);
            }
        }
        public void delGroup(int iduser, int group)
        {
            var gr = db.tb_SYS_GROUP.FirstOrDefault(x=> x.MEMBER==iduser && x.GROUP==group);
            if (gr!=null)
            {
                try
                {
                    db.tb_SYS_GROUP.Remove(gr);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {

                    throw new Exception("Lỗi khi thêm" + ex.Message);
                }
            }

        }

    }
}

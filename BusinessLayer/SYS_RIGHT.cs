using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class SYS_RIGHT
    {
        Entities db;

        public SYS_RIGHT()
        {
            db= Entities.CreateEntities();
        }

        public tb_SYS_RIGHT getright(int iduser, string funcode)
        {
            return db.tb_SYS_RIGHT.FirstOrDefault(x => x.IDUSER == iduser && x.FUNC_CODE == funcode);
        }
        public void update(int iduser, string funccode, int right)
        {
            tb_SYS_RIGHT sright = db.tb_SYS_RIGHT.FirstOrDefault(x=>x.IDUSER ==iduser && x.FUNC_CODE == funccode);
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

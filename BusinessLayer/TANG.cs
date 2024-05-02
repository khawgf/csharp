using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class TANG
    {
        Entities db;
        public TANG()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_Tang> getall()
        {
            return db.tb_Tang.ToList();
        }
        public tb_Tang getitem(int idtang)
        {
            return db.tb_Tang.FirstOrDefault(x => x.IDTANG == idtang);
        }
        public void add(tb_Tang tang)
        {

            try
            {
                db.tb_Tang.Add(tang);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }
        public void update(tb_Tang tang)
        {
            tb_Tang _tang = db.tb_Tang.FirstOrDefault(x => x.IDTANG == tang.IDTANG);
            _tang.TENTANG = tang.TENTANG;
            _tang.DISABLED = tang.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }
        public void delete(int idtang)
        {
            tb_Tang _cty = db.tb_Tang.FirstOrDefault(x => x.IDTANG == idtang);
            _cty.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh delete" + ex.Message);
            }
        }
    }
}

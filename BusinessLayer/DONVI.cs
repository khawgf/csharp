using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DONVI
    {
        Entities db;
        public DONVI() 
        { 
            db= Entities.CreateEntities();
        }
        public tb_dvi getitem(string madvi)
        {
            return db.tb_dvi.FirstOrDefault(x=>x.MADVI== madvi);
        }

        public List<tb_dvi> getall()
        {
            return db.tb_dvi.ToList();
        }
        public List<tb_dvi> getall(string macty)
        {
            return db.tb_dvi.Where(x=>x.MACTY== macty).ToList();
        }
        public void add(tb_dvi dvi)
        {
            try
            {
                db.tb_dvi.Add(dvi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }

        public void update(tb_dvi dvi)
        {
            tb_dvi _dvi = db.tb_dvi.FirstOrDefault(x => x.MADVI == dvi.MADVI);
            _dvi.MACTY = dvi.MACTY;
            _dvi.TENDVI = dvi.TENDVI;
            _dvi.DIENTHOAI = dvi.DIENTHOAI;
            _dvi.EMAIL = dvi.EMAIL;
            _dvi.FAX = dvi.FAX;
            _dvi.DIACHI = dvi.DIACHI;
            _dvi.DISABLED = dvi.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(string madvi)
        {
            tb_dvi _dvi = db.tb_dvi.FirstOrDefault(x => x.MADVI == madvi);
            _dvi.DISABLED = true;
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

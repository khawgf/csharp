using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SANPHAM
    {
        Entities db;
        public SANPHAM()
        {
            db = Entities.CreateEntities();
        }
        public tb_SanPham getitem(int idsp)
        {
            return db.tb_SanPham.FirstOrDefault(x => x.IDSP == idsp);
        }
        public List<tb_SanPham> getlist()
        {
            return db.tb_SanPham.ToList();
        }

        public List<tb_SanPham> getall()
        {
            return db.tb_SanPham.ToList();
        }
        public void add(tb_SanPham sp)
        {

            try
            {
                db.tb_SanPham.Add(sp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }
        public void update(tb_SanPham sp)
        {
            tb_SanPham _sp = db.tb_SanPham.FirstOrDefault(x => x.IDSP == sp.IDSP);
            _sp.TENSP = sp.TENSP;
            _sp.DONGIA = sp.DONGIA;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(int idsp)
        {
            tb_SanPham _sp = db.tb_SanPham.FirstOrDefault(x => x.IDSP == idsp);
            try
            {
                if (_sp != null)
                {
                    db.tb_SanPham.Remove(_sp);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh delete" + ex.Message);
            }
        }

    }

}

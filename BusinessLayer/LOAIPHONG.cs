using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class LOAIPHONG
    {
        Entities db;
        public LOAIPHONG()
        {
            db = Entities.CreateEntities();
        }
        public tb_LoaiPhong getitem(int idloaiphong)
        {
            return db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == idloaiphong);
        }
        public List<tb_LoaiPhong> getall()
        {
            return db.tb_LoaiPhong.ToList();
        }
        public void add(tb_LoaiPhong loaiphong)
        {

            try
            {
                db.tb_LoaiPhong.Add(loaiphong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }
        public void update(tb_LoaiPhong loaiphong)
        {
            tb_LoaiPhong _loaiphong = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == loaiphong.IDLOAIPHONG);
            _loaiphong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
            _loaiphong.DONGIA = loaiphong.DONGIA;
            _loaiphong.SONGUOI = loaiphong.SONGUOI;
            _loaiphong.SOGIUONG = loaiphong.SOGIUONG;
            _loaiphong.DISABLED = loaiphong.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(int idloaiphong)
        {
            tb_LoaiPhong _loaiphong = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == idloaiphong);
            _loaiphong.DISABLED = true;
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

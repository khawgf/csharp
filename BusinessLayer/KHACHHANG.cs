using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class KHACHHANG
    {
        Entities db;
        public KHACHHANG()
        {
            db = Entities.CreateEntities();
        }
        public tb_KhachHang getitem(int idkh)
        {
            return db.tb_KhachHang.FirstOrDefault(x => x.IDKH == idkh);
        }
        public List<tb_KhachHang> getall()
        {
            return db.tb_KhachHang.ToList();
        }
        public void add(tb_KhachHang kh)
        {

            try
            {
                db.tb_KhachHang.Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }
        public void update(tb_KhachHang kh)
        {
            tb_KhachHang _kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == kh.IDKH);
            _kh.HOTEN = kh.HOTEN;
            _kh.CCCD = kh.CCCD;
            _kh.EMAIL = kh.EMAIL;
            _kh.DIENTHOAI = kh.DIENTHOAI;
            _kh.DIACHI = kh.DIACHI;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(int idkh)
        {
            tb_KhachHang _kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == idkh);
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

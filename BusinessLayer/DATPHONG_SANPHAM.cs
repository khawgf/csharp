using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DATPHONG_SANPHAM
    {

        Entities db;
        public DATPHONG_SANPHAM()
        {
            db = Entities.CreateEntities();
        }
        public tb_DatPhong_SanPham getitem(int iddpsp)
        {
            return db.tb_DatPhong_SanPham.FirstOrDefault(x => x.IDDPSP == iddpsp);
        }
        public List<tb_DatPhong_SanPham> getall()
        {
            return db.tb_DatPhong_SanPham.ToList();
        }
        public List<OBJ_DPSP> getallbydatphong(int idDP)
        {
            var lst=db.tb_DatPhong_SanPham.Where(x=>x.IDDP==idDP).ToList();
            List<OBJ_DPSP> lstDPSP= new List<OBJ_DPSP>();
            OBJ_DPSP sp;
            foreach(var item in lst)
            {
                sp=new OBJ_DPSP();
                sp.IDDPSP = item.IDDPSP;
                sp.IDDP = item.IDDP;
                sp.IDPHONG = item.IDPHONG;
                var p =db.tb_Phong.FirstOrDefault(x=>x.IDPHONG==item.IDPHONG);
                sp.TENPHONG = p.TENPHONG;
                sp.IDSP = item.IDSP;
                var s = db.tb_SanPham.FirstOrDefault(x=>x.IDSP==item.IDSP);
                sp.TENSP= s.TENSP;
                sp.SOLUONG = item.SOLUONG;
                sp.DONGIA = item.DONGIA;
                sp.THANHTIEN = item.THANHTIEN;
                lstDPSP.Add(sp);


            }
            return lstDPSP;

        }

        public List<tb_DatPhong_SanPham> getallbyphong(int idDP, int iddpct)
        {
            return  db.tb_DatPhong_SanPham.Where(x => x.IDDP == idDP && x.IDDPCT== iddpct).ToList();
            

        }
        public void add(tb_DatPhong_SanPham dpsp)
        {

            try
            {
                db.tb_DatPhong_SanPham.Add(dpsp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }
        public void update(tb_DatPhong_SanPham dpsp)
        {
            tb_DatPhong_SanPham _dpsp = db.tb_DatPhong_SanPham.FirstOrDefault(x => x.IDDPSP == dpsp.IDDPSP);
            _dpsp.IDDP = dpsp.IDDP;
            _dpsp.IDDPCT = dpsp.IDDPCT;
            _dpsp.IDPHONG = dpsp.IDPHONG;
            _dpsp.IDSP = dpsp.IDSP;
            _dpsp.NGAY = dpsp.NGAY;
            _dpsp.SOLUONG = dpsp.SOLUONG;
            _dpsp.DONGIA = dpsp.DONGIA;
            _dpsp.THANHTIEN = dpsp.THANHTIEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(int iddpsp)
        {
            tb_DatPhong_SanPham _dpct = db.tb_DatPhong_SanPham.FirstOrDefault(x => x.IDDPSP == iddpsp);

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh delete" + ex.Message);
            }
        }

        public void deleteAll(int IDDP)
        {
            List<tb_DatPhong_SanPham> lspSP = db.tb_DatPhong_SanPham.Where(x => x.IDDP == IDDP).ToList();
            try
            {
                db.tb_DatPhong_SanPham.RemoveRange(lspSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh delete" + ex.Message);
            }
        }

        public void deleteAllbyphong(int IDDP, int _idphong)
        {
            List<tb_DatPhong_SanPham> lspSP = db.tb_DatPhong_SanPham.Where(x => x.IDDP == IDDP && x.IDPHONG == _idphong).ToList();
            try
            {
                db.tb_DatPhong_SanPham.RemoveRange(lspSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh delete" + ex.Message);
            }
        }


    }
}

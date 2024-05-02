using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.SqlServer.Server;

namespace BusinessLayer
{
    public class DATPHONG
    {
        Entities db;
        public DATPHONG()
        {
            db = Entities.CreateEntities();
        }
        public tb_DatPhong getitem(int iddp)
        {
            return db.tb_DatPhong.FirstOrDefault(x => x.IDDP == iddp);
        }
        public List<tb_DatPhong> getall()
        {
            return db.tb_DatPhong.ToList();
        }
        public List<OBJ_DATPHONG>getall(DateTime tungay, DateTime denngay, string macty,string madvi)
        {
           var listDP = db.tb_DatPhong.Where(x => x.NGAYDATPHONG>= tungay&& x.NGAYDATPHONG<denngay&& x.MACTY==macty &&x.MADVI==madvi).ToList();
            List<OBJ_DATPHONG> lstDP = new List<OBJ_DATPHONG>();
            OBJ_DATPHONG dp;
            foreach (var item in listDP)
            {
                dp = new OBJ_DATPHONG();
                dp.IDDP = item.IDDP;
                dp.IDKH = item.IDKH;
                var kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH ==item.IDKH);
                dp.HOTEN = kh.HOTEN;
                dp.IDUSER = item.IDUSER;
                dp.NGAYDATPHONG = item.NGAYDATPHONG;
                dp.NGAYTRAPHONG = item.NGAYTRAPHONG;
                dp.MACTY= item.MACTY;
                dp.MADVI = item.MADVI;
                dp.SONGUOIO = item.SONGUOIO;
                dp.SOTIEN = item.SOTIEN;
                dp.STATUS = item.STATUS;
                dp.THEODOAN = item.THEODOAN;
                dp.DISABLED = item.DISABLED;
                dp.GHICHU = item.GHICHU;
                lstDP.Add(dp);

                

            }
            return lstDP;
        }
        public tb_DatPhong add(tb_DatPhong dp)
        {

            try
            {
                db.tb_DatPhong.Add(dp);
                db.SaveChanges();
                return dp;
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }

        public bool CheckDP(int dp)
        {
            return db.tb_Phong.Any(x => x.IDPHONG == dp && x.TRANGTHAI == true);
        }
        public tb_DatPhong update(tb_DatPhong dp)
        {
            tb_DatPhong _dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == dp.IDDP);
            _dp.IDKH = dp.IDKH;
            _dp.MADVI = dp.MADVI;
            _dp.MACTY = dp.MACTY;
            _dp.NGAYDATPHONG = dp.NGAYDATPHONG;
            _dp.NGAYTRAPHONG = dp.NGAYTRAPHONG;
            _dp.SONGUOIO = dp.SONGUOIO;
            _dp.SOTIEN = dp.SOTIEN;
            _dp.IDUSER = dp.IDUSER;
            _dp.DISABLED = dp.DISABLED;
            _dp.THEODOAN = dp.THEODOAN;
            _dp.GHICHU = dp.GHICHU;
            _dp.CREATED_DATE = dp.CREATED_DATE;
            try
            {
                db.SaveChanges();
                return dp;
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(int iddp)
        {
            tb_DatPhong _dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == iddp);
            _dp.DISABLED = true;
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

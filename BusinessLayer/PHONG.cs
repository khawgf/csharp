using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PHONG
    {
        Entities db;
        public PHONG() 
        { 
            db = Entities.CreateEntities();
        }
        public tb_Phong getitem(int idphong)
        {
            return db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idphong);
        }

        public OBJ_PHONG getitemfull(int idphong)
        {
            var phongData = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idphong);
            var loaiphongData = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == phongData.IDLOAIPHONG);

            var objPhong = new OBJ_PHONG
            {
                IDPHONG = phongData.IDPHONG,
                TENPHONG = phongData.TENPHONG,
                TRANGTHAI = phongData.TRANGTHAI,
                IDTANG = phongData.IDTANG,
                IDLOAIPHONG = phongData.IDLOAIPHONG,
                DONGIA = loaiphongData.DONGIA,
                DISABLED = phongData.DISABLED
            };

            return objPhong;
        }
        public List<OBJ_PHONG> getphongtrongfull()
        {
            var phongTrongList = db.tb_Phong
                .Where(x => x.TRANGTHAI == false) // Lọc các phòng có trạng thái "Trống" (giá trị false)
                .Select(phongData => new
                {
                    Phong = phongData,
                    LoaiPhong = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == phongData.IDLOAIPHONG)
                })
                .Select(x => new OBJ_PHONG
                {
                    IDPHONG = x.Phong.IDPHONG,
                    TENPHONG = x.Phong.TENPHONG,
                    TRANGTHAI = x.Phong.TRANGTHAI,
                    IDTANG = x.Phong.IDTANG,
                    IDLOAIPHONG = x.Phong.IDLOAIPHONG,
                    DONGIA = x.LoaiPhong.DONGIA,
                    DISABLED = x.Phong.DISABLED
                })
                .ToList();

            return phongTrongList;
        }

        public List<tb_Phong>getAll()
        {
            return db.tb_Phong.ToList();
        }
        public List<tb_Phong> getAll(int idtang)
        {
            return db.tb_Phong.Where(x => x.IDTANG == idtang).ToList();
        }
        public List<tb_Phong> getAll1(int idloaiphong)
        {
            return db.tb_Phong.Where(x => x.IDLOAIPHONG == idloaiphong).ToList();
        }


        public List<tb_Phong> getbyTang(int idtang)
        {
            return db.tb_Phong.Where(x=>x.IDTANG == idtang).ToList();
        }

        public List<tb_Phong> getbyloaiphong(int idloaiphong)
        {
            return db.tb_Phong.Where(x => x.IDLOAIPHONG == idloaiphong).ToList();
        }
        public List<tb_Phong> getbyTangVaLoaiPhong(int idtang, int idloaiphong)
        {
            return db.tb_Phong.Where(x => x.IDTANG == idtang && x.IDLOAIPHONG == idloaiphong).ToList();
        }

        public void add(tb_Phong phong)
        {
            try
            {
                db.tb_Phong.Add(phong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }

        public void update(tb_Phong phong)
        {
            tb_Phong _phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == phong.IDPHONG);
            _phong.IDPHONG = phong.IDPHONG;
            _phong.TENPHONG = phong.TENPHONG;
            _phong.TRANGTHAI = phong.TRANGTHAI;
            _phong.IDTANG = phong.IDTANG;
            _phong.IDLOAIPHONG = phong.IDLOAIPHONG;
            _phong.DISABLED = phong.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }
        public void updateStatus(int id, bool status)
        {
            tb_Phong _phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
            _phong.TRANGTHAI = status;
            db.SaveChanges();
        }

        public void delete(int idphong)
        {
            tb_Phong _phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idphong);
            _phong.DISABLED = true;
            try
            {
                if (_phong != null)
                {
                    db.tb_Phong.Remove(_phong);
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

using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DATPHONG_CHITIET
    {
        Entities db;
        public DATPHONG_CHITIET()
        {
            db = Entities.CreateEntities();
        }
        public tb_DatPhong_CT getitem(int iddpct)
        {
            return db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDPCT == iddpct);
        }

        public tb_DatPhong_CT getItem(int iddpct)
        {
            return db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDPCT == iddpct);
        }

        public tb_DatPhong_CT getItem(int iddp,int idphong)
        {
            return db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDP == iddp && x.IDPHONG == idphong);
        }
        public List<tb_DatPhong_CT> getallbydatphong(int _idDP)
        {
            return db.tb_DatPhong_CT.Where(x => x.IDDP == _idDP).ToList();
        }
        public List<tb_DatPhong_CT> getall()
        {
            return db.tb_DatPhong_CT.ToList();
        }
        public tb_DatPhong_CT getIDDPbyPhog(int idphong)
        {
            return db.tb_DatPhong_CT.OrderByDescending(x => x.NGAY).FirstOrDefault(x=>x.IDPHONG==idphong);
        }
        public tb_DatPhong_CT add(tb_DatPhong_CT dpct)
        {

            try
            {
                db.tb_DatPhong_CT.Add(dpct);
                db.SaveChanges();
                return dpct;
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }
        public void update(tb_DatPhong_CT dpct)
        {
            tb_DatPhong_CT _dpct = db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDPCT == dpct.IDDPCT);
            _dpct.IDDP = dpct.IDDP;
            _dpct.IDPHONG = dpct.IDPHONG;
            _dpct.IDDPCT = dpct.IDDPCT;
            _dpct.SONGAYO = dpct.SONGAYO;
            _dpct.DONGIA = dpct.DONGIA;
            _dpct.THANHTIEN = dpct.THANHTIEN;
            _dpct.NGAY = dpct.NGAY;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(int iddp, int idphong)
        {
            tb_DatPhong_CT _dpct = db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDP == iddp && x.IDPHONG==idphong);

            try
            {
                db.tb_DatPhong_CT.Remove(_dpct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh delete" + ex.Message);
            }
        }
        public void deleteAll(int IDDP)
        {
            List<tb_DatPhong_CT> lspDPCT = db.tb_DatPhong_CT.Where(x => x.IDDP == IDDP).ToList();
            try
            {
                db.tb_DatPhong_CT.RemoveRange(lspDPCT);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh delete" + ex.Message);
            }
        }

    }

}

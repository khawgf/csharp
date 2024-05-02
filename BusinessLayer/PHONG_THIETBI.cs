using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHONG_THIETBI
    {
        Entities db;
        public PHONG_THIETBI()
        {
            db = Entities.CreateEntities();
        }
        public tb_Phong_ThietBi getitem(int idp, int idtb)
        {
            return db.tb_Phong_ThietBi.FirstOrDefault(x => x.IDPHONG == idp && x.IDTB == idtb);
        }

        public List<object> getall()
        {
            var query = from ptb in db.tb_Phong_ThietBi
                        join p in db.tb_Phong on ptb.IDPHONG equals p.IDPHONG
                        join tb in db.tb_ThietBi on ptb.IDTB equals tb.IDTB
                        select new
                        {
                            TENPHONG = p.TENPHONG,
                            TENTB = tb.TENTB,
                            SOLUONG = ptb.SOLUONG,
                            IDPHONG = ptb.IDPHONG,
                            IDTB = ptb.IDTB
                        };

            List<object> result = query.ToList<object>();
            return result;
        }

        public List<tb_Phong_ThietBi> getall(int idp, int idtb)
        {
            var query = from ptb in db.tb_Phong_ThietBi
                        where ptb.IDPHONG == idp && ptb.IDTB == idtb
                        select new tb_Phong_ThietBi
                        {
                            IDPHONG = ptb.IDPHONG,
                            IDTB = ptb.IDTB,
                            SOLUONG = ptb.SOLUONG
                        };

            List<tb_Phong_ThietBi> result = query.ToList();
            return result;
        }

        public void add(tb_Phong_ThietBi ptb)
        {
            try
            {
                db.tb_Phong_ThietBi.Add(ptb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them" + ex.Message);
            }
        }

        public void update(tb_Phong_ThietBi ptb)
        {
            tb_Phong_ThietBi _ptb = db.tb_Phong_ThietBi.FirstOrDefault(x => x.IDPHONG == ptb.IDPHONG && x.IDTB == ptb.IDTB);
            _ptb.IDPHONG = _ptb.IDPHONG;
            _ptb.IDTB = ptb.IDTB;
            _ptb.SOLUONG = ptb.SOLUONG;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(int idp, int idtb)
        {
            tb_Phong_ThietBi _ptb = db.tb_Phong_ThietBi.FirstOrDefault(x => x.IDPHONG == idp && x.IDTB == idtb);

            try
            {
                if (_ptb != null)
                {
                    db.tb_Phong_ThietBi.Remove(_ptb);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình delete: " + ex.Message);
            }
        }
    }
}
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class CONGTY
    {
        Entities db;
        public CONGTY()
        {
            db = Entities.CreateEntities();
        }
        public tb_cty getitem(string macty)
        {
            return db.tb_cty.FirstOrDefault(x=>x.MACTY==macty);
        }
        public List<tb_cty> getall()
        {
            return db.tb_cty.ToList();
        }
        public void add(tb_cty cty)
        {
            
            try
            {
                db.tb_cty.Add(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("co loi trong qua trinh them"+ex.Message);
            }
        }
        public void update(tb_cty cty) 
        {
            tb_cty _cty =  db.tb_cty.FirstOrDefault(x=>x.MACTY==cty.MACTY);
            _cty.TENCTY = cty.TENCTY;
            _cty.DIENTHOAI= cty.DIENTHOAI;
            _cty.EMAIL= cty.EMAIL;
            _cty.FAX=cty.FAX;
            _cty.DIACHI= cty.DIACHI;
            _cty.DISABLED= cty.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch ( Exception ex)
            {

                throw new Exception("co loi trong qua trinh update" + ex.Message);
            }

        }

        public void delete(string macty)
        {
            tb_cty _cty = db.tb_cty.FirstOrDefault(x => x.MACTY == macty);
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

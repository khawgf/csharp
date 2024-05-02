using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using DataLayer;

namespace BusinessLayer
{
    public class SYS_USER
    {
        Entities db;
        public SYS_USER()
        {
            db = Entities.CreateEntities();
        }
        public tb_SYS_USER getitem(int iduser)
        {
            return db.tb_SYS_USER.FirstOrDefault(x=>x.IDUSER==iduser);
        }
        public tb_SYS_USER getitem(string username, string macty, string madvi)
        {
            return db.tb_SYS_USER.FirstOrDefault(x => x.USERNAME == username && x.MACTY==macty && x.MADVI==madvi);
        }
        public List<tb_SYS_USER> getall()
        {
            return db.tb_SYS_USER.ToList();
        }
        public List<tb_SYS_USER> getuserbydvi(string macty, string madvi)
        {
            return db.tb_SYS_USER.Where(x => x.MACTY == macty && x.MADVI == madvi).OrderByDescending(x => x.ISGROUP).ToList();
        }
        public List<tb_SYS_USER> getuserbyDVIfunc(string macty, string madvi)
        {
            return db.tb_SYS_USER.Where(x => x.MACTY == macty && x.MADVI == madvi && x.DISABLED ==false).OrderByDescending(x=>x.ISGROUP).ToList();
        }
        public bool checkuserexist(string macty, string madvi, string username)
        {
            var us = db.tb_SYS_USER.FirstOrDefault(x => x.MACTY == macty && x.MADVI == madvi && x.USERNAME == username);
            if (us != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public tb_SYS_USER adđ(tb_SYS_USER us)
        {
            try
            {
                db.tb_SYS_USER.Add(us);
                db.SaveChanges();
                return us;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi khi thêm"+ex.Message);
            }
        }
        public tb_SYS_USER update(tb_SYS_USER us)
        {
            var _us = db.tb_SYS_USER.FirstOrDefault(x=>x.IDUSER==us.IDUSER);
            _us.USERNAME= us.USERNAME;
            _us.FULLNAME= us.FULLNAME;
            _us.ISGROUP=us.ISGROUP;
            _us.DISABLED=us.DISABLED;
            _us.MACTY=us.MACTY;
            _us.MADVI = us.MADVI;
            _us.PASSWD = us.PASSWD;
            _us.LAST_PWD_CHANGED = DateTime.Now;
            try
            {
                
                db.SaveChanges();
                return us;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi khi thêm" + ex.Message);
            }
        }

    }
}
    


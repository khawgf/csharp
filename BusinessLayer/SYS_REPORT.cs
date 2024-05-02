using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class SYS_REPORT
    {
        Entities db;
        public SYS_REPORT() 
        {
            db = Entities.CreateEntities();
        }

        public tb_SYS_REPORT getitem(int repcode)
        {
            return db.tb_SYS_REPORT.FirstOrDefault(x=>x.REP_CODE == repcode);
        }

        public List<tb_SYS_REPORT> getlist()
        {
            return db.tb_SYS_REPORT.ToList();
        }
        public List<tb_SYS_REPORT> getlistbyright(List<tb_SYS_RIGHT_REP> lst)
        {
            List<int> rep = lst.Select(ls=>ls.REP_CODE).ToList();
            return db.tb_SYS_REPORT.Where(x=>rep.Contains(x.REP_CODE)).OrderBy(x=> x.REP_CODE).ToList();
        }

    }
}

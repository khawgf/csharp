using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer ;

namespace BusinessLayer
{
    public class VIEW_REP_SYS_RIGHT_REP
    {
        Entities db;
        public VIEW_REP_SYS_RIGHT_REP()
        {
            db= Entities.CreateEntities();
        }
        public List<V__REP_SYS_RIGHT_REP> getrep()
        {
            return db.V__REP_SYS_RIGHT_REP.ToList();
        }

        public List<V__REP_SYS_RIGHT_REP>getrepbyuser(int iduser)
        {
            return db.V__REP_SYS_RIGHT_REP.Where(x=>x.IDUSER == iduser).ToList();
        }
    }
}

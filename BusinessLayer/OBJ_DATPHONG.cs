using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_DATPHONG
    {
        //public int ID {  get; set; }
        //public string TENPHONG { get; set; }
        //public double DONGIA {  get; set; }
        //public bool STATUS { get; set; }
        //public int IDTANG {  get; set; }
        //public int IDLOAIPHONG { get; set; }
        //public bool DISABLED { get; set; }
        //public string TENTANG {  get; set; }
        //public string TENLOAIPHONG { get; set; }

        public int IDDP { set; get; }
        public int IDKH { set; get; }
        public string HOTEN { set; get; }
        public DateTime? NGAYDATPHONG { set; get; }
        public DateTime? NGAYTRAPHONG { set; get; }
        public double? SOTIEN { set; get; }
        public int? SONGUOIO { set; get; }
        public int? IDUSER { set; get; }
        public string MACTY {  set; get; }
        public string MADVI { set; get; }
        public bool? STATUS {  set; get; }
        public bool? THEODOAN {  set; get; }
        public bool? DISABLED {  set; get; }
        public string GHICHU {  set; get; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_PHONG
    {
        public int IDPHONG { set; get; }
        public string TENPHONG { set; get; }
        public bool? TRANGTHAI { set; get; }
        public int IDTANG { set; get; }
        public int IDLOAIPHONG { set; get; }
        public double? DONGIA {  set; get; }
        public bool? DISABLED { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace KHACHSAN.Mycontrols
{
    public partial class ucCongTy : UserControl
    {
        public ucCongTy()
        {
            InitializeComponent();
        }

        private void ucCongTy_Load(object sender, EventArgs e)
        {
            CONGTY _congty = new CONGTY();
            cbocongty.DataSource = _congty.getall();
            cbocongty.DisplayMember = "TENCTY";
            cbocongty.ValueMember = "MACTY";
            cbocongty.SelectedValue = myFunctions._macty;
        }
    }
}

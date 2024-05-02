using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHACHSAN.Mycontrols
{
    public partial class frmShowDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmShowDonVi()
        {
            InitializeComponent();
        }
        public frmShowDonVi( TextBox txtdonvi)
        {
            InitializeComponent();
            this._txtdonvi=txtdonvi;
        }
        TextBox _txtdonvi;
        DONVI _donvi;
        CONGTY _congty;
        private void frmShowDonVi_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            loadcongty();
            loaddonvi();
            cbocongty.SelectedIndexChanged += Cbocongty_SelectedIndexChanged;
            cbocongty.SelectedValue = myFunctions._macty;
        }

        private void Cbocongty_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddonvi();
        }
        void loadcongty()
        {
            cbocongty.DataSource = _congty.getall();
            cbocongty.DisplayMember = "TENCTY";
            cbocongty.ValueMember = "MACTY";
        }
        void loaddonvi()
        {
            gcdanhsach.DataSource = _donvi.getall(cbocongty.SelectedValue.ToString());
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void btnthuchien_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
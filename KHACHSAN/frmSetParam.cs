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

namespace KHACHSAN
{
    public partial class frmSetParam : DevExpress.XtraEditors.XtraForm
    {
        public frmSetParam()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        DONVI _donvi;

        private void frmSetParam_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            loadcongty();
            cbocongty.SelectedValue = "CT01";
            cbocongty.SelectedIndexChanged += Cbocongty_SelectedIndexChanged;
            loaddonvi();
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
            cbodonvi.DataSource = _donvi.getall(cbocongty.SelectedValue.ToString());
            cbodonvi.DisplayMember = "TENDVI";
            cbodonvi.ValueMember = "MADVI";
            cbodonvi.SelectedIndex = -1;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            string macty = cbocongty.SelectedValue.ToString();
            string madvi = (cbodonvi.Text.Trim() == "")?"~":cbodonvi.SelectedValue.ToString();
            SYS_PARAM _sysparam = new SYS_PARAM(macty, madvi);
            _sysparam.SaveFile();
            MessageBox.Show("successfully!","notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
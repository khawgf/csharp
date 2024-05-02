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
    public partial class ucDonVi : UserControl
    {
        public ucDonVi()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        DONVI _donvi;
        private void ucDonVi_Load(object sender, EventArgs e)
        {
            _congty= new CONGTY();
            _donvi= new DONVI();
            loadcongty();
            cbocongty.Enabled = false;
            cbocongty.SelectedValueChanged += Cbocongty_SelectedValueChanged;
            loaddonvi();
            if (myFunctions._madvi=="~")
            {
                cbodonvi.Enabled = true;
            }
            else
            {
                cbodonvi.SelectedValue = myFunctions._madvi;
                cbodonvi.Enabled = false;
            }
        }

        private void Cbocongty_SelectedValueChanged(object sender, EventArgs e)
        {
            loaddonvi();
        }

        void loadcongty()
        {
            cbocongty.DataSource= _congty.getall();
            cbocongty.DisplayMember = "TENCTY";
            cbocongty.ValueMember = "MACTY";
            cbocongty.SelectedValue = myFunctions._macty;
        }
        void loaddonvi()
        {
            cbodonvi.DataSource=_donvi.getall(cbocongty.SelectedValue.ToString());
            cbodonvi.DisplayMember = "TENDVI";
            cbodonvi.ValueMember = "MADVI";
        }

        private void cbocongty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

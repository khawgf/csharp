using BusinessLayer;
using DataLayer;
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

namespace USERMANAGEMENT
{
    public partial class frmShowMembers : DevExpress.XtraEditors.XtraForm
    {
        public frmShowMembers()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _idgroup;

        SYS_GROUP _sysgroup;
        VIEW_USER_NOTIN_GROUP _vNotgroup;
        frmGroup objGroup = (frmGroup)Application.OpenForms["frmGroup"];

        private void frmShowMembers_Load(object sender, EventArgs e)
        {
            _sysgroup = new SYS_GROUP();
            _vNotgroup = new VIEW_USER_NOTIN_GROUP();
            loadusernotingroup();
        }
        void loadusernotingroup()
        {
            gcThanhvien.DataSource = _vNotgroup.getusernotingroup(_madvi,_macty);
            gvthanhvien.OptionsBehavior.Editable = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            tb_SYS_GROUP gr = new tb_SYS_GROUP();
            gr.GROUP = _idgroup;
            gr.MEMBER = int.Parse(gvthanhvien.GetFocusedRowCellValue("IDUSER").ToString());
            _sysgroup.add(gr);
            objGroup.loaduseringroup(_idgroup);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
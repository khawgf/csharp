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
    public partial class frmShowGroup : DevExpress.XtraEditors.XtraForm
    {
        public frmShowGroup()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _iduser;

        SYS_GROUP _sysgroup;
        VIEW_USER_IN_GROUP _vuseringroup;

        frmUser objUser = (frmUser)Application.OpenForms["frmUser"];
        private void frmShowGroup_Load(object sender, EventArgs e)
        {
            _sysgroup = new SYS_GROUP();
            _vuseringroup = new VIEW_USER_IN_GROUP();
            loadgroup();
        }

        void loadgroup()
        {
            gcnhom.DataSource = _vuseringroup.getgroupbydonvi(_macty, _madvi);
            gvnhom.OptionsBehavior.Editable = false;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (_vuseringroup.checkgroupuser(_iduser,int.Parse(gvnhom.GetFocusedRowCellValue("IDUSER").ToString())))
            {
                MessageBox.Show("user đã tồn tại trong group.Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tb_SYS_GROUP gr = new tb_SYS_GROUP();
            gr.GROUP = int.Parse(gvnhom.GetFocusedRowCellValue("IDUSER").ToString());
            gr.MEMBER = _iduser;
            _sysgroup.add(gr);
            objUser.loadgroupbyuser(_iduser);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
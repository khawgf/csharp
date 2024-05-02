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
    public partial class frmGroup : DevExpress.XtraEditors.XtraForm
    {
        public frmGroup()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _iduser;
        public string _username;
        public string _fullname;

        public bool _them;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];

        SYS_USER _sysuser;
        SYS_GROUP _sysgroup;
        tb_SYS_USER _user;
        VIEW_USER_IN_GROUP _vuseringroup;
        private void frmGroup_Load(object sender, EventArgs e)
        {
            _sysuser = new SYS_USER();
            _sysgroup = new SYS_GROUP();
            if (!_them)
            {
                var user = _sysuser.getitem(_iduser);
                txttennhom.Text = user.USERNAME;
                _macty = user.MACTY;
                _madvi = user.MADVI;
                txtmota.Text = user.FULLNAME;
                txttennhom.ReadOnly = true;
                loaduseringroup(_iduser);
            }
            else
            {
                txtmota.Text = "";
                txttennhom.Text = "";
            }
                
            
        }
        public void loaduseringroup(int idgroup)
        {
            _vuseringroup = new VIEW_USER_IN_GROUP();
            gcThanhvien.DataSource=_vuseringroup.getuseringroup(_madvi,_macty,idgroup);
            gvthanhvien.OptionsBehavior.Editable = false;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txttennhom.Text.Trim()=="")
            {
                    MessageBox.Show("Chưa nhập tên nhóm. Tên nhóm nhập không dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttennhom.SelectAll();
                    txttennhom.Focus();
                    return;
                
            }

            savedata();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void savedata()
        {
            if (_them)
            {
               bool checkeduser= _sysuser.checkuserexist(_macty,_madvi,txttennhom.Text.Trim());
                if (checkeduser)
                {
                    MessageBox.Show("Nhóm đã tồn tại.Vui lòng kiểm tra lại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttennhom.SelectAll();
                    txttennhom.Focus();
                    return;
                }
                _user = new tb_SYS_USER();
                _user.USERNAME =txttennhom.Text.Trim();
                _user.FULLNAME = txtmota.Text;
                _user.ISGROUP = true;
                _user.DISABLED = false;
                _user.MACTY = _macty;
                _user.MADVI=_madvi;
                _sysuser.adđ(_user);
                


            }
            else
            {
                _user = _sysuser.getitem(_iduser);
                _user.FULLNAME=txtmota.Text;
                _sysuser.update(_user);
            }
            objMain.loaduser(_macty, _madvi);
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmShowMembers frm = new frmShowMembers();
            frm._idgroup = _iduser;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void btnbot_Click(object sender, EventArgs e)
        {
            if (gvthanhvien.GetFocusedRowCellValue("IDUSER")!=null)
            {
                _sysgroup.delGroup(int.Parse(gvthanhvien.GetFocusedRowCellValue("IDUSER").ToString()), _iduser);
                loaduseringroup(_iduser);
            }
        }
    }
}
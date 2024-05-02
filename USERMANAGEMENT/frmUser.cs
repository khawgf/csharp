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
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public frmUser()
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
        tb_SYS_USER _user;
        SYS_GROUP _sysgroup;
        VIEW_USER_IN_GROUP _vuseringroup;
        private void frmUser_Load(object sender, EventArgs e)
        {
            _sysuser = new SYS_USER();
            _sysgroup = new SYS_GROUP();
            if (!_them)
            {
                var user = _sysuser.getitem(_iduser);
                txtusername.Text = user.USERNAME;
                _macty = user.MACTY;
                _madvi = user.MADVI;
                txthoten.Text = user.FULLNAME;
                chkdisabled.Checked = user.DISABLED.Value;
                txtusername.ReadOnly = true;
                txtpass.Text = Encryptor.Decrypt(user.PASSWD, "fsfuoufsd8935@!", true);
                txtrepass.Text = Encryptor.Decrypt(user.PASSWD, "fsfuoufsd8935@!", true);
                loadgroupbyuser(_iduser);
            }
            else
            {
                txthoten.Text = "";
                txtpass.Text = "";
                txtrepass.Text = "";
                chkdisabled.Checked = false;
            }
        }

        public void loadgroupbyuser(int iduser)
        {
            _vuseringroup = new VIEW_USER_IN_GROUP();
            gcThanhvien.DataSource=_vuseringroup.getgroupbyuser(_macty,_madvi,iduser);
            gvthanhvien.OptionsBehavior.Editable = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (txtusername.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên user. Tên nhóm nhập không dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.SelectAll();
                txtusername.Focus();
                return;

            }
            if (!txtpass.Text.Equals(txtrepass.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.SelectAll();
                txtusername.Focus();
                return;

            }

            savedata();
        }
        void savedata()
        {
            if (_them)
            {
                bool checkeduser = _sysuser.checkuserexist(_macty, _madvi, txtusername.Text.Trim());
                if (checkeduser)
                {
                    MessageBox.Show("user đã tồn tại.Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusername.SelectAll();
                    txtusername.Focus();
                    return;
                }
                _user = new tb_SYS_USER();
                _user.USERNAME = txtusername.Text.Trim();
                _user.FULLNAME = txthoten.Text;
                _user.PASSWD = Encryptor.Encrypt(txtpass.Text.Trim(),"fsfuoufsd8935@!", true);
                _user.ISGROUP = false;
                _user.DISABLED = false;
                _user.MACTY = _macty;
                _user.MADVI = _madvi;
                _sysuser.adđ(_user);



            }
            else
            {
                _user = _sysuser.getitem(_iduser);
                _user.FULLNAME = txthoten.Text;
                _user.PASSWD = Encryptor.Encrypt(txtpass.Text.Trim(), "fsfuoufsd8935@!", true);
                _user.ISGROUP = false;
                _user.DISABLED = chkdisabled.Checked;
                _user.MACTY = _macty;
                _user.MADVI = _madvi;
                _sysuser.update(_user);
            }
            objMain.loaduser(_macty, _madvi);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmShowGroup frm = new frmShowGroup();
            frm._iduser = _iduser;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void btnbot_Click(object sender, EventArgs e)
        {
            _sysgroup.delGroup(_iduser,int.Parse(gvthanhvien.GetFocusedRowCellValue("IDUSER").ToString()));
            loadgroupbyuser(_iduser);
        }
    }
}
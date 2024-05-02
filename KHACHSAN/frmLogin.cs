using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHACHSAN
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SYS_PARAM _sysparam;
        SYS_USER _sysuser;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim()=="")
            {
                MessageBox.Show("username trống!!!", "notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool us = _sysuser.checkuserexist(_sysparam.macty,_sysparam.madvi,txtusername.Text.Trim());
            if (!us)
            {
                MessageBox.Show("username không tồn tại !!!" , "notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string pass = Encryptor.Encrypt(txtpass.Text, "fsfuoufsd8935@!", true);
            tb_SYS_USER user = _sysuser.getitem(txtusername.Text.Trim(),_sysparam.macty, _sysparam.madvi );
            if (user.PASSWD.Equals(pass))
            {
                frmMain frm = new frmMain(user);
                frm.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("password không chính xác !!!", "notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _sysuser = new SYS_USER();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("sysparam.ini", FileMode.Open, FileAccess.Read);
            _sysparam = (SYS_PARAM)bf.Deserialize(fs);
            fs.Close();
            myFunctions._macty = _sysparam.macty;
            myFunctions._madvi = _sysparam.madvi;
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkButton1.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }
}
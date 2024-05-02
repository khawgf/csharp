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
using DataLayer;

namespace KHACHSAN
{
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        public frmCongTy(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right= right;
        }

        CONGTY _congty;
        tb_SYS_USER _user;
        int _right;
        bool _them;
        string _macty;
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _congty= new CONGTY();
            loaddata();
            _enabled(false);
            showhidecontrol(true);
            txtMa.Enabled = false;
        }

        void showhidecontrol(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible= !t;
        }

        void _enabled(bool t)
        {
            txtMa.Enabled = t;
            txtTen.Enabled = t;
            txtEmail.Enabled = t;
            txtDienThoai.Enabled = t;
            txtDiaChi.Enabled= t;
            txtFax.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void _reset()
        {
            txtMa.Text = " ";
            txtTen.Text = " ";
            txtDiaChi.Text = " ";
            txtDienThoai.Text = " ";
            txtFax.Text = " ";
            txtEmail.Text = " ";
            chkDisabled.Checked = false;
        }
        void loaddata()
        {
            gcDanhSach.DataSource = _congty.getall();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_right ==1)
            {
                MessageBox.Show("Chỉ Xem ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            _them = true;
            _enabled(true);
            _reset();
            txtMa.Enabled = true;
            showhidecontrol(false);
           

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Chỉ Xem ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            _them = false;
            _enabled(true);
            txtMa.Enabled=false;
            showhidecontrol(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Chỉ Xem ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _congty.delete(_macty);
            }
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (_them)
                {
                    tb_cty cty = new tb_cty();
                    cty.MACTY = txtMa.Text;
                    cty.TENCTY = txtTen.Text;
                    cty.DIACHI = txtDiaChi.Text;
                    cty.DIENTHOAI = txtDienThoai.Text;
                    cty.FAX = txtFax.Text;
                    cty.EMAIL = txtEmail.Text;
                    cty.DISABLED = chkDisabled.Checked;
                    _congty.add(cty);
                }
                else
                {
                    tb_cty cty = _congty.getitem(_macty);
                    cty.TENCTY = txtTen.Text;
                    cty.DIACHI = txtDiaChi.Text;
                    cty.DIENTHOAI = txtDienThoai.Text;
                    cty.FAX = txtFax.Text;
                    cty.EMAIL = txtEmail.Text;
                    cty.DISABLED = chkDisabled.Checked;
                    _congty.update(cty);
                }
                _them = false;
                loaddata();
                _enabled(false);
                showhidecontrol(true);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại các trường nhập liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể thêm mã xử lý khác ở đây nếu cần
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể thêm mã xử lý khác ở đây nếu cần
            }

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enabled(false);
            showhidecontrol(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount>0)
            {
                _macty = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                chkDisabled.Checked=bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if ((e.Column.Name == "DISABLED" && bool.Parse(e.CellValue.ToString()) == true))
            {
                Image img = Properties.Resources.kha_567;
                int newWidth = 16; // Đặt chiều rộng mới
                int newHeight = 16; // Đặt chiều cao mới
                int x = e.Bounds.X + (e.Bounds.Width - newWidth) / 2; // Canh lề giữa theo chiều ngang
                int y = e.Bounds.Y + (e.Bounds.Height - newHeight) / 2; // Canh lề giữa theo chiều dọc
                e.Graphics.DrawImage(img, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        
    }
}
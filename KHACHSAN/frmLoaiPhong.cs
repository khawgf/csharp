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

namespace KHACHSAN
{
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        public frmLoaiPhong(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_USER _user;
        int _right;
        LOAIPHONG _loaiphong;
        bool _them;
        int _idloaiphong;


        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            _loaiphong = new LOAIPHONG();
            loaddata();
            _enabled(false);
            showhidecontrol(true);
        }
        void showhidecontrol(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;
        }

        void _enabled(bool t)
        {
            txtTen.Enabled = t;
            txtDonGia.Enabled = t;
            txtsogiuong.Enabled = t;
            txtsonguoi.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void _reset()
        {
            txtTen.Text = " ";
            txtsonguoi.Text = " ";
            txtsogiuong.Text = " ";
            txtDonGia.Text = " ";
            chkDisabled.Checked = false;
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _loaiphong.getall();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Chỉ Xem ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }

            _them = true;
            _enabled(true);
            _reset();
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
            showhidecontrol(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Chỉ Xem ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _loaiphong.delete(_idloaiphong);
            }
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (_them)
                {
                    tb_LoaiPhong loaiphong = new tb_LoaiPhong();
                    loaiphong.TENLOAIPHONG = txtTen.Text;
                    loaiphong.DONGIA = float.Parse(txtDonGia.Text);
                    loaiphong.SOGIUONG = int.Parse(txtsogiuong.Text);
                    loaiphong.SONGUOI = int.Parse(txtsonguoi.Text);
                    loaiphong.DISABLED = chkDisabled.Checked;
                    _loaiphong.add(loaiphong);
                }
                else
                {
                    tb_LoaiPhong loaiphong = _loaiphong.getitem(_idloaiphong);
                    loaiphong.TENLOAIPHONG = txtTen.Text;
                    loaiphong.DONGIA = float.Parse(txtDonGia.Text);
                    loaiphong.SOGIUONG = int.Parse(txtsogiuong.Text);
                    loaiphong.SONGUOI = int.Parse(txtsonguoi.Text);
                    loaiphong.DISABLED = chkDisabled.Checked;
                    _loaiphong.update(loaiphong);
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

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idloaiphong = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG").ToString());
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
                txtDonGia.Text = gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString();
                txtsonguoi.Text = gvDanhSach.GetFocusedRowCellValue("SONGUOI").ToString();
                txtsogiuong.Text = gvDanhSach.GetFocusedRowCellValue("SOGIUONG").ToString();
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }
    }
}
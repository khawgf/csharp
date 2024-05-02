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
using BusinessLayer;


namespace KHACHSAN
{
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmPhong()
        {
            InitializeComponent();
        }
        public frmPhong(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        tb_SYS_USER _user;
        int _right;
        PHONG _phong;
        LOAIPHONG _loaiphong;
        TANG _tang;
        bool _them;
        int _idphong;
        bool formLoaded = false;

        private void frmPhong_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            _tang = new TANG();
            _loaiphong = new LOAIPHONG();
            loadtang();
            loaddata();
            loadloaiphong();
            
            showhidecontrol(true);
            _enabled(false);
            //cboLoaiPhong.SelectedIndexChanged += CboLoaiPhong_SelectedIndexChanged;
            cboTang.SelectedIndexChanged += CboTang_SelectedIndexChanged;
            formLoaded = true; // Đánh dấu rằng form đã được tải hoàn toàn
            loaddvibytang();
            
        }

        private void CboTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded) // Chỉ gọi loaddvibycty khi form đã được tải hoàn toàn
            {
                loaddvibytang();
            }
        }

        private void CboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded) // Chỉ gọi loaddvibycty khi form đã được tải hoàn toàn
            {
                loaddvibyloaiphong();
            }
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
            chkTrangthai.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void _reset()
        {
            txtTen.Text = " ";
            chkTrangthai.Checked= false;
            chkDisabled.Checked = false;
        }

        void loaddvibytang()
        {
            if (cboTang.SelectedValue != null)
            {
                gcDanhSach.DataSource = _phong.getAll(int.Parse(cboTang.SelectedValue.ToString()));
                gvDanhSach.OptionsBehavior.Editable = false;
            }
        }

        void loaddvibyloaiphong()
        {
            if (cboLoaiPhong.SelectedValue != null)
            {
                gcDanhSach.DataSource = _phong.getAll1(int.Parse(cboLoaiPhong.SelectedValue.ToString()));
                gvDanhSach.OptionsBehavior.Editable = false;
            }
        }
        void loadtang()
        {
            cboTang.DataSource = _tang.getall();
            cboTang.DisplayMember = "TENTANG";
            cboTang.ValueMember = "IDTANG";
        }

        void loadloaiphong()
        {
            cboLoaiPhong.DataSource = _loaiphong.getall();
            cboLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cboLoaiPhong.ValueMember = "IDLOAIPHONG";
        }
        void loaddata()
        {
            gcDanhSach.DataSource = _phong.getAll();
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
             chkTrangthai.Enabled = false;
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
            chkTrangthai.Enabled = false;
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
                _phong.delete(_idphong);
            }
            objMain.gControl.Gallery.Groups.Clear();
            objMain.showRoom();
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (_them)
                {
                    tb_Phong phong = new tb_Phong();
                    phong.IDLOAIPHONG = int.Parse(cboLoaiPhong.SelectedValue.ToString());
                    phong.IDTANG = int.Parse(cboTang.SelectedValue.ToString());
                    phong.TRANGTHAI = chkTrangthai.Checked;
                    phong.TENPHONG = txtTen.Text;
                    phong.DISABLED = chkDisabled.Checked;
                    _phong.add(phong);
                }
                else
                {
                    tb_Phong phong = _phong.getitem(_idphong);
                    phong.IDLOAIPHONG = int.Parse(cboLoaiPhong.SelectedValue.ToString());
                    phong.IDTANG = int.Parse(cboTang.SelectedValue.ToString());
                    phong.TRANGTHAI = chkTrangthai.Checked;
                    phong.TENPHONG = txtTen.Text;
                    phong.DISABLED = chkDisabled.Checked;
                    _phong.update(phong);
                }
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
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
            else if ((e.Column.Name == "TRANGTHAI" && bool.Parse(e.CellValue.ToString()) == true))
            {
                Image img = Properties.Resources.KHA11;
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
                _idphong = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString());
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENPHONG").ToString();
                cboLoaiPhong.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG");
                chkTrangthai.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            gcDanhSach.DataSource = _phong.getbyTangVaLoaiPhong(int.Parse(cboTang.SelectedValue.ToString()), int.Parse(cboLoaiPhong.SelectedValue.ToString()));
            gvDanhSach.OptionsBehavior.Editable = false;
        }
    }
}
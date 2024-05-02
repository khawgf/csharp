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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public frmKhachHang(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_USER _user;
        int _right;
        frmDatPhong objDP =(frmDatPhong)Application.OpenForms["frmDatPhong"];
        frmDatPhongDon objDPDon = (frmDatPhongDon)Application.OpenForms["frmDatPhongDon"];
        KHACHHANG _kh;
        bool _them;
        int _idkh;
        public string kh_dp;

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _kh = new KHACHHANG();
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
            txtEmail.Enabled = t;
            txtDienThoai.Enabled = t;
            txtDiaChi.Enabled = t;
            txtCCCD.Enabled = t;

        }

        void _reset()
        {
            txtTen.Text = " ";
            txtDiaChi.Text = " ";
            txtDienThoai.Text = " ";
            txtCCCD.Text = " ";
            txtEmail.Text = " ";
        }
        void loaddata()
        {
            gcDanhSach.DataSource = _kh.getall();
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
                _kh.delete(_idkh);
            }
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_them)
                {
                    tb_KhachHang kh = new tb_KhachHang();
                    kh.HOTEN = txtTen.Text;
                    kh.DIACHI = txtDiaChi.Text;
                    kh.DIENTHOAI = txtDienThoai.Text;
                    kh.CCCD = txtCCCD.Text;
                    kh.EMAIL = txtEmail.Text;
                    _kh.add(kh);
                }
                else
                {
                    tb_KhachHang kh = _kh.getitem(_idkh);
                    kh.HOTEN = txtTen.Text;
                    kh.DIACHI = txtDiaChi.Text;
                    kh.DIENTHOAI = txtDienThoai.Text;
                    kh.CCCD = txtCCCD.Text;
                    kh.EMAIL = txtEmail.Text;
                    _kh.update(kh);
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

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idkh = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("HOTEN").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtCCCD.Text = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
            }
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (gvDanhSach.GetFocusedRowCellValue("IDKH") != null)
            {
                if (kh_dp == "datphongdon")
                {
                    objDPDon.loadkh();
                    objDPDon.setKH(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
                }
                else
                {
                    objDP.loadKH();
                    objDP.setKhacHang(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
                }
               
                this.Close();
            }
        }
    }
}
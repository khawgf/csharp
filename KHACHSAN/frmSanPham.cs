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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        public frmSanPham(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        SANPHAM _sp;
        bool _them;
        int _idsp;
        tb_SYS_USER _user;
        int _right;

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            _sp = new SANPHAM();
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
            txtDongia.Enabled = t;
        }

        void _reset()
        {
            txtTen.Text = " ";
            txtDongia.Text = " ";
           
        }
        void loaddata()
        {
            gcDanhSach.DataSource = _sp.getall();
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
                _sp.delete(_idsp);
            }
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_them)
                {
                    tb_SanPham sp = new tb_SanPham();
                    sp.TENSP = txtTen.Text;
                    sp.DONGIA = float.Parse(txtDongia.Text);
                    _sp.add(sp);
                }
                else
                {
                    tb_SanPham sp = _sp.getitem(_idsp);
                    sp.TENSP = txtTen.Text;
                    sp.DONGIA = float.Parse(txtDongia.Text);
                    _sp.update(sp);
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
                _idsp = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDSP").ToString());
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENSP").ToString();
                txtDongia.Text = gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString();
            }
        }
    }
}
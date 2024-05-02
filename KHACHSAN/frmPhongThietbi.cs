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
    public partial class frmPhongThietbi : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongThietbi()
        {
            InitializeComponent();
        }
        public frmPhongThietbi(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_USER _user;
        int _right;
        PHONG_THIETBI _ptb;
        PHONG _p;
        THIETBI _tb;
        bool _them;
        int _idp;
        int _idtb;
        bool formLoaded = false;
        private void frmPhongThietbi_Load(object sender, EventArgs e)
        {
            _ptb = new PHONG_THIETBI();
            _p = new PHONG();
            _tb = new THIETBI();
            
            loadPhong();
            loadthietbi();
            loaddata();
            showhidecontrol(true);
            _enabled(false);
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
            cboPhong.Enabled = t;
            cboThietbi.Enabled = t;
            nsoluong.Enabled = t;
        }

        void _reset()
        {
        }
        void loadPhong()
        {
            cboPhong.DataSource = _p.getAll();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "IDPHONG";
        }
        void loadthietbi()
        {
            cboThietbi.DataSource = _tb.getall();
            cboThietbi.DisplayMember = "TENTB";
            cboThietbi.ValueMember = "IDTB";
        }
        void loaddata()
        {
            gcDanhSach.DataSource = _ptb.getall();
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
                _ptb.delete(_idp, _idtb);
            }
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (_them)
                {
                    tb_Phong_ThietBi ptb = new tb_Phong_ThietBi();
                    ptb.IDPHONG = int.Parse(cboPhong.SelectedValue.ToString());
                    ptb.IDTB = int.Parse(cboThietbi.SelectedValue.ToString());
                    ptb.SOLUONG = (int)nsoluong.Value;
                    _ptb.add(ptb);
                }
                else
                {
                    tb_Phong_ThietBi ptb = _ptb.getitem(_idp, _idtb);
                    ptb.SOLUONG = (int)nsoluong.Value;
                    _ptb.update(ptb);
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
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại sau.+ex", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                _idp = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString());
                _idtb = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTB").ToString());
                cboPhong.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDPHONG");

                cboThietbi.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDTB");
                nsoluong.Value = decimal.Parse(gvDanhSach.GetFocusedRowCellValue("SOLUONG").ToString());

            }
        }
    }
}
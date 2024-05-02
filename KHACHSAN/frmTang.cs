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
using BusinessLayer;
using DataLayer;

namespace KHACHSAN
{
    public partial class frmTang : DevExpress.XtraEditors.XtraForm
    {
        public frmTang()
        {
            InitializeComponent();
        }
        public frmTang(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        TANG _tang;

        tb_SYS_USER _user;
        int _right;
        bool _them;
        int _idtang;
        private void frmTang_Load(object sender, EventArgs e)
        {
            _tang = new TANG();
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
            chkDisabled.Enabled = t;
        }

        void _reset()
        {
          
            txtTen.Text = " ";
            chkDisabled.Checked = false;
        }
        void loaddata()
        {
            gcDanhSach.DataSource = _tang.getall();
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
                _tang.delete(_idtang);
            }
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (_them)
                {
                    tb_Tang tang = new tb_Tang();
                    //tang.IDTANG = int.Parse(txtMa.Text);
                    tang.TENTANG = txtTen.Text;
                    tang.DISABLED = chkDisabled.Checked;
                    _tang.add(tang);
                }
                else
                {
                    tb_Tang tang = _tang.getitem(_idtang);
                    tang.TENTANG = txtTen.Text;
                    tang.DISABLED = chkDisabled.Checked;
                    _tang.update(tang);
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
                _idtang = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTANG").ToString());
                
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTANG").ToString();
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }
    }
}
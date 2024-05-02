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
    public partial class frmChuyenPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        public int _idphong;
        PHONG _phong;
        DATPHONG_CHITIET _datphongct;
        DATPHONG_SANPHAM _datphongsp;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            _datphongct = new DATPHONG_CHITIET();
            _datphongsp = new DATPHONG_SANPHAM();
            var p = _phong.getitemfull(_idphong);
            lblPhong.Text = p.TENPHONG + " - Đơn giá: " + p.DONGIA.ToString();
            loadphongtrong();
        }
        void loadphongtrong()
        {
            searchPhong.Properties.DataSource = _phong.getphongtrongfull();
            searchPhong.Properties.ValueMember = "IDPHONG";
            searchPhong.Properties.DisplayMember = "TENPHONG";

        }

        private void btnchuyenphong_Click(object sender, EventArgs e)
        {
            if (searchPhong.EditValue==null|| searchPhong.EditValue.ToString()=="")
            {
                MessageBox.Show("Vui lòng chọn phòng muốn chuyển đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            var _phonghientai = _datphongct.getIDDPbyPhog(_idphong);
            var _phongchuyenden = _phong.getitemfull(int.Parse(searchPhong.EditValue.ToString()));

            List<tb_DatPhong_SanPham> lstDPSP = _datphongsp.getallbyphong(_phonghientai.IDDP,_phonghientai.IDDPCT);
            foreach (var item in lstDPSP)
            {
                item.IDPHONG = int.Parse(searchPhong.EditValue.ToString());
                _datphongsp.update(item);
            }
            var dpct = _datphongct.getItem(_phonghientai.IDDP,_idphong);
            dpct.IDPHONG = _phongchuyenden.IDPHONG;
            dpct.DONGIA = int.Parse( _phongchuyenden.DONGIA.ToString());
            dpct.THANHTIEN=dpct.SONGAYO* int.Parse(_phongchuyenden.DONGIA.ToString());
            _datphongct.update(dpct);
            _phong.updateStatus(_idphong, false);
            _phong.updateStatus(_phongchuyenden.IDPHONG, true);
             objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
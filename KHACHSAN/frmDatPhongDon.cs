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
using static DevExpress.XtraPrinting.Export.Pdf.PdfImageCache;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument;

namespace KHACHSAN
{
    public partial class frmDatPhongDon : DevExpress.XtraEditors.XtraForm
    {
        public frmDatPhongDon()
        {
            InitializeComponent();
        }
        public bool _them;
        public int _idphong;
        int _idDP=0;
        string _macty;
        string _madvi;
        int songay = 1;

        DATPHONG _datphong;
        DATPHONG_CHITIET _datphongct;
        DATPHONG_SANPHAM _datphongsp;
        OBJ_PHONG _phonghientai;
        PHONG _phong;
        SANPHAM _sanpham;
        KHACHHANG _khachhang;
        SYS_PARAM _param;
           frmMain objMain = (frmMain)Application.OpenForms["frmMain"];

        List<OBJ_DPSP> listDPSP;



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (searchKH.EditValue==null ||searchKH.EditValue.ToString()=="")
            {
                MessageBox.Show("Vui long chon khach hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            savedata();
            objMain.gControl.Gallery.Groups.Clear();
            objMain.showRoom();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            xuatreport("Phiếu đặt phòng đơn chi tiết");
        }
        void xuatreport(string _tieude)
        {
            if (_idDP != 0) // Check if the _idDP is not null
            {
                // Create a new Form and CrystalReportViewer
                Form frm = new Form();
                CrystalReportViewer Crv = new CrystalReportViewer();
                Crv.ShowGroupTreeButton = false;
                Crv.ShowParameterPanelButton = false;
                Crv.ToolPanelView = ToolPanelViewType.None;

                TableLogOnInfo Thongtin;

                // Create a new ReportDocument
                ReportDocument doc = new ReportDocument();
                // Load the report file from the application's startup path
                doc.Load("D:\\DACN\\doan\\QUANLYKHACHSAN\\KHACHSAN\\PHIEU_DATPHONG1.rpt");

                // Set up the database connection information
                Thongtin = doc.Database.Tables[0].LogOnInfo;
                Thongtin.ConnectionInfo.ServerName = ".";
                Thongtin.ConnectionInfo.DatabaseName = "QLKS";
                Thongtin.ConnectionInfo.UserID = "sa";
                Thongtin.ConnectionInfo.Password = "123";

                // Apply the connection information
                doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
                try
                {
                    doc.SetParameterValue("@IDDP", _idDP.ToString()); // Set a parameter value in the report
                    Crv.Dock = DockStyle.Fill;
                    Crv.ReportSource = doc;
                    frm.Controls.Add(Crv);
                    Crv.Refresh();
                    frm.Text = _tieude; // Set the title of the Form
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog(); // Show the Form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi : " + ex.ToString()); // Handle and display any exceptions
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message if _idDP is null
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatPhongDon_Load(object sender, EventArgs e)
        {
            _datphong = new DATPHONG();
            _datphongct = new DATPHONG_CHITIET();
            _datphongsp = new DATPHONG_SANPHAM();
            _phong = new PHONG();
           
            _sanpham = new SANPHAM();
            listDPSP = new List<OBJ_DPSP>();
           

           
            _macty = myFunctions._macty;
            _madvi = myFunctions._madvi;
            dtNgayDat.Enabled = false;

            _phonghientai = _phong.getitemfull(_idphong);
            lblPhong.Text = _phonghientai.TENPHONG + " - Đơn giá : "+_phonghientai.DONGIA.ToString()+"VNĐ";

            dtNgayDat.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);

            cboTrangThai.DataSource = TRANGTHAI.getlist();
            cboTrangThai.ValueMember = "_value";
            cboTrangThai.DisplayMember = "_display";
            spSoNguoi.Value = 1;
            txtTongTien.Text = "0";

           loadkh();
            loadsp();
            var dpct = _datphongct.getIDDPbyPhog(_idphong);
            if (!_them && dpct!=null)
            {
                _idDP = dpct.IDDP;
                var dp = _datphong.getitem(_idDP);
                searchKH.EditValue= dp.IDKH;
                dtNgayDat.Value = dp.NGAYDATPHONG.Value;
                dtNgayTra.Value = dp.NGAYTRAPHONG.Value;
                cboTrangThai.SelectedValue = dp.STATUS;
                spSoNguoi.Value = int.Parse(dp.SONGUOIO.ToString());
                txtGhiChu.Text= dp.GHICHU.ToString();
                txtTongTien.Text = dp.SOTIEN.Value.ToString("N0");
            }
            loadSPDV();
           
        }

        void loadSPDV()
        {
            gcSPDV.DataSource = _datphongsp.getallbydatphong(_idDP);
            listDPSP = _datphongsp.getallbydatphong(_idDP);
        }

        public void loadsp()
        {
            gcSanPham.DataSource = _sanpham.getall();
            gvSanPham.OptionsBehavior.Editable = false;
        }
        public void loadkh()
        {
            KHACHHANG _khachhang = new KHACHHANG();
            searchKH.Properties.DataSource = _khachhang.getall();
            searchKH.Properties.ValueMember = "IDKH";
            searchKH.Properties.DisplayMember = "HOTEN";
        }
        public void setKH(int idKH)
        {
            searchKH.EditValue = idKH;
        }
        private void btnAđdNew_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.kh_dp = "datphongdon";
            frm.ShowDialog();
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (_idphong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvSanPham.GetFocusedRowCellValue("IDSP") != null)
            {
                OBJ_DPSP sp = new OBJ_DPSP();
                sp.IDSP = int.Parse(gvSanPham.GetFocusedRowCellValue("IDSP").ToString());
                sp.TENSP = gvSanPham.GetFocusedRowCellValue("TENSP").ToString();
                sp.IDPHONG = _idphong;
                sp.TENPHONG = _phonghientai.TENPHONG;
                sp.DONGIA = float.Parse(gvSanPham.GetFocusedRowCellValue("DONGIA").ToString());
                sp.SOLUONG = 1;
                sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;

                foreach (var item in listDPSP)
                {
                    if (item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        loadDPSP();
                        UpdateTotalSummary(songay); // Cập nhật tổng tiền sau mỗi lần thay đổi
                        return;
                    }
                }

                listDPSP.Add(sp);
                loadDPSP();
                UpdateTotalSummary(songay); // Cập nhật tổng tiền sau mỗi lần thay đổi
            }
        }

        private void UpdateTotalSummary(int soNgay)
        {
            double tongTienSanPhamDichVu = double.Parse(listDPSP.Sum(item => item.THANHTIEN).ToString());
            double donGiaPhong = double.Parse(_phonghientai.DONGIA.ToString());
            double tongTienPhong = donGiaPhong * soNgay * 0.08 + donGiaPhong; // 0.08 để giảm giá 3%
            double tongTien = tongTienSanPhamDichVu + tongTienPhong;

            // Cập nhật giá trị tổng tiền
            txtTongTien.Text = tongTien.ToString();
        }
        void loadDPSP()
        {
            List<OBJ_DPSP> lsDP = new List<OBJ_DPSP>();
            foreach (var item in listDPSP)
            {
                lsDP.Add(item);
            }
            gcSPDV.DataSource = lsDP;
        }

        private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SOLUONG")
            {
                int s1 = int.Parse(e.Value.ToString());
                if (s1 != 0)
                {
                    double gia = double.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle, "DONGIA").ToString());
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", s1 * gia);
                }
                else
                {
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", 0);
                }
            }
            gvSPDV.UpdateTotalSummary();
            txtTongTien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phonghientai.DONGIA).ToString();
        }

        private void gvSPDV_HiddenEditor(object sender, EventArgs e)
        {
            gvSPDV.UpdateCurrentRow();
        }

        void savedata()
        {
            if (_them)
            {
                tb_DatPhong dp = new tb_DatPhong();
                tb_DatPhong_CT dpct;
                tb_DatPhong_SanPham dpsp;
                dp.NGAYDATPHONG = dtNgayDat.Value;
                dp.NGAYTRAPHONG = dtNgayTra.Value;
                dp.SONGUOIO = int.Parse(spSoNguoi.Value.ToString());
                dp.STATUS = bool.Parse(cboTrangThai.SelectedValue.ToString());
                dp.THEODOAN = false;
                dp.IDKH = int.Parse(searchKH.EditValue.ToString());
                dp.SOTIEN = double.Parse(txtTongTien.Text);
                dp.GHICHU = txtGhiChu.Text;
                dp.DISABLED = false;
                dp.IDUSER = 1;
                dp.MACTY = _macty;
                dp.MADVI = _madvi;
                dp.CREATED_DATE = DateTime.Now;
                var _dp = _datphong.add(dp);
                _idDP = _dp.IDDP;

                
                    dpct = new tb_DatPhong_CT();
                    dpct.IDDP = _dp.IDDP;
                    dpct.IDPHONG = _idphong;
                    dpct.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                    dpct.DONGIA = int.Parse(_phonghientai.DONGIA.ToString());
                    dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                    dpct.NGAY = DateTime.Now;

                    var _dpct = _datphongct.add(dpct);
                    _phong.updateStatus(int.Parse(dpct.IDPHONG.ToString()), true);
                    if (gvSPDV.RowCount > 0)
                    {
                        for (int j = 0; j < gvSPDV.RowCount; j++)
                        {
                            if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                            {
                                dpsp = new tb_DatPhong_SanPham();
                                dpsp.IDDP = _dp.IDDP;
                                dpsp.IDDPCT = _dpct.IDDPCT;
                                dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                                dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                                dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                                dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                                dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
                                dpsp.NGAY = DateTime.Now;
                                _datphongsp.add(dpsp);
                            }

                        }
                    }

                
            }
            else
            {
                tb_DatPhong dp = _datphong.getitem(_idDP);
                tb_DatPhong_CT dpct;
                tb_DatPhong_SanPham dpsp;
                dp.NGAYDATPHONG = dtNgayDat.Value;
                dp.NGAYTRAPHONG = dtNgayTra.Value;
                dp.SONGUOIO = int.Parse(spSoNguoi.Value.ToString());
                dp.STATUS = bool.Parse(cboTrangThai.SelectedValue.ToString());
                dp.IDKH = int.Parse(searchKH.EditValue.ToString());
                dp.SOTIEN = double.Parse(txtTongTien.Text);
                dp.GHICHU = txtGhiChu.Text;
                dp.IDUSER = 1;
                dp.UPDATE_BY = 1;
                dp.UPDATE_DATE = DateTime.Now;

                var _dp = _datphong.update(dp);
                _idDP = _dp.IDDP;
                _datphongct.deleteAll(_dp.IDDP);
                _datphongsp.deleteAll(_dp.IDDP);

                
                    dpct = new tb_DatPhong_CT();
                    dpct.IDDP = _dp.IDDP;
                    dpct.IDPHONG = _idphong;
                    dpct.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                    dpct.DONGIA = int.Parse(_phonghientai.DONGIA.ToString());
                    dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                    dpct.NGAY = DateTime.Now;
                    var _dpct = _datphongct.add(dpct);
                    _phong.updateStatus(dpct.IDPHONG, true);
                    if (gvSPDV.RowCount > 0)
                    {
                        for (int j = 0; j < gvSPDV.RowCount; j++)
                        {
                            if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                            {
                                dpsp = new tb_DatPhong_SanPham();
                                dpsp.IDDP = _dp.IDDP;
                                dpsp.IDDPCT = _dpct.IDDPCT;
                                dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                                dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                                dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                                dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                                dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
                                dpsp.NGAY = DateTime.Now;
                                _datphongsp.add(dpsp);
                            }

                        }
                    }

                
            }
        }

        private void gvSPDV_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                int selectedRowHandle = view.FocusedRowHandle;
                if (selectedRowHandle >= 0)
                {
                    // Xóa sản phẩm khỏi danh sách listDPSP
                    int idSP = int.Parse(view.GetRowCellValue(selectedRowHandle, "IDSP").ToString());
                    int idPhong = int.Parse(view.GetRowCellValue(selectedRowHandle, "IDPHONG").ToString());
                    var itemToRemove = listDPSP.FirstOrDefault(item => item.IDSP == idSP && item.IDPHONG == idPhong);
                    if (itemToRemove != null)
                    {
                        listDPSP.Remove(itemToRemove);
                    }

                    view.DeleteRow(selectedRowHandle);
                    UpdateTotalSummary(songay); // Cập nhật tổng tiền sau khi xóa sản phẩm
                }
            }
        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime ngayDat = dtNgayDat.Value;
            DateTime ngayTra = dtNgayTra.Value;
            if (ngayDat > ngayTra)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Tính số ngày giữa ngày đặt và ngày trả
                int sonNgay = (ngayTra - ngayDat).Days;
                // Sau đó, cập nhật tổng tiền
                UpdateTotalSummary(sonNgay);
            }
        }


        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void gvSanPham_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvSanPham.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSanPham); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSanPham); }));
            }
        }

        private void gvSPDV_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvSPDV.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSPDV); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSPDV); }));
            }
        }

        private void gvSanPham_DoubleClick_1(object sender, EventArgs e)
        {
            if (_idphong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvSanPham.GetFocusedRowCellValue("IDSP") != null)
            {
                OBJ_DPSP sp = new OBJ_DPSP();
                sp.IDSP = int.Parse(gvSanPham.GetFocusedRowCellValue("IDSP").ToString());
                sp.TENSP = gvSanPham.GetFocusedRowCellValue("TENSP").ToString();
                sp.IDPHONG = _idphong;
                sp.TENPHONG = _phonghientai.TENPHONG;
                sp.DONGIA = float.Parse(gvSanPham.GetFocusedRowCellValue("DONGIA").ToString());
                sp.SOLUONG = 1;
                sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;

                foreach (var item in listDPSP)
                {
                    if (item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        loadDPSP();
                        //UpdateTotalSummary(songay); // Cập nhật tổng tiền sau mỗi lần thay đổi
                        return;
                    }
                }

                listDPSP.Add(sp);
                loadDPSP();
                //UpdateTotalSummary(songay); // Cập nhật tổng tiền sau mỗi lần thay đổi
            }
        }
    }



    
}
using BusinessLayer;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument;


namespace KHACHSAN
{
    public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmDatPhong()
        {
            InitializeComponent();
            DataTable tb = myFunctions.laydulieu("SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, A.IDTANG, B.TENTANG FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C\r\nWHERE A.IDTANG=B.IDTANG AND A.TRANGTHAI=0 AND A.IDLOAIPHONG = C.IDLOAIPHONG");
            gcPhong.DataSource = tb;
            gcDatPhong.DataSource = tb.Clone();
 
        }
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        tb_SYS_USER _user;
        int _right;
        SYS_PARAM _param;
        DATPHONG _datphong;
        KHACHHANG _khachhang;
        SANPHAM _sanpham;
        DATPHONG_CHITIET _datphongchitiet;
        DATPHONG_SANPHAM _datphongsanpham;
        PHONG _phong;

        int songay = 1;
        int _rowDatPhong=0;
        string _macty;
        string _madvi;
        bool _them;
        int _idDP=0;
        GridHitInfo downHitInfor = null;
        int _idPhong;
        string _tenPhong;
        List<OBJ_DPSP> listDPSP;

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            _datphong = new DATPHONG();
            _khachhang = new KHACHHANG();
            _sanpham= new SANPHAM();
           
            _datphongchitiet = new DATPHONG_CHITIET();
            _datphongsanpham = new DATPHONG_SANPHAM();
            _phong = new PHONG();

            listDPSP = new List<OBJ_DPSP>();
            dtTuNgay.Value = myFunctions.GetFirstDayInMont(DateTime.Now.Year, DateTime.Now.Month);
            dtDenNgay.Value = DateTime.Now;


            _macty = myFunctions._macty;
            _madvi = myFunctions._madvi;

            loadKH();
            loadsp();
            loadDanhsach();
            cboTrangThai.DataSource = TRANGTHAI.getlist();
            cboTrangThai.ValueMember = "_value";
            cboTrangThai.DisplayMember = "_display";
            _enabled(false);
            showhidecontrol(true);
            gvPhong.ExpandAllGroups();
            tabDanhSach.SelectedTabPage = pageDanhSach;

        }

        public void loadDanhsach()
        {
            _datphong= new DATPHONG();
            gcDanhSach.DataSource = _datphong.getall(dtTuNgay.Value, dtDenNgay.Value,_macty,_madvi);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        public void loadKH()
        {
            _khachhang = new KHACHHANG();
            cboKhachHang.DataSource=_khachhang.getall();
            cboKhachHang.DisplayMember = "HOTEN";
            cboKhachHang.ValueMember = "IDKH";
        }
        void loadsp()
        {
            gcSanPham.DataSource = _sanpham.getlist();
            gvSanPham.OptionsBehavior.Editable=false;
        }
        void showhidecontrol(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;
            btnIn.Visible = t;
        }

        void _enabled(bool t)
        {
            cboKhachHang.Enabled = t;
            btnAđdNew.Enabled = t;
            dtNgayDat.Enabled = t;
            dtNgayTra.Enabled = t;
            cboTrangThai.Enabled = t;
            chkDoan.Enabled = t;
            spSoNguoi.Enabled = t;
            txtGhiChu.Enabled = t;
            gcPhong.Enabled = t;
            gcSanPham.Enabled = t;
            gcDatPhong.Enabled = t;
            gcSPDV.Enabled = t;
            txtTongTien.Enabled = t;
        }

        void _reset()
        {
            dtNgayDat.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);
            spSoNguoi.Value = 1;
            chkDoan.Checked = true;
            cboTrangThai.SelectedValue = false;
            txtGhiChu.Text = "";
            txtTongTien.Text = "0";
        }

        void addreset()
        {
            DataTable tb = myFunctions.laydulieu("SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, A.IDTANG, B.TENTANG FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C\r\nWHERE A.IDTANG=B.IDTANG AND A.TRANGTHAI=0 AND A.IDLOAIPHONG = C.IDLOAIPHONG");
            gcPhong.DataSource = tb;
            gcDatPhong.DataSource = tb.Clone();
            gvPhong.ExpandAllGroups();
            gcSPDV.DataSource = _datphongsanpham.getallbydatphong(0);
            txtTongTien.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            _them = true;
            _enabled(true);
            _reset();
            addreset();
            tabDanhSach.SelectedTabPage = pageChiTiet;
            showhidecontrol(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
         
            _them = false;
            showhidecontrol(false);
            _enabled(true);
            _reset();
           
            tabDanhSach.SelectedTabPage = pageChiTiet;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _datphong.delete(_idDP);
                var lstDPCT = _datphongchitiet.getallbydatphong(_idDP);
                foreach( var item in lstDPCT)
                {
                    _phong.updateStatus(item.IDPHONG, false);
                }

            }
            loadDanhsach();
             objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                savedata();
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
                _them = false;
                loadDanhsach();
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
                dp.THEODOAN = chkDoan.Checked;
                dp.IDKH = int.Parse(cboKhachHang.SelectedValue.ToString());
                dp.SOTIEN = double.Parse(txtTongTien.Text);
                dp.GHICHU = txtGhiChu.Text;
                dp.DISABLED = false;
                dp.IDUSER = 1;
                dp.MACTY = _macty;
                dp.MADVI = _madvi;
                dp.CREATED_DATE=DateTime.Now;
                var _dp =_datphong.add(dp);
                _idDP = _dp.IDDP;

                for (int i =0; i< gvDatPhong.RowCount; i++)
                {
                    dpct = new tb_DatPhong_CT();
                    dpct.IDDP = _dp.IDDP;
                    dpct.IDPHONG = int.Parse(gvDatPhong.GetRowCellValue(i,"IDPHONG").ToString());
                    dpct.SONGAYO=dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                    dpct.DONGIA= int.Parse(gvDatPhong.GetRowCellValue(i,"DONGIA").ToString());
                    dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                    dpct.NGAY = DateTime.Now;
                    
                    var _dpct = _datphongchitiet.add(dpct);
                    _phong.updateStatus(int.Parse(dpct.IDPHONG.ToString()), true);
                    if (gvSPDV.RowCount > 0)
                    {
                        for (int j = 0; j < gvSPDV.RowCount; j++)
                        {
                            if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                            {
                                dpsp = new tb_DatPhong_SanPham();
                                dpsp.IDDP= _dp.IDDP;
                                dpsp.IDDPCT = _dpct.IDDPCT;
                                dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                                dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                                dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                                dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                                dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
                                dpsp.NGAY = DateTime.Now;
                                _datphongsanpham.add(dpsp);
                            }
                           
                        }
                    }
                   
                }
            }
            else
            {
                tb_DatPhong dp= _datphong.getitem(_idDP);
                tb_DatPhong_CT dpct;
                tb_DatPhong_SanPham dpsp;
                dp.NGAYDATPHONG = dtNgayDat.Value;
                dp.NGAYTRAPHONG = dtNgayTra.Value;
                dp.SONGUOIO = int.Parse(spSoNguoi.Value.ToString());
                dp.STATUS = bool.Parse(cboTrangThai.SelectedValue.ToString());
                dp.IDKH = int.Parse(cboKhachHang.SelectedValue.ToString());
                dp.SOTIEN = double.Parse(txtTongTien.Text);
                dp.GHICHU = txtGhiChu.Text;
                dp.IDUSER = 1;
                dp.UPDATE_BY = 1;
                dp.UPDATE_DATE = DateTime.Now;
    
                var _dp = _datphong.update(dp);
                _idDP = _dp.IDDP;
                _datphongchitiet.deleteAll(_dp.IDDP);
                _datphongsanpham.deleteAll(_dp.IDDP);

                for (int i = 0; i < gvDatPhong.RowCount; i++)
                {
                    dpct = new tb_DatPhong_CT();
                    dpct.IDDP = _dp.IDDP;
                    dpct.IDPHONG = int.Parse(gvDatPhong.GetRowCellValue(i, "IDPHONG").ToString());
                    dpct.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                    dpct.DONGIA = int.Parse(gvDatPhong.GetRowCellValue(i, "DONGIA").ToString());
                    dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                    dpct.NGAY = DateTime.Now;
                    var _dpct=_datphongchitiet.add(dpct);
                    _phong.updateStatus(dpct.IDPHONG, true);
                    if (gvSPDV.RowCount > 0)
                    {
                        for (int j = 0; j < gvSPDV.RowCount; j++)
                        {
                            if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                            {
                                dpsp = new tb_DatPhong_SanPham();
                                dpsp.IDDP = _dp.IDDP;
                                dpsp.IDDPCT=_dpct.IDDPCT;
                                dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                                dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                                dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                                dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                                dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
                                dpsp.NGAY = DateTime.Now;
                                _datphongsanpham.add(dpsp);
                            }
                   
                        }
                    }
                  
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enabled(false);
            showhidecontrol(true);
            tabDanhSach.SelectedTabPage = pageDanhSach;

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            xuatreport("Phiếu đặt phòng chi tiết");
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

        private void gvDatPhong_MouseDown(object sender, MouseEventArgs e)
        {
            if (gvDatPhong.GetFocusedRowCellValue("IDPHONG") != null)
            {
                _idPhong = int.Parse(gvDatPhong.GetFocusedRowCellValue("IDPHONG").ToString());
                _tenPhong = gvDatPhong.GetFocusedRowCellValue("TENPHONG").ToString();
            }
            GridView view = sender as GridView;
            downHitInfor = null;
            GridHitInfo hitInfor = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if(e.Button == MouseButtons.Left && hitInfor.RowHandle >= 0)
            {
                downHitInfor = hitInfor;
            }
        }

        private void gvDatPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfor!= null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);
                if  (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfor.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfor = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                    

                }
            }
        }

        private void gvPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if(e.Button == MouseButtons.Left && downHitInfor!=null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfor.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfor = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;

                }
            }
        }

        private void gvPhong_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfor = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfor = hitInfo;
            }
        }

        private void gcPhong_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row= e.Data.GetData(typeof(DataRow)) as DataRow;
            if( row!=null && table!=null&& row.Table!=table)
            {
                table.ImportRow(row);
                row.Delete();
            }
        }

        private void gcPhong_DragOver(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth <_Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void gvPhong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if(!gvPhong.IsGroupRow(e.RowHandle))
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
                        e.Info.DisplayText=(e.RowHandle + 1 ).ToString();
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText,e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20 ;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPhong); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20 ;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPhong); }));
            }
        }

        private void gvPhong_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if(info.Column.Caption ==string.Empty ) 
                caption = info.Column.ToString();
            info.GroupText=string.Format("{0}: {1} ({2} phòng trống)",caption,info.GroupValueText,view.GetChildRowCount(e.RowHandle));
           
        }

        private void gcSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (_idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvSanPham.GetFocusedRowCellValue("IDSP") != null)
            {
                OBJ_DPSP sp = new OBJ_DPSP();
                sp.IDSP = int.Parse(gvSanPham.GetFocusedRowCellValue("IDSP").ToString());
                sp.TENSP = gvSanPham.GetFocusedRowCellValue("TENSP").ToString();
                sp.IDPHONG = _idPhong;
                sp.TENPHONG = _tenPhong;
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
            };
        }


        private void UpdateTotalSummary(int soNgay)
        {
            double tongTienSanPhamDichVu = double.Parse(listDPSP.Sum(item => item.THANHTIEN).ToString());
            double donGiaPhong = double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString());
            double tongTienPhong = donGiaPhong * soNgay * 0.08 + donGiaPhong; 
            double tongTien = tongTienSanPhamDichVu + tongTienPhong;
            txtTongTien.Text = tongTien.ToString();
        }
        void loadDPSP()
        {
            List<OBJ_DPSP> lsDP = new List<OBJ_DPSP>();
            foreach(var item in listDPSP)
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
                if(s1!=0)
                {
                    double gia = double.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle, "DONGIA").ToString());
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle,"THANHTIEN",s1*gia);
                }
                else
                {
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", 0);
                }    
            }
            gvSPDV.UpdateTotalSummary();
            txtTongTien.Text = (double.Parse( gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString())).ToString("N0");
        }

        private void gvDatPhong_RowCountChanged(object sender, EventArgs e)
        {
            if (gvDatPhong.RowCount< _rowDatPhong && _them ==false)
            {
                _phong.updateStatus(_idPhong,false);
                _datphongchitiet.delete(_idDP, _idPhong);
                _datphongsanpham.deleteAllbyphong(_idDP,_idPhong);
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();

            }
            double t = 0;
            if (gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue == null)
            {
                t = 0;
            }
            else
                t = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
            txtTongTien.Text = (double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) + t).ToString("N0");
        }

        private void gvDatPhong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvDatPhong.IsGroupRow(e.RowHandle))
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDatPhong); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDatPhong); }));
            }
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

        private void btnAđdNew_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }
        public void setKhacHang(int idkh)
        {
            var _kh = _khachhang.getitem(idkh);
            cboKhachHang.SelectedValue = _kh.IDKH;
            cboKhachHang.Text = _kh.HOTEN;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount>0)
            {
                _idDP = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDP").ToString());
                var dp = _datphong.getitem(_idDP);
                cboKhachHang.SelectedValue = dp.IDKH;
                dtNgayDat.Value = dp.NGAYDATPHONG.Value;
                dtNgayTra.Value = dp.NGAYTRAPHONG.Value;
                spSoNguoi.Value = int.Parse(dp.SONGUOIO.ToString());
                cboTrangThai.SelectedValue =dp.STATUS;
                txtGhiChu.Text = dp.GHICHU;
                txtTongTien.Text = dp.SOTIEN.Value.ToString("N0");
                loadDP();
                loadSPDV();
            }
        }

        void loadDP()
        {
            _rowDatPhong=0;
            gcDatPhong.DataSource = myFunctions.laydulieu("SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, A.IDTANG, B.TENTANG FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C , tb_DatPhong_CT D WHERE A.IDTANG=B.IDTANG AND A.IDLOAIPHONG = C.IDLOAIPHONG AND A.IDPHONG=D.IDPHONG AND D.IDDP='"+_idDP+"'");
            _rowDatPhong = gvDatPhong.RowCount;
        }
        void loadSPDV()
        {
            gcSPDV.DataSource = _datphongsanpham.getallbydatphong(_idDP);
        }

        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDanhsach();
        }

        private void dtTuNgay_Leave(object sender, EventArgs e)
        {
            if(dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDanhsach();
        }

        private void dtDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDanhsach();
        }

        private void dtDenNgay_Leave(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDanhsach();
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idDP = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDP").ToString());
                var dp = _datphong.getitem(_idDP);
                cboKhachHang.SelectedValue = dp.IDKH;
                dtNgayDat.Value = dp.NGAYDATPHONG.Value;
                dtNgayTra.Value = dp.NGAYTRAPHONG.Value;
                spSoNguoi.Value = int.Parse(dp.SONGUOIO.ToString());
                cboTrangThai.SelectedValue = dp.STATUS;
                txtGhiChu.Text = dp.GHICHU;
                
                loadDP();
                loadSPDV();
                txtTongTien.Text = dp.SOTIEN.Value.ToString("N0");
            }
            tabDanhSach.SelectedTabPage = pageChiTiet;
        }

        private void gvDanhSach_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvDanhSach.IsGroupRow(e.RowHandle))
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDanhSach); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDanhSach); }));
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.Name=="DISABLED" && bool.Parse(e.CellValue.ToString())==true)
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
                int soNgay = (ngayTra - ngayDat).Days;

                // Sau đó, cập nhật tổng tiền
                UpdateTotalSummary(soNgay);
            }
        }

        private void dtNgayTra_ValueChanged_1(object sender, EventArgs e)
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
                int soNgay = (ngayTra - ngayDat).Days;

                // Sau đó, cập nhật tổng tiền
                UpdateTotalSummary(soNgay);
            }
        }
    }
}
namespace KHACHSAN
{
    partial class frmDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhong));
            this.tabDanhSach = new DevExpress.XtraTab.XtraTabControl();
            this.pageDanhSach = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDDP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYDATPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTRAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SONGUOIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MADVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THEODOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pageChiTiet = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.label8 = new System.Windows.Forms.Label();
            this.spSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblhuy = new System.Windows.Forms.Label();
            this.btnAđdNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDoan = new System.Windows.Forms.CheckBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcSPDV = new DevExpress.XtraGrid.GridControl();
            this.gvSPDV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spIDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spIDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTHANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcDatPhong = new DevExpress.XtraGrid.GridControl();
            this.gvDatPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dpIDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dpTENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dpDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dpTENTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.tabDanhSach)).BeginInit();
            this.tabDanhSach.SuspendLayout();
            this.pageDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.pageChiTiet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatPhong)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDanhSach.Location = new System.Drawing.Point(0, 65);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.SelectedTabPage = this.pageDanhSach;
            this.tabDanhSach.Size = new System.Drawing.Size(1196, 680);
            this.tabDanhSach.TabIndex = 2;
            this.tabDanhSach.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageDanhSach,
            this.pageChiTiet});
            // 
            // pageDanhSach
            // 
            this.pageDanhSach.Controls.Add(this.splitContainerControl1);
            this.pageDanhSach.Name = "pageDanhSach";
            this.pageDanhSach.Size = new System.Drawing.Size(1194, 650);
            this.pageDanhSach.Text = "Danh sách";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.dtDenNgay);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtTuNgay);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1194, 650);
            this.splitContainerControl1.SplitterPosition = 52;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(568, 20);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(200, 23);
            this.dtDenNgay.TabIndex = 3;
            this.dtDenNgay.ValueChanged += new System.EventHandler(this.dtDenNgay_ValueChanged);
            this.dtDenNgay.Leave += new System.EventHandler(this.dtDenNgay_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(206, 22);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(200, 23);
            this.dtTuNgay.TabIndex = 1;
            this.dtTuNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
            this.dtTuNgay.Leave += new System.EventHandler(this.dtTuNgay_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1194, 586);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.IDDP,
            this.NGAYDATPHONG,
            this.NGAYTRAPHONG,
            this.SOTIEN,
            this.SONGUOIO,
            this.MACTY,
            this.MADVI,
            this.STATUS,
            this.THEODOAN,
            this.IDKH,
            this.HOTEN,
            this.GHICHU});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvDanhSach_CustomDrawRowIndicator);
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            this.gvDanhSach.DoubleClick += new System.EventHandler(this.gvDanhSach_DoubleClick);
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "DEL";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.MaxWidth = 40;
            this.DISABLED.MinWidth = 10;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 0;
            this.DISABLED.Width = 40;
            // 
            // IDDP
            // 
            this.IDDP.Caption = "SỐ HĐ";
            this.IDDP.FieldName = "IDDP";
            this.IDDP.MaxWidth = 60;
            this.IDDP.MinWidth = 25;
            this.IDDP.Name = "IDDP";
            this.IDDP.Visible = true;
            this.IDDP.VisibleIndex = 1;
            this.IDDP.Width = 40;
            // 
            // NGAYDATPHONG
            // 
            this.NGAYDATPHONG.Caption = "NGÀY ĐẶT";
            this.NGAYDATPHONG.FieldName = "NGAYDATPHONG";
            this.NGAYDATPHONG.MaxWidth = 90;
            this.NGAYDATPHONG.MinWidth = 25;
            this.NGAYDATPHONG.Name = "NGAYDATPHONG";
            this.NGAYDATPHONG.Visible = true;
            this.NGAYDATPHONG.VisibleIndex = 2;
            this.NGAYDATPHONG.Width = 60;
            // 
            // NGAYTRAPHONG
            // 
            this.NGAYTRAPHONG.Caption = "NGÀY TRẢ";
            this.NGAYTRAPHONG.FieldName = "NGAYTRAPHONG";
            this.NGAYTRAPHONG.MaxWidth = 90;
            this.NGAYTRAPHONG.MinWidth = 25;
            this.NGAYTRAPHONG.Name = "NGAYTRAPHONG";
            this.NGAYTRAPHONG.Visible = true;
            this.NGAYTRAPHONG.VisibleIndex = 3;
            this.NGAYTRAPHONG.Width = 90;
            // 
            // SOTIEN
            // 
            this.SOTIEN.Caption = "SỐ TIỀN";
            this.SOTIEN.FieldName = "SOTIEN";
            this.SOTIEN.MaxWidth = 90;
            this.SOTIEN.MinWidth = 25;
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.Visible = true;
            this.SOTIEN.VisibleIndex = 4;
            this.SOTIEN.Width = 90;
            // 
            // SONGUOIO
            // 
            this.SONGUOIO.Caption = "SỐ NGƯỜI ";
            this.SONGUOIO.FieldName = "SONGUOIO";
            this.SONGUOIO.MaxWidth = 90;
            this.SONGUOIO.MinWidth = 25;
            this.SONGUOIO.Name = "SONGUOIO";
            this.SONGUOIO.Visible = true;
            this.SONGUOIO.VisibleIndex = 5;
            this.SONGUOIO.Width = 40;
            // 
            // MACTY
            // 
            this.MACTY.Caption = "MACTY";
            this.MACTY.FieldName = "MACTY";
            this.MACTY.MinWidth = 25;
            this.MACTY.Name = "MACTY";
            this.MACTY.Width = 94;
            // 
            // MADVI
            // 
            this.MADVI.Caption = "MADVI";
            this.MADVI.FieldName = "MADVI";
            this.MADVI.MinWidth = 25;
            this.MADVI.Name = "MADVI";
            this.MADVI.Width = 94;
            // 
            // STATUS
            // 
            this.STATUS.Caption = "TRẠNG THÁI";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.MaxWidth = 90;
            this.STATUS.MinWidth = 25;
            this.STATUS.Name = "STATUS";
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 6;
            this.STATUS.Width = 40;
            // 
            // THEODOAN
            // 
            this.THEODOAN.Caption = "ĐOÀN";
            this.THEODOAN.FieldName = "THEODOAN";
            this.THEODOAN.MaxWidth = 90;
            this.THEODOAN.MinWidth = 25;
            this.THEODOAN.Name = "THEODOAN";
            this.THEODOAN.Visible = true;
            this.THEODOAN.VisibleIndex = 7;
            this.THEODOAN.Width = 40;
            // 
            // IDKH
            // 
            this.IDKH.Caption = "KHÁCH HÀNG";
            this.IDKH.FieldName = "IDKH";
            this.IDKH.MinWidth = 25;
            this.IDKH.Name = "IDKH";
            this.IDKH.Width = 94;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "KHÁCH HÀNG";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 150;
            this.HOTEN.MinWidth = 25;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 8;
            this.HOTEN.Width = 94;
            // 
            // GHICHU
            // 
            this.GHICHU.Caption = "GHI CHÚ";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.MaxWidth = 150;
            this.GHICHU.MinWidth = 25;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 9;
            this.GHICHU.Width = 94;
            // 
            // pageChiTiet
            // 
            this.pageChiTiet.Controls.Add(this.tableLayoutPanel1);
            this.pageChiTiet.Name = "pageChiTiet";
            this.pageChiTiet.Size = new System.Drawing.Size(1194, 650);
            this.pageChiTiet.Text = "Chi tiết";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainerControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gcPhong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(352, 644);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách phòng trống";
            // 
            // gcPhong
            // 
            this.gcPhong.AllowDrop = true;
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhong.Location = new System.Drawing.Point(2, 28);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(348, 614);
            this.gcPhong.TabIndex = 0;
            this.gcPhong.UseDisabledStatePainter = false;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong});
            this.gcPhong.DragDrop += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragDrop);
            this.gcPhong.DragOver += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragOver);
            // 
            // gvPhong
            // 
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.IDTANG,
            this.TENTANG,
            this.pDONGIA});
            this.gvPhong.GridControl = this.gcPhong;
            this.gvPhong.GroupCount = 1;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.OptionsBehavior.Editable = false;
            this.gvPhong.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TENTANG, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPhong.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvPhong_CustomDrawRowIndicator);
            this.gvPhong.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gvPhong_CustomDrawGroupRow);
            this.gvPhong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPhong_MouseDown);
            this.gvPhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gvPhong_MouseMove);
            // 
            // IDPHONG
            // 
            this.IDPHONG.Caption = "ID";
            this.IDPHONG.FieldName = "IDPHONG";
            this.IDPHONG.MinWidth = 25;
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Width = 94;
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "TÊN PHÒNG";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MinWidth = 25;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 0;
            this.TENPHONG.Width = 94;
            // 
            // IDTANG
            // 
            this.IDTANG.Caption = "IDTANG";
            this.IDTANG.FieldName = "IDTANG";
            this.IDTANG.MinWidth = 25;
            this.IDTANG.Name = "IDTANG";
            this.IDTANG.Width = 94;
            // 
            // TENTANG
            // 
            this.TENTANG.Caption = "TẦNG";
            this.TENTANG.FieldName = "TENTANG";
            this.TENTANG.MinWidth = 25;
            this.TENTANG.Name = "TENTANG";
            this.TENTANG.Visible = true;
            this.TENTANG.VisibleIndex = 1;
            this.TENTANG.Width = 94;
            // 
            // pDONGIA
            // 
            this.pDONGIA.Caption = "ĐƠN GIÁ";
            this.pDONGIA.FieldName = "DONGIA";
            this.pDONGIA.MinWidth = 25;
            this.pDONGIA.Name = "pDONGIA";
            this.pDONGIA.Visible = true;
            this.pDONGIA.VisibleIndex = 1;
            this.pDONGIA.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gcSanPham);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(898, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(293, 644);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Sản Phẩm - Dịch vụ";
            // 
            // gcSanPham
            // 
            this.gcSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSanPham.Location = new System.Drawing.Point(2, 28);
            this.gcSanPham.MainView = this.gvSanPham;
            this.gcSanPham.Name = "gcSanPham";
            this.gcSanPham.Size = new System.Drawing.Size(289, 614);
            this.gcSanPham.TabIndex = 0;
            this.gcSanPham.UseDisabledStatePainter = false;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            this.gcSanPham.DoubleClick += new System.EventHandler(this.gcSanPham_DoubleClick);
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDSP,
            this.TENSP,
            this.DONGIA});
            this.gvSanPham.GridControl = this.gcSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            this.gvSanPham.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvSanPham_CustomDrawRowIndicator);
            // 
            // IDSP
            // 
            this.IDSP.Caption = "IDSP";
            this.IDSP.FieldName = "IDSP";
            this.IDSP.MinWidth = 25;
            this.IDSP.Name = "IDSP";
            this.IDSP.Width = 94;
            // 
            // TENSP
            // 
            this.TENSP.Caption = "TÊN SP-DV";
            this.TENSP.FieldName = "TENSP";
            this.TENSP.MinWidth = 25;
            this.TENSP.Name = "TENSP";
            this.TENSP.Visible = true;
            this.TENSP.VisibleIndex = 0;
            this.TENSP.Width = 94;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 1;
            this.DONGIA.Width = 94;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(361, 3);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl6);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl5);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(531, 644);
            this.splitContainerControl2.SplitterPosition = 171;
            this.splitContainerControl2.TabIndex = 3;
            // 
            // groupControl6
            // 
            this.groupControl6.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl6.AppearanceCaption.Options.UseFont = true;
            this.groupControl6.Controls.Add(this.label8);
            this.groupControl6.Controls.Add(this.spSoNguoi);
            this.groupControl6.Controls.Add(this.lblhuy);
            this.groupControl6.Controls.Add(this.btnAđdNew);
            this.groupControl6.Controls.Add(this.txtGhiChu);
            this.groupControl6.Controls.Add(this.label7);
            this.groupControl6.Controls.Add(this.chkDoan);
            this.groupControl6.Controls.Add(this.cboTrangThai);
            this.groupControl6.Controls.Add(this.label6);
            this.groupControl6.Controls.Add(this.dtNgayTra);
            this.groupControl6.Controls.Add(this.label5);
            this.groupControl6.Controls.Add(this.dtNgayDat);
            this.groupControl6.Controls.Add(this.label4);
            this.groupControl6.Controls.Add(this.cboKhachHang);
            this.groupControl6.Controls.Add(this.label3);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl6.Location = new System.Drawing.Point(0, 0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(531, 171);
            this.groupControl6.TabIndex = 0;
            this.groupControl6.Text = "Thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số người";
            // 
            // spSoNguoi
            // 
            this.spSoNguoi.Location = new System.Drawing.Point(320, 105);
            this.spSoNguoi.Name = "spSoNguoi";
            this.spSoNguoi.Size = new System.Drawing.Size(66, 23);
            this.spSoNguoi.TabIndex = 28;
            // 
            // lblhuy
            // 
            this.lblhuy.AutoSize = true;
            this.lblhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblhuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblhuy.ForeColor = System.Drawing.Color.Red;
            this.lblhuy.Location = new System.Drawing.Point(452, 31);
            this.lblhuy.Name = "lblhuy";
            this.lblhuy.Size = new System.Drawing.Size(23, 24);
            this.lblhuy.TabIndex = 27;
            this.lblhuy.Text = "*";
            // 
            // btnAđdNew
            // 
            this.btnAđdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAđdNew.ImageOptions.Image")));
            this.btnAđdNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAđdNew.Location = new System.Drawing.Point(396, 42);
            this.btnAđdNew.Name = "btnAđdNew";
            this.btnAđdNew.Size = new System.Drawing.Size(39, 25);
            this.btnAđdNew.TabIndex = 26;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(97, 136);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(359, 23);
            this.txtGhiChu.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ghi chú";
            // 
            // chkDoan
            // 
            this.chkDoan.AutoSize = true;
            this.chkDoan.Location = new System.Drawing.Point(410, 106);
            this.chkDoan.Name = "chkDoan";
            this.chkDoan.Size = new System.Drawing.Size(90, 20);
            this.chkDoan.TabIndex = 23;
            this.chkDoan.Text = "Theo đoàn";
            this.chkDoan.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(97, 102);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(136, 24);
            this.cboTrangThai.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trạng thái";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(320, 73);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(136, 23);
            this.dtNgayTra.TabIndex = 20;
            this.dtNgayTra.ValueChanged += new System.EventHandler(this.dtNgayTra_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày trả";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDat.Location = new System.Drawing.Point(97, 73);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(136, 23);
            this.dtNgayDat.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày đặt";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(97, 43);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(281, 24);
            this.cboKhachHang.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Khách hàng";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.label9);
            this.groupControl5.Controls.Add(this.txtTongTien);
            this.groupControl5.Controls.Add(this.lblThanhToan);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 388);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(531, 73);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "TỔNG THANH TOÁN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(316, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.Location = new System.Drawing.Point(162, 45);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(144, 32);
            this.txtTongTien.TabIndex = 1;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblThanhToan.ForeColor = System.Drawing.Color.Black;
            this.lblThanhToan.Location = new System.Drawing.Point(34, 53);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(122, 24);
            this.lblThanhToan.TabIndex = 0;
            this.lblThanhToan.Text = "TỔNG TIỀN";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.gcSPDV);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 208);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(531, 180);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Danh sách SP-DV";
            // 
            // gcSPDV
            // 
            this.gcSPDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSPDV.Location = new System.Drawing.Point(2, 28);
            this.gcSPDV.MainView = this.gvSPDV;
            this.gcSPDV.Name = "gcSPDV";
            this.gcSPDV.Size = new System.Drawing.Size(527, 150);
            this.gcSPDV.TabIndex = 0;
            this.gcSPDV.UseDisabledStatePainter = false;
            this.gcSPDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPDV});
            // 
            // gvSPDV
            // 
            this.gvSPDV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.spIDSP,
            this.spTENPHONG,
            this.spTENSP,
            this.spIDPHONG,
            this.spSOLUONG,
            this.spDONGIA,
            this.spTHANHTIEN});
            this.gvSPDV.GridControl = this.gcSPDV;
            this.gvSPDV.Name = "gvSPDV";
            this.gvSPDV.OptionsView.ShowFooter = true;
            this.gvSPDV.OptionsView.ShowGroupPanel = false;
            this.gvSPDV.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvSPDV_CustomDrawRowIndicator);
            this.gvSPDV.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSPDV_CellValueChanged);
            this.gvSPDV.DoubleClick += new System.EventHandler(this.gvSPDV_DoubleClick);
            // 
            // spIDSP
            // 
            this.spIDSP.Caption = "IDSP";
            this.spIDSP.FieldName = "IDSP";
            this.spIDSP.MinWidth = 25;
            this.spIDSP.Name = "spIDSP";
            this.spIDSP.Width = 94;
            // 
            // spTENPHONG
            // 
            this.spTENPHONG.Caption = "PHÒNG";
            this.spTENPHONG.FieldName = "TENPHONG";
            this.spTENPHONG.MinWidth = 25;
            this.spTENPHONG.Name = "spTENPHONG";
            this.spTENPHONG.OptionsColumn.AllowEdit = false;
            this.spTENPHONG.Visible = true;
            this.spTENPHONG.VisibleIndex = 0;
            this.spTENPHONG.Width = 94;
            // 
            // spTENSP
            // 
            this.spTENSP.Caption = "TÊN SP-DV";
            this.spTENSP.FieldName = "TENSP";
            this.spTENSP.MinWidth = 25;
            this.spTENSP.Name = "spTENSP";
            this.spTENSP.OptionsColumn.AllowEdit = false;
            this.spTENSP.Visible = true;
            this.spTENSP.VisibleIndex = 1;
            this.spTENSP.Width = 94;
            // 
            // spIDPHONG
            // 
            this.spIDPHONG.Caption = "IDPHONG";
            this.spIDPHONG.FieldName = "IDPHONG";
            this.spIDPHONG.MinWidth = 25;
            this.spIDPHONG.Name = "spIDPHONG";
            this.spIDPHONG.Width = 94;
            // 
            // spSOLUONG
            // 
            this.spSOLUONG.Caption = "SL";
            this.spSOLUONG.FieldName = "SOLUONG";
            this.spSOLUONG.MinWidth = 25;
            this.spSOLUONG.Name = "spSOLUONG";
            this.spSOLUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SOLUONG", "{0:0.##}")});
            this.spSOLUONG.Visible = true;
            this.spSOLUONG.VisibleIndex = 2;
            this.spSOLUONG.Width = 94;
            // 
            // spDONGIA
            // 
            this.spDONGIA.Caption = "ĐƠN GIÁ";
            this.spDONGIA.FieldName = "DONGIA";
            this.spDONGIA.MinWidth = 25;
            this.spDONGIA.Name = "spDONGIA";
            this.spDONGIA.OptionsColumn.AllowEdit = false;
            this.spDONGIA.Visible = true;
            this.spDONGIA.VisibleIndex = 3;
            this.spDONGIA.Width = 94;
            // 
            // spTHANHTIEN
            // 
            this.spTHANHTIEN.Caption = "THÀNH TIỀN";
            this.spTHANHTIEN.FieldName = "THANHTIEN";
            this.spTHANHTIEN.MinWidth = 25;
            this.spTHANHTIEN.Name = "spTHANHTIEN";
            this.spTHANHTIEN.OptionsColumn.AllowEdit = false;
            this.spTHANHTIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THANHTIEN", "{0:n0}")});
            this.spTHANHTIEN.Visible = true;
            this.spTHANHTIEN.VisibleIndex = 4;
            this.spTHANHTIEN.Width = 94;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gcDatPhong);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(531, 208);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Danh sách phòng đặt";
            // 
            // gcDatPhong
            // 
            this.gcDatPhong.AllowDrop = true;
            this.gcDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDatPhong.Location = new System.Drawing.Point(2, 28);
            this.gcDatPhong.MainView = this.gvDatPhong;
            this.gcDatPhong.Name = "gcDatPhong";
            this.gcDatPhong.Size = new System.Drawing.Size(527, 178);
            this.gcDatPhong.TabIndex = 0;
            this.gcDatPhong.UseDisabledStatePainter = false;
            this.gcDatPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatPhong});
            this.gcDatPhong.DragDrop += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragDrop);
            this.gcDatPhong.DragOver += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragOver);
            // 
            // gvDatPhong
            // 
            this.gvDatPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dpIDPHONG,
            this.dpTENPHONG,
            this.dpDONGIA,
            this.dpTENTANG});
            this.gvDatPhong.GridControl = this.gcDatPhong;
            this.gvDatPhong.Name = "gvDatPhong";
            this.gvDatPhong.OptionsBehavior.Editable = false;
            this.gvDatPhong.OptionsView.ShowFooter = true;
            this.gvDatPhong.OptionsView.ShowGroupPanel = false;
            this.gvDatPhong.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvDatPhong_CustomDrawRowIndicator);
            this.gvDatPhong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvDatPhong_MouseDown);
            this.gvDatPhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gvDatPhong_MouseMove);
            this.gvDatPhong.RowCountChanged += new System.EventHandler(this.gvDatPhong_RowCountChanged);
            // 
            // dpIDPHONG
            // 
            this.dpIDPHONG.Caption = "IDPHONG";
            this.dpIDPHONG.FieldName = "IDPHONG";
            this.dpIDPHONG.MinWidth = 25;
            this.dpIDPHONG.Name = "dpIDPHONG";
            this.dpIDPHONG.Width = 94;
            // 
            // dpTENPHONG
            // 
            this.dpTENPHONG.Caption = "TÊN PHÒNG";
            this.dpTENPHONG.FieldName = "TENPHONG";
            this.dpTENPHONG.MaxWidth = 100;
            this.dpTENPHONG.MinWidth = 25;
            this.dpTENPHONG.Name = "dpTENPHONG";
            this.dpTENPHONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TENPHONG", "{0}")});
            this.dpTENPHONG.Visible = true;
            this.dpTENPHONG.VisibleIndex = 0;
            this.dpTENPHONG.Width = 60;
            // 
            // dpDONGIA
            // 
            this.dpDONGIA.Caption = "ĐƠN GIÁ";
            this.dpDONGIA.FieldName = "DONGIA";
            this.dpDONGIA.MaxWidth = 100;
            this.dpDONGIA.MinWidth = 25;
            this.dpDONGIA.Name = "dpDONGIA";
            this.dpDONGIA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DONGIA", "{0:n0}")});
            this.dpDONGIA.Visible = true;
            this.dpDONGIA.VisibleIndex = 1;
            this.dpDONGIA.Width = 60;
            // 
            // dpTENTANG
            // 
            this.dpTENTANG.Caption = "TẦNG";
            this.dpTENTANG.FieldName = "TENTANG";
            this.dpTENTANG.MinWidth = 25;
            this.dpTENTANG.Name = "dpTENTANG";
            this.dpTENTANG.Width = 94;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::KHACHSAN.Properties.Resources._299068_add_sign_icon;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 62);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::KHACHSAN.Properties.Resources._728933_document_edit_file_page_paper_icon;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(42, 62);
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::KHACHSAN.Properties.Resources._9004743_trash_delete_bin_remove_icon;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(42, 62);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::KHACHSAN.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(42, 62);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::KHACHSAN.Properties.Resources._9004839_arrow_direction_right_next_icon;
            this.btnBoqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(60, 62);
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::KHACHSAN.Properties.Resources._39263_print_printer_icon;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(42, 62);
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::KHACHSAN.Properties.Resources._38999_exit_icon;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 62);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnBoqua,
            this.btnIn,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1196, 65);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 745);
            this.Controls.Add(this.tabDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatPhong";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabDanhSach)).EndInit();
            this.tabDanhSach.ResumeLayout(false);
            this.pageDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.pageChiTiet.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatPhong)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabDanhSach;
        private DevExpress.XtraTab.XtraTabPage pageDanhSach;
        private DevExpress.XtraTab.XtraTabPage pageChiTiet;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn IDDP;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYDATPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTRAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn SONGUOIO;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private DevExpress.XtraGrid.Columns.GridColumn MADVI;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn THEODOAN;
        private DevExpress.XtraGrid.Columns.GridColumn IDKH;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn IDTANG;
        private DevExpress.XtraGrid.Columns.GridColumn TENTANG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IDSP;
        private DevExpress.XtraGrid.Columns.GridColumn TENSP;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcSPDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPDV;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcDatPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatPhong;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Label lblThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn pDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn dpIDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn dpTENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn dpDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn dpTENTANG;
        private DevExpress.XtraGrid.Columns.GridColumn spIDSP;
        private DevExpress.XtraGrid.Columns.GridColumn spTENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spTENSP;
        private DevExpress.XtraGrid.Columns.GridColumn spIDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn spDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn spTHANHTIEN;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown spSoNguoi;
        private System.Windows.Forms.Label lblhuy;
        private DevExpress.XtraEditors.SimpleButton btnAđdNew;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDoan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
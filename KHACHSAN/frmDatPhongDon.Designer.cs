namespace KHACHSAN
{
    partial class frmDatPhongDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhongDon));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchKH = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPhong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.spSoNguoi = new System.Windows.Forms.NumericUpDown();
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLuu,
            this.btnIn,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 65);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 65);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1032, 490);
            this.splitContainerControl1.SplitterPosition = 665;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.label1);
            this.groupControl5.Controls.Add(this.txtTongTien);
            this.groupControl5.Controls.Add(this.lblThanhToan);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 401);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(665, 89);
            this.groupControl5.TabIndex = 3;
            this.groupControl5.Text = "TỔNG THANH TOÁN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(470, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(248, 45);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(216, 32);
            this.txtTongTien.TabIndex = 1;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblThanhToan.ForeColor = System.Drawing.Color.Black;
            this.lblThanhToan.Location = new System.Drawing.Point(120, 53);
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
            this.groupControl4.Location = new System.Drawing.Point(0, 221);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(665, 180);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Danh sách SP-DV";
            // 
            // gcSPDV
            // 
            this.gcSPDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSPDV.Location = new System.Drawing.Point(2, 28);
            this.gcSPDV.MainView = this.gvSPDV;
            this.gcSPDV.Name = "gcSPDV";
            this.gcSPDV.Size = new System.Drawing.Size(661, 150);
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
            this.gvSPDV.HiddenEditor += new System.EventHandler(this.gvSPDV_HiddenEditor);
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
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.searchKH);
            this.groupControl1.Controls.Add(this.lblPhong);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.spSoNguoi);
            this.groupControl1.Controls.Add(this.btnAđdNew);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.chkDoan);
            this.groupControl1.Controls.Add(this.cboTrangThai);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.dtNgayTra);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dtNgayDat);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(665, 221);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin khách hàng";
            // 
            // searchKH
            // 
            this.searchKH.EditValue = "";
            this.searchKH.Location = new System.Drawing.Point(160, 76);
            this.searchKH.Name = "searchKH";
            this.searchKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchKH.Properties.NullText = "";
            this.searchKH.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchKH.Size = new System.Drawing.Size(281, 22);
            this.searchKH.TabIndex = 31;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDKH,
            this.HOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IDKH
            // 
            this.IDKH.Caption = "ID";
            this.IDKH.FieldName = "IDKH";
            this.IDKH.MaxWidth = 50;
            this.IDKH.MinWidth = 30;
            this.IDKH.Name = "IDKH";
            this.IDKH.Visible = true;
            this.IDKH.VisibleIndex = 0;
            this.IDKH.Width = 50;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN KHÁCH HÀNG";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 150;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 150;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhong.ForeColor = System.Drawing.Color.Black;
            this.lblPhong.Location = new System.Drawing.Point(148, 38);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(83, 24);
            this.lblPhong.TabIndex = 30;
            this.lblPhong.Text = "PHÒNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số người";
            // 
            // spSoNguoi
            // 
            this.spSoNguoi.Location = new System.Drawing.Point(382, 139);
            this.spSoNguoi.Name = "spSoNguoi";
            this.spSoNguoi.Size = new System.Drawing.Size(136, 23);
            this.spSoNguoi.TabIndex = 28;
            // 
            // btnAđdNew
            // 
            this.btnAđdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAđdNew.ImageOptions.Image")));
            this.btnAđdNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAđdNew.Location = new System.Drawing.Point(458, 76);
            this.btnAđdNew.Name = "btnAđdNew";
            this.btnAđdNew.Size = new System.Drawing.Size(39, 25);
            this.btnAđdNew.TabIndex = 26;
            this.btnAđdNew.Click += new System.EventHandler(this.btnAđdNew_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(159, 170);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(359, 23);
            this.txtGhiChu.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ghi chú";
            // 
            // chkDoan
            // 
            this.chkDoan.AutoSize = true;
            this.chkDoan.Location = new System.Drawing.Point(431, 140);
            this.chkDoan.Name = "chkDoan";
            this.chkDoan.Size = new System.Drawing.Size(90, 20);
            this.chkDoan.TabIndex = 23;
            this.chkDoan.Text = "Theo đoàn";
            this.chkDoan.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(159, 136);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(136, 24);
            this.cboTrangThai.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trạng thái";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(382, 107);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(136, 23);
            this.dtNgayTra.TabIndex = 20;
            this.dtNgayTra.ValueChanged += new System.EventHandler(this.dtNgayTra_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày trả";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDat.Location = new System.Drawing.Point(159, 107);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(136, 23);
            this.dtNgayDat.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Khách hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gcSanPham);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(355, 490);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách SP";
            // 
            // gcSanPham
            // 
            this.gcSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSanPham.Location = new System.Drawing.Point(2, 28);
            this.gcSanPham.MainView = this.gvSanPham;
            this.gcSanPham.Name = "gcSanPham";
            this.gcSanPham.Size = new System.Drawing.Size(351, 460);
            this.gcSanPham.TabIndex = 2;
            this.gcSanPham.UseDisabledStatePainter = false;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
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
            this.gvSanPham.DoubleClick += new System.EventHandler(this.gvSanPham_DoubleClick_1);
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
            // frmDatPhongDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 555);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDatPhongDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phòng Đơn";
            this.Load += new System.EventHandler(this.frmDatPhongDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown spSoNguoi;
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
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcSPDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPDV;
        private DevExpress.XtraGrid.Columns.GridColumn spIDSP;
        private DevExpress.XtraGrid.Columns.GridColumn spTENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spTENSP;
        private DevExpress.XtraGrid.Columns.GridColumn spIDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn spDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn spTHANHTIEN;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblThanhToan;
        private DevExpress.XtraEditors.SearchLookUpEdit searchKH;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IDKH;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IDSP;
        private DevExpress.XtraGrid.Columns.GridColumn TENSP;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
    }
}
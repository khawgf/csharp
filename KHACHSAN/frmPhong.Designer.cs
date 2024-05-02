namespace KHACHSAN
{
    partial class frmPhong
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inf = new DevExpress.XtraEditors.GroupControl();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.chkTrangthai = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtmacty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf)).BeginInit();
            this.inf.SuspendLayout();
            this.SuspendLayout();
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
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(542, 65);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 65);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(542, 255);
            this.gcDanhSach.TabIndex = 3;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.TRANGTHAI,
            this.TENPHONG,
            this.IDPHONG,
            this.IDTANG,
            this.IDLOAIPHONG});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "DEL";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.MaxWidth = 40;
            this.DISABLED.MinWidth = 25;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Width = 40;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.Caption = "Đã đặt";
            this.TRANGTHAI.FieldName = "TRANGTHAI";
            this.TRANGTHAI.MaxWidth = 60;
            this.TRANGTHAI.MinWidth = 25;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 0;
            this.TRANGTHAI.Width = 40;
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "TÊN PHÒNG";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MaxWidth = 150;
            this.TENPHONG.MinWidth = 25;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 1;
            this.TENPHONG.Width = 80;
            // 
            // IDPHONG
            // 
            this.IDPHONG.Caption = "IDPHONG";
            this.IDPHONG.FieldName = "IDPHONG";
            this.IDPHONG.MaxWidth = 80;
            this.IDPHONG.MinWidth = 25;
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Width = 80;
            // 
            // IDTANG
            // 
            this.IDTANG.Caption = "IDTANG";
            this.IDTANG.FieldName = "IDTANG";
            this.IDTANG.MaxWidth = 200;
            this.IDTANG.MinWidth = 25;
            this.IDTANG.Name = "IDTANG";
            this.IDTANG.Width = 94;
            // 
            // IDLOAIPHONG
            // 
            this.IDLOAIPHONG.Caption = "IDLOAIPHONG";
            this.IDLOAIPHONG.FieldName = "IDLOAIPHONG";
            this.IDLOAIPHONG.MaxWidth = 130;
            this.IDLOAIPHONG.MinWidth = 25;
            this.IDLOAIPHONG.Name = "IDLOAIPHONG";
            this.IDLOAIPHONG.Width = 80;
            // 
            // inf
            // 
            this.inf.Controls.Add(this.btnsearch);
            this.inf.Controls.Add(this.label10);
            this.inf.Controls.Add(this.chkTrangthai);
            this.inf.Controls.Add(this.label9);
            this.inf.Controls.Add(this.cboLoaiPhong);
            this.inf.Controls.Add(this.txtmacty);
            this.inf.Controls.Add(this.label8);
            this.inf.Controls.Add(this.cboTang);
            this.inf.Controls.Add(this.label6);
            this.inf.Controls.Add(this.chkDisabled);
            this.inf.Controls.Add(this.txtTen);
            this.inf.Controls.Add(this.label1);
            this.inf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inf.Location = new System.Drawing.Point(0, 320);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(542, 124);
            this.inf.TabIndex = 4;
            this.inf.Text = "Thông tin";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(397, 49);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "Tìm kiếm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 20;
            // 
            // chkTrangthai
            // 
            this.chkTrangthai.AutoSize = true;
            this.chkTrangthai.Location = new System.Drawing.Point(176, 93);
            this.chkTrangthai.Name = "chkTrangthai";
            this.chkTrangthai.Size = new System.Drawing.Size(81, 20);
            this.chkTrangthai.TabIndex = 19;
            this.chkTrangthai.Text = "Được đặt";
            this.chkTrangthai.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Loại Phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(248, 49);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(114, 24);
            this.cboLoaiPhong.TabIndex = 17;
            // 
            // txtmacty
            // 
            this.txtmacty.AutoSize = true;
            this.txtmacty.Location = new System.Drawing.Point(283, 50);
            this.txtmacty.Name = "txtmacty";
            this.txtmacty.Size = new System.Drawing.Size(0, 16);
            this.txtmacty.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tầng";
            // 
            // cboTang
            // 
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Location = new System.Drawing.Point(54, 47);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(103, 24);
            this.cboTang.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 11;
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(262, 51);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(85, 20);
            this.chkDisabled.TabIndex = 10;
            this.chkDisabled.Text = "DISABLED";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(47, 89);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(110, 23);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 444);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf)).EndInit();
            this.inf.ResumeLayout(false);
            this.inf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn IDTANG;
        private DevExpress.XtraGrid.Columns.GridColumn IDLOAIPHONG;
        private DevExpress.XtraEditors.GroupControl inf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label txtmacty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkTrangthai;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private System.Windows.Forms.Button btnsearch;
    }
}
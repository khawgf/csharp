namespace KHACHSAN
{
    partial class frmLoaiPhong
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
            this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SONGUOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtsogiuong = new System.Windows.Forms.TextBox();
            this.txtsonguoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(666, 65);
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
            this.gcDanhSach.Size = new System.Drawing.Size(666, 255);
            this.gcDanhSach.TabIndex = 3;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.TENLOAIPHONG,
            this.DONGIA,
            this.SONGUOI,
            this.SOGIUONG,
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
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 0;
            this.DISABLED.Width = 40;
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.Caption = "LOẠI PHÒNG";
            this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
            this.TENLOAIPHONG.MaxWidth = 150;
            this.TENLOAIPHONG.MinWidth = 25;
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Visible = true;
            this.TENLOAIPHONG.VisibleIndex = 1;
            this.TENLOAIPHONG.Width = 80;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 2;
            this.DONGIA.Width = 94;
            // 
            // SONGUOI
            // 
            this.SONGUOI.Caption = "SỐ NGƯỜI Ở";
            this.SONGUOI.FieldName = "SONGUOI";
            this.SONGUOI.MinWidth = 25;
            this.SONGUOI.Name = "SONGUOI";
            this.SONGUOI.Visible = true;
            this.SONGUOI.VisibleIndex = 3;
            this.SONGUOI.Width = 94;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.Caption = "SỐ GIƯỜNG";
            this.SOGIUONG.FieldName = "SOGIUONG";
            this.SOGIUONG.MinWidth = 25;
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.Visible = true;
            this.SOGIUONG.VisibleIndex = 4;
            this.SOGIUONG.Width = 94;
            // 
            // IDLOAIPHONG
            // 
            this.IDLOAIPHONG.Caption = "IDLOAIPHONG";
            this.IDLOAIPHONG.FieldName = "IDLOAIPHONG";
            this.IDLOAIPHONG.MaxWidth = 80;
            this.IDLOAIPHONG.MinWidth = 25;
            this.IDLOAIPHONG.Name = "IDLOAIPHONG";
            this.IDLOAIPHONG.Width = 40;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtsogiuong);
            this.groupControl1.Controls.Add(this.txtsonguoi);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.chkDisabled);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 320);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(666, 150);
            this.groupControl1.TabIndex = 4;
            // 
            // txtsogiuong
            // 
            this.txtsogiuong.Location = new System.Drawing.Point(502, 90);
            this.txtsogiuong.Name = "txtsogiuong";
            this.txtsogiuong.Size = new System.Drawing.Size(114, 23);
            this.txtsogiuong.TabIndex = 21;
            // 
            // txtsonguoi
            // 
            this.txtsonguoi.Location = new System.Drawing.Point(502, 43);
            this.txtsonguoi.Name = "txtsonguoi";
            this.txtsonguoi.Size = new System.Drawing.Size(114, 23);
            this.txtsonguoi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Giường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số Người";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(95, 93);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(306, 23);
            this.txtDonGia.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đơn Gía";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 11;
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(316, 96);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(85, 20);
            this.chkDisabled.TabIndex = 10;
            this.chkDisabled.Text = "DISABLED";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(95, 47);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(306, 23);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 470);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại phòng";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
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
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn IDLOAIPHONG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsogiuong;
        private System.Windows.Forms.TextBox txtsonguoi;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn SONGUOI;
        private DevExpress.XtraGrid.Columns.GridColumn SOGIUONG;
    }
}
namespace KHACHSAN
{
    partial class frmPhongThietbi
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
            this.inf = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.nsoluong = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboThietbi = new System.Windows.Forms.ComboBox();
            this.txtmacty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inf)).BeginInit();
            this.inf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(803, 65);
            this.toolStrip1.TabIndex = 3;
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
            // inf
            // 
            this.inf.Controls.Add(this.label1);
            this.inf.Controls.Add(this.nsoluong);
            this.inf.Controls.Add(this.label10);
            this.inf.Controls.Add(this.label9);
            this.inf.Controls.Add(this.cboThietbi);
            this.inf.Controls.Add(this.txtmacty);
            this.inf.Controls.Add(this.label8);
            this.inf.Controls.Add(this.cboPhong);
            this.inf.Controls.Add(this.label6);
            this.inf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inf.Location = new System.Drawing.Point(0, 320);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(803, 96);
            this.inf.TabIndex = 5;
            this.inf.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "số lượng";
            // 
            // nsoluong
            // 
            this.nsoluong.Location = new System.Drawing.Point(507, 46);
            this.nsoluong.Name = "nsoluong";
            this.nsoluong.Size = new System.Drawing.Size(101, 23);
            this.nsoluong.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tên thiết bị";
            // 
            // cboThietbi
            // 
            this.cboThietbi.FormattingEnabled = true;
            this.cboThietbi.Location = new System.Drawing.Point(313, 46);
            this.cboThietbi.Name = "cboThietbi";
            this.cboThietbi.Size = new System.Drawing.Size(114, 24);
            this.cboThietbi.TabIndex = 17;
            // 
            // txtmacty
            // 
            this.txtmacty.AutoSize = true;
            this.txtmacty.Location = new System.Drawing.Point(592, 140);
            this.txtmacty.Name = "txtmacty";
            this.txtmacty.Size = new System.Drawing.Size(0, 16);
            this.txtmacty.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tên Phòng";
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(86, 50);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(103, 24);
            this.cboPhong.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 11;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENPHONG,
            this.TENTB,
            this.SOLUONG,
            this.IDTB,
            this.IDPHONG});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "TÊN PHÒNG";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MaxWidth = 100;
            this.TENPHONG.MinWidth = 25;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 0;
            this.TENPHONG.Width = 40;
            // 
            // TENTB
            // 
            this.TENTB.Caption = "TÊN THIẾT BỊ";
            this.TENTB.FieldName = "TENTB";
            this.TENTB.MaxWidth = 150;
            this.TENTB.MinWidth = 25;
            this.TENTB.Name = "TENTB";
            this.TENTB.Visible = true;
            this.TENTB.VisibleIndex = 1;
            this.TENTB.Width = 40;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Caption = "SỐ LƯỢNG";
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.MaxWidth = 80;
            this.SOLUONG.MinWidth = 25;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 2;
            this.SOLUONG.Width = 80;
            // 
            // IDTB
            // 
            this.IDTB.Caption = "IDTB";
            this.IDTB.FieldName = "IDTB";
            this.IDTB.MinWidth = 25;
            this.IDTB.Name = "IDTB";
            this.IDTB.Width = 94;
            // 
            // IDPHONG
            // 
            this.IDPHONG.Caption = "IDPHONG";
            this.IDPHONG.FieldName = "IDPHONG";
            this.IDPHONG.MinWidth = 25;
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Width = 94;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 65);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(803, 255);
            this.gcDanhSach.TabIndex = 4;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // frmPhongThietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 416);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhongThietbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhongThietbi";
            this.Load += new System.EventHandler(this.frmPhongThietbi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inf)).EndInit();
            this.inf.ResumeLayout(false);
            this.inf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl inf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nsoluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboThietbi;
        private System.Windows.Forms.Label txtmacty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENTB;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IDTB;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
    }
}
namespace KHACHSAN
{
    partial class frmChuyenPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenPhong));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnchuyenphong = new DevExpress.XtraEditors.SimpleButton();
            this.searchPhong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnthoat);
            this.groupControl1.Controls.Add(this.btnchuyenphong);
            this.groupControl1.Controls.Add(this.searchPhong);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.lblPhong);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(555, 206);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn phòng chuyển đến";
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(287, 139);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(136, 41);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnchuyenphong
            // 
            this.btnchuyenphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnchuyenphong.ImageOptions.Image")));
            this.btnchuyenphong.Location = new System.Drawing.Point(133, 139);
            this.btnchuyenphong.Name = "btnchuyenphong";
            this.btnchuyenphong.Size = new System.Drawing.Size(134, 41);
            this.btnchuyenphong.TabIndex = 4;
            this.btnchuyenphong.Text = "Chuyển phòng";
            this.btnchuyenphong.Click += new System.EventHandler(this.btnchuyenphong_Click);
            // 
            // searchPhong
            // 
            this.searchPhong.Location = new System.Drawing.Point(230, 99);
            this.searchPhong.Name = "searchPhong";
            this.searchPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchPhong.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchPhong.Size = new System.Drawing.Size(250, 22);
            this.searchPhong.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.DONGIA});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(74, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng chuyển đến";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhong.Location = new System.Drawing.Point(226, 64);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(73, 21);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(104, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng hiện tại";
            // 
            // IDPHONG
            // 
            this.IDPHONG.Caption = "ID";
            this.IDPHONG.FieldName = "IDPHONG";
            this.IDPHONG.MaxWidth = 30;
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Visible = true;
            this.IDPHONG.VisibleIndex = 0;
            this.IDPHONG.Width = 20;
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "TÊN PHÒNG";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MaxWidth = 110;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 1;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MaxWidth = 110;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 2;
            // 
            // frmChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 206);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChuyenPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenPhong";
            this.Load += new System.EventHandler(this.frmChuyenPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnchuyenphong;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
    }
}
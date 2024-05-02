namespace KHACHSAN.Mycontrols
{
    partial class frmShowDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDonVi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbocongty = new System.Windows.Forms.ComboBox();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MADVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnthuchien = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cbocongty);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(617, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Công ty/Chi nhánh";
            // 
            // cbocongty
            // 
            this.cbocongty.FormattingEnabled = true;
            this.cbocongty.Location = new System.Drawing.Point(67, 38);
            this.cbocongty.Name = "cbocongty";
            this.cbocongty.Size = new System.Drawing.Size(483, 24);
            this.cbocongty.TabIndex = 1;
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 79);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(617, 214);
            this.gcdanhsach.TabIndex = 1;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MADVI,
            this.TENDVI});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            // 
            // MADVI
            // 
            this.MADVI.Caption = "MADVI";
            this.MADVI.FieldName = "MADVI";
            this.MADVI.MaxWidth = 80;
            this.MADVI.MinWidth = 60;
            this.MADVI.Name = "MADVI";
            this.MADVI.Visible = true;
            this.MADVI.VisibleIndex = 0;
            this.MADVI.Width = 80;
            // 
            // TENDVI
            // 
            this.TENDVI.Caption = "TÊN ĐƠN VỊ";
            this.TENDVI.FieldName = "TENDVI";
            this.TENDVI.MaxWidth = 250;
            this.TENDVI.MinWidth = 200;
            this.TENDVI.Name = "TENDVI";
            this.TENDVI.Visible = true;
            this.TENDVI.VisibleIndex = 1;
            this.TENDVI.Width = 200;
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(454, 309);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(116, 45);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthuchien
            // 
            this.btnthuchien.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnthuchien.Appearance.Options.UseFont = true;
            this.btnthuchien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnthuchien.Location = new System.Drawing.Point(312, 309);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(115, 45);
            this.btnthuchien.TabIndex = 2;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // frmShowDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 366);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.gcdanhsach);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmShowDonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn đơn vị cần báo báo";
            this.Load += new System.EventHandler(this.frmShowDonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbocongty;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn MADVI;
        private DevExpress.XtraGrid.Columns.GridColumn TENDVI;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnthuchien;
    }
}
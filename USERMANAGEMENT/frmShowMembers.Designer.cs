namespace USERMANAGEMENT
{
    partial class frmShowMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowMembers));
            this.gcThanhvien = new DevExpress.XtraGrid.GridControl();
            this.gvthanhvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // gcThanhvien
            // 
            this.gcThanhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThanhvien.Location = new System.Drawing.Point(0, 0);
            this.gcThanhvien.MainView = this.gvthanhvien;
            this.gcThanhvien.Name = "gcThanhvien";
            this.gcThanhvien.Size = new System.Drawing.Size(523, 225);
            this.gcThanhvien.TabIndex = 1;
            this.gcThanhvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvthanhvien});
            // 
            // gvthanhvien
            // 
            this.gvthanhvien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME});
            this.gvthanhvien.GridControl = this.gcThanhvien;
            this.gvthanhvien.Name = "gvthanhvien";
            this.gvthanhvien.OptionsView.ShowGroupPanel = false;
            // 
            // IDUSER
            // 
            this.IDUSER.Caption = "ID";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.MaxWidth = 30;
            this.IDUSER.MinWidth = 25;
            this.IDUSER.Name = "IDUSER";
            this.IDUSER.Width = 30;
            // 
            // USERNAME
            // 
            this.USERNAME.Caption = "USERNAME";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.MaxWidth = 100;
            this.USERNAME.MinWidth = 80;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 0;
            this.USERNAME.Width = 94;
            // 
            // FULLNAME
            // 
            this.FULLNAME.Caption = "FULLNAME";
            this.FULLNAME.FieldName = "FULLNAME";
            this.FULLNAME.MaxWidth = 120;
            this.FULLNAME.MinWidth = 100;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Visible = true;
            this.FULLNAME.VisibleIndex = 1;
            this.FULLNAME.Width = 100;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(363, 250);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 43);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.Location = new System.Drawing.Point(221, 250);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(121, 43);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // frmShowMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 323);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.gcThanhvien);
            this.Name = "frmShowMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thành viên";
            this.Load += new System.EventHandler(this.frmShowMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcThanhvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvthanhvien;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnluu;
    }
}
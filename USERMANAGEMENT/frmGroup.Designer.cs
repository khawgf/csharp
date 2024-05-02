namespace USERMANAGEMENT
{
    partial class frmGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroup));
            this.tabGroup = new DevExpress.XtraTab.XtraTabControl();
            this.pageNhom = new DevExpress.XtraTab.XtraTabPage();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageThanhvien = new DevExpress.XtraTab.XtraTabPage();
            this.btnbot = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.gcThanhvien = new DevExpress.XtraGrid.GridControl();
            this.gvthanhvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabGroup)).BeginInit();
            this.tabGroup.SuspendLayout();
            this.pageNhom.SuspendLayout();
            this.pageThanhvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGroup
            // 
            this.tabGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabGroup.Location = new System.Drawing.Point(0, 0);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.SelectedTabPage = this.pageNhom;
            this.tabGroup.Size = new System.Drawing.Size(617, 289);
            this.tabGroup.TabIndex = 0;
            this.tabGroup.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageNhom,
            this.pageThanhvien});
            // 
            // pageNhom
            // 
            this.pageNhom.Controls.Add(this.txtmota);
            this.pageNhom.Controls.Add(this.label2);
            this.pageNhom.Controls.Add(this.txttennhom);
            this.pageNhom.Controls.Add(this.label1);
            this.pageNhom.Name = "pageNhom";
            this.pageNhom.Size = new System.Drawing.Size(615, 259);
            this.pageNhom.Text = "Thông tin nhóm";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(202, 104);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(217, 23);
            this.txtmota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // txttennhom
            // 
            this.txttennhom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttennhom.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txttennhom.Location = new System.Drawing.Point(202, 61);
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Size = new System.Drawing.Size(217, 23);
            this.txttennhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // pageThanhvien
            // 
            this.pageThanhvien.Controls.Add(this.btnbot);
            this.pageThanhvien.Controls.Add(this.btnthem);
            this.pageThanhvien.Controls.Add(this.gcThanhvien);
            this.pageThanhvien.Name = "pageThanhvien";
            this.pageThanhvien.Size = new System.Drawing.Size(615, 259);
            this.pageThanhvien.Text = "Thành viên";
            // 
            // btnbot
            // 
            this.btnbot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbot.ImageOptions.Image")));
            this.btnbot.Location = new System.Drawing.Point(459, 217);
            this.btnbot.Name = "btnbot";
            this.btnbot.Size = new System.Drawing.Size(94, 29);
            this.btnbot.TabIndex = 2;
            this.btnbot.Text = "Bớt";
            this.btnbot.Click += new System.EventHandler(this.btnbot_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(344, 217);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 29);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // gcThanhvien
            // 
            this.gcThanhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThanhvien.Location = new System.Drawing.Point(0, 0);
            this.gcThanhvien.MainView = this.gvthanhvien;
            this.gcThanhvien.Name = "gcThanhvien";
            this.gcThanhvien.Size = new System.Drawing.Size(615, 200);
            this.gcThanhvien.TabIndex = 0;
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
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.Location = new System.Drawing.Point(318, 305);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(121, 43);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(460, 305);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 43);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.tabGroup);
            this.Name = "frmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm người dùng";
            this.Load += new System.EventHandler(this.frmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabGroup)).EndInit();
            this.tabGroup.ResumeLayout(false);
            this.pageNhom.ResumeLayout(false);
            this.pageNhom.PerformLayout();
            this.pageThanhvien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabGroup;
        private DevExpress.XtraTab.XtraTabPage pageNhom;
        private DevExpress.XtraTab.XtraTabPage pageThanhvien;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennhom;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraGrid.GridControl gcThanhvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvthanhvien;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnbot;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
    }
}
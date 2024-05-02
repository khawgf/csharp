namespace USERMANAGEMENT
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.tabUser = new DevExpress.XtraTab.XtraTabControl();
            this.pageUser = new DevExpress.XtraTab.XtraTabPage();
            this.chkdisabled = new System.Windows.Forms.CheckBox();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pagegroup = new DevExpress.XtraTab.XtraTabPage();
            this.btnbot = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.gcThanhvien = new DevExpress.XtraGrid.GridControl();
            this.gvthanhvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabUser)).BeginInit();
            this.tabUser.SuspendLayout();
            this.pageUser.SuspendLayout();
            this.pagegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabUser.Location = new System.Drawing.Point(0, 0);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedTabPage = this.pageUser;
            this.tabUser.Size = new System.Drawing.Size(596, 303);
            this.tabUser.TabIndex = 0;
            this.tabUser.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageUser,
            this.pagegroup});
            // 
            // pageUser
            // 
            this.pageUser.Controls.Add(this.chkdisabled);
            this.pageUser.Controls.Add(this.txtrepass);
            this.pageUser.Controls.Add(this.label3);
            this.pageUser.Controls.Add(this.txtpass);
            this.pageUser.Controls.Add(this.label4);
            this.pageUser.Controls.Add(this.txthoten);
            this.pageUser.Controls.Add(this.label2);
            this.pageUser.Controls.Add(this.txtusername);
            this.pageUser.Controls.Add(this.label1);
            this.pageUser.Name = "pageUser";
            this.pageUser.Size = new System.Drawing.Size(594, 273);
            this.pageUser.Text = "Thông tin";
            // 
            // chkdisabled
            // 
            this.chkdisabled.AutoSize = true;
            this.chkdisabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkdisabled.Location = new System.Drawing.Point(178, 216);
            this.chkdisabled.Name = "chkdisabled";
            this.chkdisabled.Size = new System.Drawing.Size(110, 25);
            this.chkdisabled.TabIndex = 12;
            this.chkdisabled.Text = "DISABLED";
            this.chkdisabled.UseVisualStyleBackColor = true;
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(178, 167);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.Size = new System.Drawing.Size(294, 23);
            this.txtrepass.TabIndex = 11;
            this.txtrepass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // txtpass
            // 
            this.txtpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(178, 127);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(294, 23);
            this.txtpass.TabIndex = 9;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(178, 83);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(294, 23);
            this.txthoten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên";
            // 
            // txtusername
            // 
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtusername.Location = new System.Drawing.Point(178, 44);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(294, 23);
            this.txtusername.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // pagegroup
            // 
            this.pagegroup.Controls.Add(this.btnbot);
            this.pagegroup.Controls.Add(this.btnthem);
            this.pagegroup.Controls.Add(this.gcThanhvien);
            this.pagegroup.Name = "pagegroup";
            this.pagegroup.Size = new System.Drawing.Size(594, 273);
            this.pagegroup.Text = "Nhóm";
            // 
            // btnbot
            // 
            this.btnbot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbot.ImageOptions.Image")));
            this.btnbot.Location = new System.Drawing.Point(441, 241);
            this.btnbot.Name = "btnbot";
            this.btnbot.Size = new System.Drawing.Size(94, 29);
            this.btnbot.TabIndex = 4;
            this.btnbot.Text = "Bớt";
            this.btnbot.Click += new System.EventHandler(this.btnbot_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(326, 241);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 29);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // gcThanhvien
            // 
            this.gcThanhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThanhvien.Location = new System.Drawing.Point(0, 0);
            this.gcThanhvien.MainView = this.gvthanhvien;
            this.gcThanhvien.Name = "gcThanhvien";
            this.gcThanhvien.Size = new System.Drawing.Size(594, 218);
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
            this.btnThoat.Location = new System.Drawing.Point(442, 329);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 43);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.Location = new System.Drawing.Point(300, 329);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(121, 43);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 383);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.tabUser);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabUser)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.pageUser.ResumeLayout(false);
            this.pageUser.PerformLayout();
            this.pagegroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabUser;
        private DevExpress.XtraTab.XtraTabPage pageUser;
        private DevExpress.XtraTab.XtraTabPage pagegroup;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraGrid.GridControl gcThanhvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvthanhvien;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraEditors.SimpleButton btnbot;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkdisabled;
        private System.Windows.Forms.TextBox txtrepass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
    }
}
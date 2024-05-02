namespace USERMANAGEMENT
{
    partial class frmPhanQuyenChucNang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyenChucNang));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcusers = new DevExpress.XtraGrid.GridControl();
            this.gvusers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ISGROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcchucnang = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mncamquyen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnchixem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menutoanquyen = new System.Windows.Forms.ToolStripMenuItem();
            this.gvchucnang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FUNC_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cISGROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcchucnang)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvchucnang)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gcusers);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcchucnang);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(803, 484);
            this.splitContainerControl1.SplitterPosition = 277;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gcusers
            // 
            this.gcusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcusers.Location = new System.Drawing.Point(0, 0);
            this.gcusers.MainView = this.gvusers;
            this.gcusers.Name = "gcusers";
            this.gcusers.Size = new System.Drawing.Size(277, 484);
            this.gcusers.TabIndex = 0;
            this.gcusers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvusers});
            // 
            // gvusers
            // 
            this.gvusers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ISGROUP,
            this.USERNAME,
            this.FULLNAME,
            this.IDUSER});
            this.gvusers.GridControl = this.gcusers;
            this.gvusers.Name = "gvusers";
            this.gvusers.OptionsView.ShowGroupPanel = false;
            this.gvusers.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvusers_CustomDrawCell);
            this.gvusers.Click += new System.EventHandler(this.gvusers_Click);
            // 
            // ISGROUP
            // 
            this.ISGROUP.Caption = " ";
            this.ISGROUP.FieldName = "ISGROUP";
            this.ISGROUP.MaxWidth = 40;
            this.ISGROUP.MinWidth = 30;
            this.ISGROUP.Name = "ISGROUP";
            this.ISGROUP.Visible = true;
            this.ISGROUP.VisibleIndex = 0;
            this.ISGROUP.Width = 40;
            // 
            // USERNAME
            // 
            this.USERNAME.Caption = "USERNAME";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.MaxWidth = 100;
            this.USERNAME.MinWidth = 80;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 1;
            this.USERNAME.Width = 94;
            // 
            // FULLNAME
            // 
            this.FULLNAME.Caption = "FULLNAME";
            this.FULLNAME.FieldName = "FULLNAME";
            this.FULLNAME.MaxWidth = 150;
            this.FULLNAME.MinWidth = 120;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Visible = true;
            this.FULLNAME.VisibleIndex = 2;
            this.FULLNAME.Width = 120;
            // 
            // IDUSER
            // 
            this.IDUSER.Caption = "ID";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.MinWidth = 25;
            this.IDUSER.Name = "IDUSER";
            this.IDUSER.Width = 94;
            // 
            // gcchucnang
            // 
            this.gcchucnang.ContextMenuStrip = this.contextMenuStrip1;
            this.gcchucnang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcchucnang.Location = new System.Drawing.Point(0, 0);
            this.gcchucnang.MainView = this.gvchucnang;
            this.gcchucnang.Name = "gcchucnang";
            this.gcchucnang.Size = new System.Drawing.Size(514, 484);
            this.gcchucnang.TabIndex = 0;
            this.gcchucnang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvchucnang});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mncamquyen,
            this.toolStripSeparator1,
            this.mnchixem,
            this.toolStripSeparator2,
            this.menutoanquyen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 94);
            // 
            // mncamquyen
            // 
            this.mncamquyen.Image = ((System.Drawing.Image)(resources.GetObject("mncamquyen.Image")));
            this.mncamquyen.Name = "mncamquyen";
            this.mncamquyen.Size = new System.Drawing.Size(160, 26);
            this.mncamquyen.Text = "Khóa quyền";
            this.mncamquyen.Click += new System.EventHandler(this.mncamquyen_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // mnchixem
            // 
            this.mnchixem.Image = ((System.Drawing.Image)(resources.GetObject("mnchixem.Image")));
            this.mnchixem.Name = "mnchixem";
            this.mnchixem.Size = new System.Drawing.Size(160, 26);
            this.mnchixem.Text = "Chỉ xem";
            this.mnchixem.Click += new System.EventHandler(this.mnchixem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // menutoanquyen
            // 
            this.menutoanquyen.Image = ((System.Drawing.Image)(resources.GetObject("menutoanquyen.Image")));
            this.menutoanquyen.Name = "menutoanquyen";
            this.menutoanquyen.Size = new System.Drawing.Size(160, 26);
            this.menutoanquyen.Text = "Toàn quyền";
            this.menutoanquyen.Click += new System.EventHandler(this.menutoanquyen_Click_1);
            // 
            // gvchucnang
            // 
            this.gvchucnang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FUNC_CODE,
            this.DESCRIPTION,
            this.QUYEN,
            this.cISGROUP});
            this.gvchucnang.GridControl = this.gcchucnang;
            this.gvchucnang.Name = "gvchucnang";
            this.gvchucnang.OptionsView.ShowGroupPanel = false;
            // 
            // FUNC_CODE
            // 
            this.FUNC_CODE.Caption = "FUNC_CODE";
            this.FUNC_CODE.FieldName = "FUNC_CODE";
            this.FUNC_CODE.MinWidth = 25;
            this.FUNC_CODE.Name = "FUNC_CODE";
            this.FUNC_CODE.Width = 94;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Caption = "CHỨC NĂNG";
            this.DESCRIPTION.FieldName = "DESCRIPTION";
            this.DESCRIPTION.MaxWidth = 150;
            this.DESCRIPTION.MinWidth = 100;
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Visible = true;
            this.DESCRIPTION.VisibleIndex = 0;
            this.DESCRIPTION.Width = 100;
            // 
            // QUYEN
            // 
            this.QUYEN.Caption = "QUYEN";
            this.QUYEN.FieldName = "QUYEN";
            this.QUYEN.MaxWidth = 250;
            this.QUYEN.MinWidth = 200;
            this.QUYEN.Name = "QUYEN";
            this.QUYEN.Visible = true;
            this.QUYEN.VisibleIndex = 1;
            this.QUYEN.Width = 200;
            // 
            // cISGROUP
            // 
            this.cISGROUP.Caption = "GROUP";
            this.cISGROUP.FieldName = "ISGROUP";
            this.cISGROUP.MinWidth = 25;
            this.cISGROUP.Name = "cISGROUP";
            this.cISGROUP.Width = 94;
            // 
            // frmPhanQuyenChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 484);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmPhanQuyenChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Quyền Chức Năng";
            this.Load += new System.EventHandler(this.frmPhanQuyenChucNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcchucnang)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvchucnang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcusers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvusers;
        private DevExpress.XtraGrid.Columns.GridColumn ISGROUP;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.GridControl gcchucnang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvchucnang;
        private DevExpress.XtraGrid.Columns.GridColumn FUNC_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn QUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn cISGROUP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mncamquyen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnchixem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menutoanquyen;
    }
}
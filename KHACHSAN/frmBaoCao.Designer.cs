namespace KHACHSAN
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.splitbaocao = new DevExpress.XtraEditors.SplitContainerControl();
            this.lstdanhsach = new DevExpress.XtraEditors.ImageListBoxControl();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnthuchien = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitbaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitbaocao.Panel1)).BeginInit();
            this.splitbaocao.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitbaocao.Panel2)).BeginInit();
            this.splitbaocao.Panel2.SuspendLayout();
            this.splitbaocao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // splitbaocao
            // 
            this.splitbaocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitbaocao.Location = new System.Drawing.Point(0, 0);
            this.splitbaocao.Name = "splitbaocao";
            // 
            // splitbaocao.splitbaocao_Panel1
            // 
            this.splitbaocao.Panel1.Controls.Add(this.lstdanhsach);
            this.splitbaocao.Panel1.Text = "Panel1";
            // 
            // splitbaocao.splitbaocao_Panel2
            // 
            this.splitbaocao.Panel2.Controls.Add(this.btnthoat);
            this.splitbaocao.Panel2.Controls.Add(this.btnthuchien);
            this.splitbaocao.Panel2.Text = "Panel2";
            this.splitbaocao.Size = new System.Drawing.Size(847, 531);
            this.splitbaocao.SplitterPosition = 320;
            this.splitbaocao.TabIndex = 0;
            // 
            // lstdanhsach
            // 
            this.lstdanhsach.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstdanhsach.Appearance.Options.UseFont = true;
            this.lstdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstdanhsach.Location = new System.Drawing.Point(0, 0);
            this.lstdanhsach.Name = "lstdanhsach";
            this.lstdanhsach.Size = new System.Drawing.Size(320, 531);
            this.lstdanhsach.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(269, 437);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 45);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthuchien
            // 
            this.btnthuchien.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnthuchien.Appearance.Options.UseFont = true;
            this.btnthuchien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthuchien.ImageOptions.Image")));
            this.btnthuchien.Location = new System.Drawing.Point(125, 437);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(100, 45);
            this.btnthuchien.TabIndex = 0;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 531);
            this.Controls.Add(this.splitbaocao);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitbaocao.Panel1)).EndInit();
            this.splitbaocao.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitbaocao.Panel2)).EndInit();
            this.splitbaocao.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitbaocao)).EndInit();
            this.splitbaocao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstdanhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitbaocao;
        private DevExpress.XtraEditors.ImageListBoxControl lstdanhsach;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnthuchien;
    }
}
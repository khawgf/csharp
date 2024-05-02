namespace KHACHSAN
{
    partial class frmSetParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetParam));
            this.label1 = new System.Windows.Forms.Label();
            this.cbocongty = new System.Windows.Forms.ComboBox();
            this.cbodonvi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công ty - Chi nhánh";
            // 
            // cbocongty
            // 
            this.cbocongty.FormattingEnabled = true;
            this.cbocongty.Location = new System.Drawing.Point(33, 64);
            this.cbocongty.Name = "cbocongty";
            this.cbocongty.Size = new System.Drawing.Size(449, 24);
            this.cbocongty.TabIndex = 1;
            // 
            // cbodonvi
            // 
            this.cbodonvi.FormattingEnabled = true;
            this.cbodonvi.Location = new System.Drawing.Point(33, 124);
            this.cbodonvi.Name = "cbodonvi";
            this.cbodonvi.Size = new System.Drawing.Size(449, 24);
            this.cbodonvi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn vị";
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnxacnhan.Appearance.Options.UseFont = true;
            this.btnxacnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxacnhan.ImageOptions.Image")));
            this.btnxacnhan.Location = new System.Drawing.Point(217, 174);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(119, 40);
            this.btnxacnhan.TabIndex = 4;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(363, 174);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(119, 40);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmSetParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 241);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.cbodonvi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbocongty);
            this.Controls.Add(this.label1);
            this.Name = "frmSetParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn vị sử dụng";
            this.Load += new System.EventHandler(this.frmSetParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbocongty;
        private System.Windows.Forms.ComboBox cbodonvi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnxacnhan;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
    }
}
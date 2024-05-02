namespace KHACHSAN
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtusername.Location = new System.Drawing.Point(202, 114);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(274, 28);
            this.txtusername.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(202, 160);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(274, 28);
            this.txtpass.TabIndex = 4;
            // 
            // btnlogin
            // 
            this.btnlogin.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnlogin.Appearance.Options.UseFont = true;
            this.btnlogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.ImageOptions.Image")));
            this.btnlogin.Location = new System.Drawing.Point(142, 224);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(129, 44);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(324, 224);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(129, 44);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(202, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(207, 41);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "ĐĂNG NHẬP";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(84, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 22);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "USERNAME";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(84, 162);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 22);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "PASSWORD";
            // 
            // checkButton1
            // 
            this.checkButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkButton1.ImageOptions.Image")));
            this.checkButton1.Location = new System.Drawing.Point(493, 167);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(24, 15);
            this.checkButton1.TabIndex = 10;
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::KHACHSAN.Properties.Resources.login1;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(604, 295);
            this.ControlBox = false;
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private DevExpress.XtraEditors.SimpleButton btnlogin;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckButton checkButton1;
    }
}
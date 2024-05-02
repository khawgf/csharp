namespace KHACHSAN.Mycontrols
{
    partial class ucDonVi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbodonvi = new System.Windows.Forms.ComboBox();
            this.cbocongty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Công ty/Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn vị";
            // 
            // cbodonvi
            // 
            this.cbodonvi.FormattingEnabled = true;
            this.cbodonvi.Location = new System.Drawing.Point(15, 109);
            this.cbodonvi.Name = "cbodonvi";
            this.cbodonvi.Size = new System.Drawing.Size(483, 24);
            this.cbodonvi.TabIndex = 3;
            // 
            // cbocongty
            // 
            this.cbocongty.FormattingEnabled = true;
            this.cbocongty.Location = new System.Drawing.Point(19, 55);
            this.cbocongty.Name = "cbocongty";
            this.cbocongty.Size = new System.Drawing.Size(483, 24);
            this.cbocongty.TabIndex = 5;
            // 
            // ucDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbocongty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbodonvi);
            this.Controls.Add(this.label1);
            this.Name = "ucDonVi";
            this.Size = new System.Drawing.Size(550, 156);
            this.Load += new System.EventHandler(this.ucDonVi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbodonvi;
        public System.Windows.Forms.ComboBox cbocongty;
    }
}

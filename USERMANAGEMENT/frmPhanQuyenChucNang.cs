using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USERMANAGEMENT
{
    public partial class frmPhanQuyenChucNang : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyenChucNang()
        {
            InitializeComponent();
        }
        public int _iduser;
        public string _macty;
        public string _madvi;
        SYS_USER _sysuser;

        SYS_RIGHT _sysright;

        private void frmPhanQuyenChucNang_Load(object sender, EventArgs e)
        {
            _sysright = new SYS_RIGHT();
            _sysuser = new SYS_USER();
            loaduser();
            loadfuncbyuser();
            gvchucnang.RowStyle += Gvchucnang_RowStyle;
        }

        private void Gvchucnang_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle>=0)
            {
                bool isred = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns["ISGROUP"] ));
                if (isred)
                {
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.Font = new Font("Tahoma",12,FontStyle.Bold);
                }
            }
        }

        void loaduser()
        {
            if (_macty==null && _madvi==null)
            {
                gcusers.DataSource = _sysuser.getuserbyDVIfunc("CT01","~");
                gvusers.OptionsBehavior.Editable = false;
            }
            else
            {
                gcusers.DataSource = _sysuser.getuserbyDVIfunc(_macty,_madvi);
                gvusers.OptionsBehavior.Editable = false;
            }
        }

        void loadfuncbyuser()
        {
            VIEW_FUNC_SYS_RIGHT _vfuncright =new VIEW_FUNC_SYS_RIGHT();
            gcchucnang.DataSource = _vfuncright.getfuncbyuser(_iduser);
            gvchucnang.OptionsBehavior.Editable = false;
            for (int i = 0; i < gvusers.RowCount; i++)
            {
                if (int.Parse(gvusers.GetRowCellValue(i,"IDUSER").ToString())==_iduser)
                {
                    gvusers.ClearSelection();
                    gvusers.FocusedRowHandle = i;
                }
            }
            gvchucnang.ClearSelection();

        }

        private void gvusers_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "ISGROUP" && bool.Parse(e.CellValue.ToString()) == true)
            {
                Image img = Properties.Resources.team;
                int newWidth = 16; // Đặt chiều rộng mới
                int newHeight = 16; // Đặt chiều cao mới
                int x = e.Bounds.X + (e.Bounds.Width - newWidth) / 2; // Canh lề giữa theo chiều ngang
                int y = e.Bounds.Y + (e.Bounds.Height - newHeight) / 2; // Canh lề giữa theo chiều dọc
                e.Graphics.DrawImage(img, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
            if (e.Column.Name == "ISGROUP" && bool.Parse(e.CellValue.ToString()) == false)
            {
                Image img = Properties.Resources.user;
                int newWidth = 16; // Đặt chiều rộng mới
                int newHeight = 16; // Đặt chiều cao mới
                int x = e.Bounds.X + (e.Bounds.Width - newWidth) / 2; // Canh lề giữa theo chiều ngang
                int y = e.Bounds.Y + (e.Bounds.Height - newHeight) / 2; // Canh lề giữa theo chiều dọc
                e.Graphics.DrawImage(img, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        private void mncamquyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvchucnang.RowCount; i++)
            {
                if (gvchucnang.IsRowSelected(i))
                {
                    _sysright.update(_iduser,gvchucnang.GetRowCellValue(i,"FUNC_CODE").ToString(),0);
                }
            }
            loadfuncbyuser();
        }

        private void mnchixem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvchucnang.RowCount; i++)
            {
                if (gvchucnang.IsRowSelected(i))
                {
                    _sysright.update(_iduser, gvchucnang.GetRowCellValue(i, "FUNC_CODE").ToString(), 1);
                }
            }
            loadfuncbyuser();
        }

        private void menutoanquyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvchucnang.RowCount; i++)
            {
                if (gvchucnang.IsRowSelected(i))
                {
                    _sysright.update(_iduser, gvchucnang.GetRowCellValue(i, "FUNC_CODE").ToString(), 2);
                }
            }
            loadfuncbyuser();
        }

        private void gvusers_Click(object sender, EventArgs e)
        {
            _iduser = int.Parse(gvusers.GetFocusedRowCellValue("IDUSER").ToString());
            loadfuncbyuser();
        }

        private void mncamquyen_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < gvchucnang.RowCount; i++)
            {
                if (gvchucnang.IsRowSelected(i))
                {
                    _sysright.update(_iduser, gvchucnang.GetRowCellValue(i, "FUNC_CODE").ToString(), 0);
                }

                
            }
            loadfuncbyuser();
        }

        private void mnchixem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < gvchucnang.RowCount; i++)
            {
                if (gvchucnang.IsRowSelected(i))
                {
                    _sysright.update(_iduser, gvchucnang.GetRowCellValue(i, "FUNC_CODE").ToString(), 1);
                }

                
            }
            loadfuncbyuser();
        }

        private void menutoanquyen_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < gvchucnang.RowCount; i++)
            {
                if (gvchucnang.IsRowSelected(i))
                {
                    _sysright.update(_iduser, gvchucnang.GetRowCellValue(i, "FUNC_CODE").ToString(), 2);
                }

                
            }
            loadfuncbyuser();
        }
    }
}
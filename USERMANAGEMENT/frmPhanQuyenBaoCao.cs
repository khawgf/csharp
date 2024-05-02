using BusinessLayer;
using DevExpress.XtraEditors;
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
    public partial class frmPhanQuyenBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyenBaoCao()
        {
            InitializeComponent();
        }
        public int _iduser;
        public string _macty;
        public string _madvi;

        SYS_USER _sysuser;
        SYS_RIGHT_REP _sysrightrep;


        private void frmPhanQuyenBaoCao_Load(object sender, EventArgs e)
        {
            _sysrightrep = new SYS_RIGHT_REP();
            _sysuser = new SYS_USER();
            loaduser();
            loadrepbyuser();
        }
        void loaduser()
        {
            if (_macty == null && _madvi == null)
            {
                gcusers.DataSource = _sysuser.getuserbyDVIfunc("CT01", "~");
                gvusers.OptionsBehavior.Editable = false;
            }
            else
            {
                gcusers.DataSource = _sysuser.getuserbyDVIfunc(_macty, _madvi);
                gvusers.OptionsBehavior.Editable = false;
            }
        }
        void loadrepbyuser()
        {
            VIEW_REP_SYS_RIGHT_REP _vfuncright = new VIEW_REP_SYS_RIGHT_REP();
            gcchucnang.DataSource = _vfuncright.getrepbyuser(_iduser);
            gvchucnang.OptionsBehavior.Editable = false;
            for (int i = 0; i < gvusers.RowCount; i++)
            {
                if (int.Parse(gvusers.GetRowCellValue(i, "IDUSER").ToString()) == _iduser)
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
                    _sysrightrep.update(_iduser, int.Parse(gvchucnang.GetRowCellValue(i, "REP_CODE").ToString()), false);
                }
            }
            loadrepbyuser();
        }

        private void menutoanquyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvchucnang.RowCount; i++)
            {
                if (gvchucnang.IsRowSelected(i))
                {
                    _sysrightrep.update(_iduser, int.Parse(gvchucnang.GetRowCellValue(i, "REP_CODE").ToString()), true);
                }
            }
            loadrepbyuser();
        }

        private void gvusers_Click(object sender, EventArgs e)
        {
            _iduser = int.Parse(gvusers.GetFocusedRowCellValue("IDUSER").ToString());
            loadrepbyuser();
        }
    }
}
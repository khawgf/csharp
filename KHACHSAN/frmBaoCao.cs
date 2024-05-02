using BusinessLayer;
using CrystalDecisions.ReportAppServer.ReportDefModel;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using DevExpress.XtraEditors;
using KHACHSAN.Mycontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument;



namespace KHACHSAN
{
    public partial class frmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        public frmBaoCao(tb_SYS_USER user)
        {
            InitializeComponent();
            this._user = user;
        }
        tb_SYS_USER _user;
        SYS_USER _sysuser;
        SYS_REPORT _sysreport;
        SYS_RIGHT_REP _sysrightrep;
        Panel _panel;
        ucTuNgay _utungay;
        ucCongTy _ucongty;
        ucDonVi _udonvi;

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            _sysreport = new SYS_REPORT();
            _sysuser = new SYS_USER();
            _sysrightrep = new SYS_RIGHT_REP();
            lstdanhsach.DataSource= _sysreport.getlistbyright(_sysrightrep.getlistbyuser(_user.IDUSER));
            lstdanhsach.DisplayMember = "DESCRIPTION";
            lstdanhsach.ValueMember = "REP_CODE";
            lstdanhsach.SelectedValueChanged += Lstdanhsach_SelectedValueChanged;
            loadusercontrols();


        }

        private void Lstdanhsach_SelectedValueChanged(object sender, EventArgs e)
        {
            loadusercontrols();
        }

        void loadusercontrols()
        {
            tb_SYS_REPORT rep = _sysreport.getitem(int.Parse(lstdanhsach.SelectedValue.ToString()));
            if(_panel != null )
            {
                _panel.Dispose();
            }
            _panel = new Panel();
            _panel.Dock = DockStyle.Top;
            _panel.MinimumSize=new Size(_panel.Width,500);
            List<Control> _ctrl = new List<Control>();
            if (rep.TUNGAY ==true)
            {
                _utungay = new ucTuNgay();
                _utungay.Dock = DockStyle.Top;
                _ctrl.Add(_utungay);

            }
            if (rep.MACTY == true)
            {
                _ucongty = new ucCongTy();
                _ucongty.Dock = DockStyle.Top;
                _ctrl.Add(_ucongty);

            }
            if (rep.MADVI == true)
            {
                _udonvi = new ucDonVi();
                _udonvi.Dock = DockStyle.Top;
                _ctrl.Add(_udonvi);

            }
            _ctrl.Reverse();
            _panel.Controls.AddRange(_ctrl.ToArray());
            this.splitbaocao.Panel2.Controls.Add(_panel);

        }
        private void btnthuchien_Click(object sender, EventArgs e)
        {
            tb_SYS_REPORT rp = _sysreport.getitem(int.Parse(lstdanhsach.SelectedValue.ToString()));
            Form frm = new Form();
            CrystalReportViewer Crv = new CrystalReportViewer();
            Crv.ShowGroupTreeButton = false;
            Crv.ShowParameterPanelButton = false;
            Crv.ToolPanelView = ToolPanelViewType.None;

            TableLogOnInfo Thongtin;

            // Tạo đối tượng ReportDocument
            ReportDocument doc = new ReportDocument();
            doc.Load("D:\\DACN\\doan\\QUANLYKHACHSAN\\KHACHSAN\\REP_DOANHTHU_CONGTY_NGAY.rpt");

            // Chỉ định thông tin kết nối cơ sở dữ liệu
            Thongtin = doc.Database.Tables[0].LogOnInfo;
            Thongtin.ConnectionInfo.ServerName = ".";
            Thongtin.ConnectionInfo.DatabaseName = "QLKS";
            Thongtin.ConnectionInfo.UserID = "sa";
            Thongtin.ConnectionInfo.Password = "123";

            // Áp dụng thông tin kết nối
            doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
            if (rp.TUNGAY==true)
            {
                doc.SetParameterValue("@NGAYD", _utungay.dtTuNgay.Value);
                doc.SetParameterValue("@NGAYC", _utungay.dtDenNgay.Value);
            }
            if (rp.MACTY == true)
            {
                doc.SetParameterValue("@MACTY", myFunctions._macty);

            }
            if (rp.MADVI == true)
            {
                doc.SetParameterValue("@MACTY", myFunctions._macty);
                doc.SetParameterValue("@MADVI", myFunctions._madvi);

            }


            Crv.Dock = DockStyle.Fill;
            Crv.ReportSource = doc;
            frm.Controls.Add(Crv);
            Crv.Refresh();
            frm.Text = rp.DESCRIPTION;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();



        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

            
        
    }
}
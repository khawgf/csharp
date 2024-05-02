using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KHACHSAN
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(tb_SYS_USER user)
        {
            InitializeComponent();
            this._user = user;
            this.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN - " + _user.FULLNAME;
        }
        tb_SYS_USER _user;
        SYS_PARAM _sysparam;
        FUNC _func;
        TANG _tang;
        PHONG _phong;
        DATPHONG _datphong;
        SYS_GROUP _sysgroup;
        SYS_RIGHT _sysright;
        GalleryItem item = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
             _func = new FUNC();
             _tang = new TANG();
            _phong = new PHONG();
            _sysgroup = new SYS_GROUP();
            _sysright = new SYS_RIGHT();
            _datphong = new DATPHONG();
            leftmenu();
            berore_showroom();
            showRoom();
        }

        void berore_showroom()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("sysparam.ini", FileMode.Open, FileAccess.Read);
            _sysparam = (SYS_PARAM)bf.Deserialize(fs);
            fs.Close();
            myFunctions._macty = _sysparam.macty;
            myFunctions._madvi = _sysparam.madvi;
            // Set TRANGTHAI to false for all rows
            myFunctions.ThucHienLenh("UPDATE tb_Phong\r\nSET TRANGTHAI = 0;");

            // Set TRANGTHAI to true for specific rows
            myFunctions.ThucHienLenh($"UPDATE tb_Phong\r\nSET TRANGTHAI = 1 \r\nWHERE IDPHONG IN (\r\n    SELECT IDPHONG\r\n    FROM tb_DatPhong_CT\r\n    WHERE IDDP IN (\r\n        SELECT IDDP\r\n        FROM tb_DatPhong\r\n        WHERE MACTY = '{myFunctions._macty}' AND MADVI = '{myFunctions._madvi}' AND DISABLED = 0\r\n    )\r\n);");
        }


        void leftmenu()
        {
            int i=0;
            var _isparent = _func.getParent();
            foreach (var _pr in _isparent)
            {
                NavBarGroup navBarGroup = new NavBarGroup(_pr.DESCRIPTION);
                navBarGroup.Tag = _pr.FUNC_CODE;
                navBarGroup.Name = _pr.FUNC_CODE;
                navMain.Groups.Add(navBarGroup);
                navBarGroup.ImageOptions.LargeImageIndex = i;
                i++;

                var _ischild = _func.getChild(_pr.FUNC_CODE);
                foreach (var _ch in _ischild)
                {
                    NavBarItem navBarItem = new NavBarItem(_ch.DESCRIPTION);
                    navBarItem.Tag = _ch.FUNC_CODE;
                    navBarItem.Name = _ch.FUNC_CODE;
                    navBarItem.ImageOptions.SmallImageIndex = 0;
                    navBarGroup.ItemLinks.Add(navBarItem);
                }
                navMain.Groups[navBarGroup.Name].Expanded = true;
            }
        }

        public void showRoom()
        {
            _tang = new TANG();
            _phong = new PHONG();
            var istang = _tang.getall();
            gControl.Gallery.ItemImageLayout=ImageLayoutMode.ZoomInside ;
            gControl.Gallery.ImageSize= new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            foreach (var t in istang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.TENTANG;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                var isphong = _phong.getbyTang(t.IDTANG);
                foreach (var p in isphong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = p.TENPHONG;
                    gc_item.Value = p.IDPHONG;
                    if (p.TRANGTHAI==true)
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[1];
                    }
                    else
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[0];
                    }
                    
                    galleryItem.Items.Add(gc_item);
                }
                gControl.Gallery.Groups.Add(galleryItem);
            }
            
        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();
            var _group = _sysgroup.getgroupbymember(_user.IDUSER);
            var _uright = _sysright.getright(_user.IDUSER,func_code);
            if (_group!=null)
            {
                var _groupright = _sysright.getright(_group.GROUP,func_code);
                if (_uright.USER_RIGHT<_groupright.USER_RIGHT)
                {
                    _uright.USER_RIGHT = _groupright.USER_RIGHT;
                }
            }
            if (_uright.USER_RIGHT==0)
            {
                MessageBox.Show("Không có quyền thao tác !!!", "notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (func_code)
                {
                    case "CONGTY":
                        {
                            frmCongTy frm = new frmCongTy(_user,_uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "DONVI":
                        {
                            frmDonVi frm = new frmDonVi(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "TANG":
                        {
                            frmTang frm = new frmTang(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "LOAIPHONG":
                        {
                            frmLoaiPhong frm = new frmLoaiPhong(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "PHONG":
                        {
                            frmPhong frm = new frmPhong(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "PHONG_THIETBI":
                        {
                            frmPhongThietbi frm = new frmPhongThietbi(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "THIETBI":
                        {
                            frmThietBi frm = new frmThietBi(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "KHACHHANG":
                        {
                            frmKhachHang frm = new frmKhachHang(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "SANPHAM":
                        {
                            frmSanPham frm = new frmSanPham(_user, _uright.USER_RIGHT.Value);
                            frm.ShowDialog();
                            break;
                        }
                    case "DATPHONG":
                        {
                            frmDatPhong frm = new frmDatPhong();
                            frm.ShowDialog();
                            break;
                        }
                    case "NGUOIDUNG":
                        {
                            MessageBox.Show("Chỉ dành cho quản trị", "notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }



                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            File.Delete("sysparam.ini");
            Application.Exit();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao(_user);
            frm.ShowDialog();

        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                item = hitInfo.GalleryItem;
            }
        }

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedRoomID = int.Parse(item.Value.ToString());
            bool isRoomBooked = _datphong.CheckDP(selectedRoomID);

            if (isRoomBooked)
            {
                MessageBox.Show("Phòng đã được đặt. Hãy chọn phòng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmDatPhongDon frm = new frmDatPhongDon();
                frm._idphong = selectedRoomID;
                frm._them = true;
                frm.ShowDialog();
            }
        }

       

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedRoomID = int.Parse(item.Value.ToString());
            bool isRoomBooked = _datphong.CheckDP(selectedRoomID);

            if (!isRoomBooked)
            {
                MessageBox.Show("Phòng chưa được đặt. Không thể thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmDatPhongDon frm = new frmDatPhongDon();
                frm._idphong = selectedRoomID;
                frm._them = false;
                frm.ShowDialog();
            }
        }

        private void btnChuyenPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedRoomID = int.Parse(item.Value.ToString());
            bool isRoomBooked = _datphong.CheckDP(selectedRoomID);

            if (!isRoomBooked)
            {
                MessageBox.Show("Phòng chưa được đặt. Không thể chuyển phòng.","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                frmChuyenPhong frm = new frmChuyenPhong();
                frm._idphong = selectedRoomID;
                frm.ShowDialog();
            }
        }

        private void btnSPDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedRoomID = int.Parse(item.Value.ToString());
            bool isRoomBooked = _datphong.CheckDP(selectedRoomID);

            if (!isRoomBooked)
            {
                MessageBox.Show("Phòng chưa được đặt. Không thể cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmDatPhongDon frm = new frmDatPhongDon();
                frm._idphong = selectedRoomID;
                frm._them = false;
                frm.ShowDialog();
            }
        }
    }
}
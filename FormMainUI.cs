using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO_KFC;
using BUS_KFC;

namespace KFC
{
    public partial class FormMainUI : Form
    {
        string _MaNV;
        BUS_HoSoNhanVien hsnv = new BUS_HoSoNhanVien();
        BUS_TaiKhoan bus_taikhoan = new BUS_TaiKhoan();
        BUS_PhanQuyen bus_phanquyen = new BUS_PhanQuyen();
        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;
            }
        }
        public FormMainUI()
        {
            InitializeComponent();
        }
        private void FormMainUI_Load(object sender, EventArgs e)
        {
            anhNhanVien.Image = ByteToImg(hsnv.getFileAnh(MaNV));
            lblHoTenNV.Text = hsnv.getTenvaCD(MaNV).Rows[0].Field<string>(0);
            lblTenCD.Text = hsnv.getTenvaCD(MaNV).Rows[0].Field<string>(1);
            addUserControl();
            visibleUserConTrol();
            panelHome.Controls[0].Visible = true;   
        }
        private void addUserControl()
        {
            FormGoiMon goimon = new FormGoiMon();
            goimon.MaNV = this.MaNV;
            FormSanPham sanpham = new FormSanPham();
            sanpham.HoTenNV = lblHoTenNV.Text;
            FormNhanSu nhansu = new FormNhanSu();
            FormQLLuong luong = new FormQLLuong();
            FormThongKe thongke = new FormThongKe();
            FormHeThong hethong = new FormHeThong();
            hethong.TenTaiKhoan = bus_taikhoan.getTenTaiKhoan(MaNV);
            KhongCoQuyen khong = new KhongCoQuyen();
            panelHome.Controls.Add(goimon);
            panelHome.Controls.Add(sanpham);
            panelHome.Controls.Add(nhansu);
            panelHome.Controls.Add(luong);
            panelHome.Controls.Add(thongke);
            panelHome.Controls.Add(hethong);
            panelHome.Controls.Add(khong);
        }
        private void visibleUserConTrol()
        {
            panelHome.Controls[0].Visible = false;
            panelHome.Controls[1].Visible = false;
            panelHome.Controls[2].Visible = false;
            panelHome.Controls[3].Visible = false;
            panelHome.Controls[4].Visible = false;
            panelHome.Controls[5].Visible = false;
            panelHome.Controls[6].Visible = false;
            panelHome.Controls[7].Visible = false;
        }
        private bool checkPhanQuyen(int i)
        {
            string tenquyen = bus_phanquyen.getTenQuyen(bus_taikhoan.getTenTaiKhoan(MaNV));
            if (i == 1)
            {
                if (tenquyen.Contains("1") == true) return true;
                else return false;
            }
            if (i == 2)
            {
                if (tenquyen.Contains("2") == true) return true;
                else return false;
            }
            if (i == 3)
            {
                if (tenquyen.Contains("3") == true) return true;
                else return false;
            }
            if (i == 4)
            {
                if (tenquyen.Contains("4") == true) return true;
                else return false;
            }
            if (i == 5)
            {
                if (tenquyen.Contains("5") == true) return true;
                else return false;
            }
            else return false;
        }    
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            visibleUserConTrol();
            panelHome.Controls[0].Visible = true;
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            visibleUserConTrol();
            if (checkPhanQuyen(1)) panelHome.Controls[1].Visible = true;
            else panelHome.Controls[7].Visible = true;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            visibleUserConTrol();
            if (checkPhanQuyen(2)) panelHome.Controls[2].Visible = true;
            else panelHome.Controls[7].Visible = true;
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            visibleUserConTrol();
            if (checkPhanQuyen(3)) panelHome.Controls[3].Visible = true;
            else panelHome.Controls[7].Visible = true;
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            visibleUserConTrol();
            if (checkPhanQuyen(4)) panelHome.Controls[4].Visible = true;
            else panelHome.Controls[7].Visible = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            visibleUserConTrol();
            if (checkPhanQuyen(5)) panelHome.Controls[5].Visible = true;
            else panelHome.Controls[7].Visible = true;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            visibleUserConTrol();
            panelHome.Controls[6].Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void changeColorAll()
        {
            //iconBtnQLNV.BackColor = Color.FromArgb(29, 29, 66);
            
        }
    }
}

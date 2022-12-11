using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_KFC;
using BUS_KFC;

namespace KFC
{
    public partial class FormPhanQuyen : Form
    {
        BUS_PhanQuyen bus_phanquyen = new BUS_PhanQuyen();
        public FormPhanQuyen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            cbbTenTaiKhoan.DataSource = bus_phanquyen.getAllTenDangNhap();
            cbbTenTaiKhoan.DisplayMember = "TenTaiKhoan";
            cbbTenTaiKhoan.SelectedItem = null;
        }
        private void danhCheckBox(string tenquyen)
        {
            if (tenquyen.Contains("1")) cb1.Checked = true;
            else cb1.Checked = false;
            if (tenquyen.Contains("2")) cb2.Checked = true;
            else cb2.Checked = false;
            if (tenquyen.Contains("3")) cb3.Checked = true;
            else cb3.Checked = false;
            if (tenquyen.Contains("4")) cb4.Checked = true;
            else cb4.Checked = false;
            if (tenquyen.Contains("5")) cb5.Checked = true;
            else cb5.Checked = false;
            if (tenquyen.Contains("6")) cb6.Checked = true;
            else cb6.Checked = false;
        }
        private string checkCheckBox()
        {
            string tenquyen = "";
            if (cb1.Checked == true) tenquyen += "1";
            if (cb2.Checked == true) tenquyen += "2";
            if (cb3.Checked == true) tenquyen += "3";
            if (cb4.Checked == true) tenquyen += "4";
            if (cb5.Checked == true) tenquyen += "5";
            if (cb6.Checked == true) tenquyen += "6";
            return tenquyen;
        }    
        private void cbbTenTaiKhoan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtHoTenNV.Text = bus_phanquyen.getTenNV(cbbTenTaiKhoan.Text);
            string tenquyen = bus_phanquyen.getTenQuyen(cbbTenTaiKhoan.Text);
            danhCheckBox(tenquyen);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tentaikhoan = cbbTenTaiKhoan.Text;
            DTO_PhanQuyen pq = new DTO_PhanQuyen(tentaikhoan, checkCheckBox(), "");
            if (bus_phanquyen.themsuaPhanQuyen(pq)) MessageBox.Show("Lưu thành công!");
            else MessageBox.Show("Lưu không thành công!");
        }
    }
}

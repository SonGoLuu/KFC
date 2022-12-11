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
    public partial class FormQLNguoiDung : UserControl
    {
        BUS_TaiKhoan bus_taikhoan = new BUS_TaiKhoan();
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public FormQLNguoiDung()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormQLNguoiDung_Load(object sender, EventArgs e)
        {
            cbbHoTenNV.DataSource = bus_taikhoan.getAllCBBNV();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedItem = null;
            dgvTaiKhoan.DataSource = bus_taikhoan.getAllTaiKhoan();
            chePass();
        }
        private void refreshAll()
        {
            cbbHoTenNV.DataSource = bus_taikhoan.getAllCBBNV();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedItem = null;
            dgvTaiKhoan.DataSource = bus_taikhoan.getAllTaiKhoan();
            txtTenTaiKhoan.Text = null;
            txtMatKhau.Text = null;
            chePass();
        }    
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
            cbbHoTenNV.DataSource = bus_taikhoan.getCBBNV();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedItem = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string manv = bus_nhanvien.getMaNV(cbbHoTenNV.Text);
            if (bus_taikhoan.themTaiKhoan(tentaikhoan, matkhau, manv)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (bus_taikhoan.suaTaiKhoan(tentaikhoan, matkhau)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txtTenTaiKhoan.Text;
            if (bus_taikhoan.xoaTaiKhoan(tentaikhoan)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbHoTenNV.DataSource = bus_taikhoan.getAllCBBNV();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedItem = null;
            txtTenTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
            txtMatKhau.Text = bus_taikhoan.getMatKhau(txtTenTaiKhoan.Text);
            cbbHoTenNV.SelectedIndex = cbbHoTenNV.FindStringExact(dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString());
        }
        private void chePass()
        {
            foreach(DataGridViewRow row in dgvTaiKhoan.Rows)
            {
                row.Cells[3].Value = "*******";
            }    
        }    
    }
}

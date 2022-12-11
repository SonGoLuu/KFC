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
    public partial class FormChucDanh : UserControl
    {
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        BUS_NVChucDanh bus_nvchucdanh = new BUS_NVChucDanh();
        public FormChucDanh()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void refreshAll()
        {
            cbbHoTenNV.DataSource = bus_nvchucdanh.getcbbNVMoi();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedItem = null;
            cbbTenCD.SelectedItem = null;
            dgvNVChucDanh.DataSource = bus_nvchucdanh.getAllChucDanh();
        }    

        private void FormChucDanh_Load(object sender, EventArgs e)
        {
            refreshAll();
            cbbTenCD.DataSource = bus_nvchucdanh.getcbbCD();
            cbbTenCD.DisplayMember = "TenCD";
            cbbTenCD.SelectedItem = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = bus_nhanvien.getMaNV(cbbHoTenNV.Text);
            string macd = bus_nvchucdanh.getMaCD(cbbTenCD.Text);
            DTO_NhanVien nv = new DTO_NhanVien(manv, macd);
            if (bus_nvchucdanh.themsuaNVChucDanh(nv)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = bus_nhanvien.getMaNV(cbbHoTenNV.Text);
            string macd = bus_nvchucdanh.getMaCD(cbbTenCD.Text);
            DTO_NhanVien nv = new DTO_NhanVien(manv, macd);
            if (bus_nvchucdanh.themsuaNVChucDanh(nv)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = bus_nhanvien.getMaNV(cbbHoTenNV.Text);
            if (bus_nvchucdanh.xoaNVChucDanh(manv)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void dgvNVChucDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbHoTenNV.DataSource = bus_nvchucdanh.getcbbNV();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedIndex = cbbHoTenNV.FindStringExact(dgvNVChucDanh.CurrentRow.Cells[0].Value.ToString());
            cbbTenCD.SelectedIndex = cbbTenCD.FindStringExact(dgvNVChucDanh.CurrentRow.Cells[1].Value.ToString());
        }
    }
}

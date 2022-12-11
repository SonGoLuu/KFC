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
    public partial class FormQLNhanVien : UserControl
    {
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void refreshAll()
        {
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDTNV.Text = "";
            dgvNhanVien.DataSource = bus_nhanvien.loadDgvNhanVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string hotennv = txtHoTenNV.Text;
            string cmnd = txtCMND.Text;
            string diachi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string sdtnv = txtSDTNV.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string gioitinh = cbbGioiTinh.Text;
            DTO_NhanVien nv = new DTO_NhanVien(manv, hotennv, ngaysinh, cmnd, diachi, email, sdtnv, gioitinh);
            if (bus_nhanvien.themNhanVien(nv)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string hotennv = txtHoTenNV.Text;
            string cmnd = txtCMND.Text;
            string diachi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string sdtnv = txtSDTNV.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string gioitinh = cbbGioiTinh.Text;
            DTO_NhanVien nv = new DTO_NhanVien(manv, hotennv, ngaysinh, cmnd, diachi, email, sdtnv, gioitinh);
            if (bus_nhanvien.suaNhanVien(nv)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            if (bus_nhanvien.xoaNhanVien(manv)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus_nhanvien.loadDgvNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells[2].Value.ToString());
            cbbGioiTinh.SelectedIndex = cbbGioiTinh.FindStringExact(dgvNhanVien.CurrentRow.Cells[3].Value.ToString());
            txtCMND.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtSDTNV.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = bus_nhanvien.getMotNhanVien(txtMaNV.Text).Rows[0].Field<string>(5);
            txtEmail.Text = bus_nhanvien.getMotNhanVien(txtMaNV.Text).Rows[0].Field<string>(6);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "") dgvNhanVien.DataSource = bus_nhanvien.findNhanVien(txtFind.Text);
            else dgvNhanVien.DataSource = bus_nhanvien.loadDgvNhanVien();
        }

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            txtMaNV.Text = bus_nhanvien.getMaNVCuoi();
        }
    }
}

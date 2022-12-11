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
    public partial class FormLuong : UserControl
    {
        BUS_LuongChucDanh bus_luong = new BUS_LuongChucDanh();
        BUS_NVChucDanh bus_nvchucdanh = new BUS_NVChucDanh();
        public FormLuong()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormLuong_Load(object sender, EventArgs e)
        {
            dgvLuongChucDanh.DataSource = bus_luong.loadDgvLuongChucDanh();
        }

        private void refreshAll()
        {
            dgvLuongChucDanh.DataSource = bus_luong.loadDgvLuongChucDanh();
            txtTenCD.Text = "";
            txtTienLuong.Text = "";
            txtPhuCap.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string macd = bus_luong.getMaCDCuoi();
            string tencd = txtTenCD.Text;
            float tienluong = (float)Convert.ToDouble(txtTienLuong.Text);
            int phucap = Convert.ToInt32(txtPhuCap.Text);
            DTO_ChucDanh cd = new DTO_ChucDanh(macd, tencd);
            DTO_LuongChucDanh luongcd = new DTO_LuongChucDanh(macd, tienluong, phucap);
            if (bus_luong.themChucDanh(cd, luongcd)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string macd = bus_nvchucdanh.getMaCD(dgvLuongChucDanh.CurrentRow.Cells[0].Value.ToString());
            string tencd = txtTenCD.Text;
            float tienluong = (float)Convert.ToDouble(txtTienLuong.Text);
            int phucap = Convert.ToInt32(txtPhuCap.Text);
            DTO_ChucDanh cd = new DTO_ChucDanh(macd, tencd);
            DTO_LuongChucDanh luongcd = new DTO_LuongChucDanh(macd, tienluong, phucap);
            if (bus_luong.suaChucDanh(cd, luongcd)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string macd = bus_nvchucdanh.getMaCD(dgvLuongChucDanh.CurrentRow.Cells[0].Value.ToString());
            if (bus_luong.xoaChucDanh(macd)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void dgvLuongChucDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenCD.Text = dgvLuongChucDanh.CurrentRow.Cells[0].Value.ToString();
            txtTienLuong.Text = dgvLuongChucDanh.CurrentRow.Cells[1].Value.ToString();
            txtPhuCap.Text = dgvLuongChucDanh.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

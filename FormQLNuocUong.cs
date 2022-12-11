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
    public partial class FormQLNuocUong : UserControl
    {
        BUS_SanPham bus_sanpham = new BUS_SanPham();
        public FormQLNuocUong()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormQLNuocUong_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = bus_sanpham.getAllSanPham("nuocuong");
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSanPham.CurrentRow;
            txtMaSP.Text = row.Cells[0].Value.ToString();
            txtTenSP.Text = row.Cells[1].Value.ToString();
            txtSLTon.Text = row.Cells[2].Value.ToString();
        }

        private void refreshAll()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSLTon.Text = "";
            txtFind.Text = "";
            dgvSanPham.DataSource = bus_sanpham.getAllSanPham("nuocuong");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            int slton = Convert.ToInt32(txtSLTon.Text);
            DTO_SanPham sp = new DTO_SanPham(masp, tensp, "nuocuong", slton);
            if (bus_sanpham.themSanPham(sp)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            int slton = Convert.ToInt32(txtSLTon.Text);
            DTO_SanPham sp = new DTO_SanPham(masp, tensp, "nuocuong", slton);
            if (bus_sanpham.suaSanPham(sp)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            if (bus_sanpham.xoaSanPham(masp)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "") dgvSanPham.DataSource = bus_sanpham.findSP(txtFind.Text, "nuocuong");
            else dgvSanPham.DataSource = bus_sanpham.getAllSanPham("nuocuong");
        }

        private void txtMaSP_Enter(object sender, EventArgs e)
        {
            txtMaSP.Text = bus_sanpham.getMaSPCuoi();
        }
    }
}

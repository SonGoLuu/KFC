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
    public partial class FormQLNhaCungCap : UserControl
    {
        BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();
        public FormQLNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormQLNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = bus_ncc.getAllNhom();
        }
        private void refreshAll()
        {
            txtTenNCC.Text = "";
            dgvNCC.DataSource = bus_ncc.getAllNhom();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NhaCungCap nhom = new DTO_NhaCungCap(bus_ncc.getMaNCCCuoi(), txtTenNCC.Text);
            if (bus_ncc.themNCC(nhom)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manhom = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            DTO_NhaCungCap nhom = new DTO_NhaCungCap(manhom, txtTenNCC.Text);
            if (bus_ncc.suaNCC(nhom)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manhom = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            if (bus_ncc.xoaNCC(manhom)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

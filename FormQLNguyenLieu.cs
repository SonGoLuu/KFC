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
    public partial class FormQLNguyenLieu : UserControl
    {
        BUS_NguyenLieu bus_nguyenlieu = new BUS_NguyenLieu();
        public FormQLNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormQLNguyenLieu_Load(object sender, EventArgs e)
        {
            dgvNguyenLieu.DataSource = bus_nguyenlieu.getAllNguyenLieu();
        }

        private void refreshAll()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtDonVi.Text = "";
            txtSLTon.Text = "";
            txtFind.Text = "";
            dgvNguyenLieu.DataSource = bus_nguyenlieu.getAllNguyenLieu();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string manl = txtMaNL.Text;
            string tennl = txtTenNL.Text;
            string donvi = txtDonVi.Text;
            int slton = Convert.ToInt32(txtSLTon.Text);
            DTO_NguyenLieu nl = new DTO_NguyenLieu(manl, tennl, donvi, slton);
            if (bus_nguyenlieu.suaNguyenLieu(nl)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manl = txtMaNL.Text;
            if (bus_nguyenlieu.xoaNguyenLieu(manl)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNL.Text = dgvNguyenLieu.CurrentRow.Cells[0].Value.ToString();
            txtTenNL.Text = dgvNguyenLieu.CurrentRow.Cells[1].Value.ToString();
            txtDonVi.Text = dgvNguyenLieu.CurrentRow.Cells[2].Value.ToString();
            txtSLTon.Text = dgvNguyenLieu.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "") dgvNguyenLieu.DataSource = bus_nguyenlieu.findNL(txtFind.Text);
            else dgvNguyenLieu.DataSource = bus_nguyenlieu.getAllNguyenLieu();
        }
    }
}

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
    public partial class FormQLCTTD : UserControl
    {
        BUS_CTTD bus_cttd = new BUS_CTTD();
        public FormQLCTTD()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormQLCTTD_Load(object sender, EventArgs e)
        {
            dgvCTTD.DataSource = bus_cttd.getAllCTTD();
        }
        private void refreshAll()
        {
            txtMaTD.Text = "";
            txtTenTD.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSL.Text = "";
            txtFind.Text = "";
            dgvCTTD.DataSource = bus_cttd.getAllCTTD();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string matd = txtMaTD.Text;
            string masp = txtMaSP.Text;
            int sl = Convert.ToInt32(txtSL.Text);
            DTO_CTTD cttd = new DTO_CTTD(matd, masp, sl);
            if (bus_cttd.themCTTD(cttd)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string matd = txtMaTD.Text;
            string masp = txtMaSP.Text;
            int sl = Convert.ToInt32(txtSL.Text);
            DTO_CTTD cttd = new DTO_CTTD(matd, masp, sl);
            if (bus_cttd.suaCTTD(cttd)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matd = txtMaTD.Text;
            string masp = txtMaSP.Text;
            if (bus_cttd.xoaCTTD(matd, masp)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "") dgvCTTD.DataSource = bus_cttd.findCTTD(txtFind.Text);
            else dgvCTTD.DataSource = bus_cttd.getAllCTTD();
        }

        private void dgvCTTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTD.Text = dgvCTTD.CurrentRow.Cells[0].Value.ToString();
            txtTenTD.Text = dgvCTTD.CurrentRow.Cells[1].Value.ToString();
            txtMaSP.Text = dgvCTTD.CurrentRow.Cells[2].Value.ToString();
            txtTenSP.Text = dgvCTTD.CurrentRow.Cells[3].Value.ToString();
            txtSL.Text = dgvCTTD.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtMaTD_TextChanged(object sender, EventArgs e)
        {
            txtTenTD.Text = bus_cttd.getTenTD(txtMaTD.Text);
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            txtTenSP.Text = bus_cttd.getTenSP(txtMaSP.Text);
        }
    }
}

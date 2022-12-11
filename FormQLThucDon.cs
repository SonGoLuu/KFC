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
    public partial class FormQLThucDon : UserControl
    {
        BUS_ThucDon bus_thucdon = new BUS_ThucDon();
        public FormQLThucDon()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormQLThucDon_Load(object sender, EventArgs e)
        {
            dgvThucDon.DataSource = bus_thucdon.getAllThucDon();
            cbbTenNhom.DataSource = bus_thucdon.getCbbTenNhom();
            cbbTenNhom.DisplayMember = "TENNHOM";
            cbbTenNhom.SelectedItem = null;
        }

        private void refreshAll()
        {
            txtMaTD.Text = "";
            txtTenTD.Text = "";
            cbbTenNhom.SelectedItem = null;
            txtGiaBan.Text = "";
            txtChiTiet.Text = "";
            txtGiamGia.Text = "";
            txtFind.Text = "";
            dgvThucDon.DataSource = bus_thucdon.getAllThucDon();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string matd = txtMaTD.Text;
            string tentd = txtTenTD.Text;
            string manhom = bus_thucdon.getMaNhom(cbbTenNhom.Text);
            float giaban = (float)Convert.ToDouble(txtGiaBan.Text);
            string chitiet = txtChiTiet.Text;
            int giamgia = Convert.ToInt32(txtGiamGia.Text);
            DTO_ThucDon td = new DTO_ThucDon(matd, tentd, manhom, giaban, chitiet, giamgia);
            if (bus_thucdon.themThucDon(td)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string matd = txtMaTD.Text;
            string tentd = txtTenTD.Text;
            string manhom = bus_thucdon.getMaNhom(cbbTenNhom.Text);
            float giaban = (float)Convert.ToDouble(txtGiaBan.Text);
            string chitiet = txtChiTiet.Text;
            int giamgia = Convert.ToInt32(txtGiamGia.Text);
            DTO_ThucDon td = new DTO_ThucDon(matd, tentd, manhom, giaban, chitiet, giamgia);
            if (bus_thucdon.suaThucDon(td)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matd = txtMaTD.Text;
            if (bus_thucdon.xoaThucDon(matd)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTD.Text = dgvThucDon.CurrentRow.Cells[0].Value.ToString();
            txtTenTD.Text = dgvThucDon.CurrentRow.Cells[1].Value.ToString();
            cbbTenNhom.SelectedIndex = cbbTenNhom.FindStringExact(dgvThucDon.CurrentRow.Cells[2].Value.ToString());
            txtGiaBan.Text = dgvThucDon.CurrentRow.Cells[3].Value.ToString();
            txtChiTiet.Text = dgvThucDon.CurrentRow.Cells[4].Value.ToString();
            txtGiamGia.Text = dgvThucDon.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtMaTD_Enter(object sender, EventArgs e)
        {
            txtMaTD.Text = bus_thucdon.getMaTDCuoi();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "") dgvThucDon.DataSource = bus_thucdon.findTD(txtFind.Text);
            else dgvThucDon.DataSource = bus_thucdon.getAllThucDon();
        }
    }
}

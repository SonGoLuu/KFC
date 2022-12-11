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
    public partial class FormQLLoai : UserControl
    {
        BUS_NhomThucDon bus_nhom = new BUS_NhomThucDon();
        public FormQLLoai()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormQLLoai_Load(object sender, EventArgs e)
        {
            dgvNhomThucDon.DataSource = bus_nhom.getAllNhom();
        }
        private void refreshAll()
        {
            txtTenNH.Text = "";
            dgvNhomThucDon.DataSource = bus_nhom.getAllNhom();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NhomThucDon nhom = new DTO_NhomThucDon(bus_nhom.getMaNHCuoi(), txtTenNH.Text);
            if(bus_nhom.themNhom(nhom)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manhom = dgvNhomThucDon.CurrentRow.Cells[0].Value.ToString();
            DTO_NhomThucDon nhom = new DTO_NhomThucDon(manhom, txtTenNH.Text);
            if (bus_nhom.suaNhom(nhom)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manhom = dgvNhomThucDon.CurrentRow.Cells[0].Value.ToString();
            if (bus_nhom.xoaNhom(manhom)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void dgvNhomThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNH.Text = dgvNhomThucDon.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

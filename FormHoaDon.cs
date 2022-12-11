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
    public partial class FormHoaDon : UserControl
    {
        BUS_HoaDon bus_hoadon = new BUS_HoaDon();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = bus_hoadon.getAllHoaDon();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string mahd = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            FormThongKeCTHD cthd = new FormThongKeCTHD();
            cthd.mahd = mahd;
            cthd.ShowDialog();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "") dgvHoaDon.DataSource = bus_hoadon.find(txtFind.Text);
            else dgvHoaDon.DataSource = bus_hoadon.getAllHoaDon();
        }
    }
}

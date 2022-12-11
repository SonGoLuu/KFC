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
    public partial class FormPhieuNhap : UserControl
    {
        string _hotennv;
        BUS_PhieuNhap bus_phieunhap = new BUS_PhieuNhap();
        public FormPhieuNhap()
        {
            InitializeComponent();
        }
        public string HoTenNV
        {
            get
            {
                return _hotennv;
            }
            set
            {
                _hotennv = value;
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            FormLapPhieuNhap lpn = new FormLapPhieuNhap();
            lpn.HoTenNV = this.HoTenNV;
            lpn.ShowDialog();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormCTPN ctpn = new FormCTPN();
            ctpn.MaPhieu = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            ctpn.TenNCC = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            ctpn.HoTenNV = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            DateTime ngaylap = Convert.ToDateTime(dgvPhieuNhap.CurrentRow.Cells[3].Value);
            ctpn.NgayNhap = ngaylap.ToShortDateString();
            ctpn.TongTien = dgvPhieuNhap.CurrentRow.Cells[4].Value.ToString();
            ctpn.ShowDialog();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = bus_phieunhap.getAllPhieuNhap();
        }

        private void btnFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "") dgvPhieuNhap.DataSource = bus_phieunhap.find(txtFind.Text);
            else dgvPhieuNhap.DataSource = bus_phieunhap.getAllPhieuNhap();
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = bus_phieunhap.getAllPhieuNhap();
        }
    }
}

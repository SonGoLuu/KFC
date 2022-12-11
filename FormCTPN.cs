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
    public partial class FormCTPN : Form
    {
        string _maphieu;
        string _tenncc;
        string _ngaynhap;
        string _hotennv;
        string _tongtien;
        BUS_ChiTietPhieuNhap bus_ctpn = new BUS_ChiTietPhieuNhap();
        public FormCTPN()
        {
            InitializeComponent();
        }
        public string MaPhieu
        {
            get
            {
                return _maphieu;
            }
            set
            {
                _maphieu = value;
            }
        }
        public string TenNCC
        {
            get
            {
                return _tenncc;
            }
            set
            {
                _tenncc = value;
            }
        }
        public string NgayNhap
        {
            get
            {
                return _ngaynhap;
            }
            set
            {
                _ngaynhap = value;
            }
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
        public string TongTien
        {
            get
            {
                return _tongtien;
            }
            set
            {
                _tongtien = value;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCTPN_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Text = this.MaPhieu;
            txtTenNCC.Text = this.TenNCC;
            txtNgayLap.Text = this.NgayNhap;
            txtHoTenNV.Text = this.HoTenNV;
            txtTongTien.Text = this.TongTien;
            dgvCTPN.DataSource = bus_ctpn.getCTPN(txtMaPhieu.Text);
        }
    }
}

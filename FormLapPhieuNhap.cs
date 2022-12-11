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
    public partial class FormLapPhieuNhap : Form
    {
        string _hotennv;
        BUS_ChiTietPhieuNhap bus_ctpn = new BUS_ChiTietPhieuNhap();
        BUS_PhieuNhap bus_phieunhap = new BUS_PhieuNhap();
        BUS_NguyenLieu bus_nguyenlieu = new BUS_NguyenLieu();
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public FormLapPhieuNhap()
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLapPhieuNhap_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Text = bus_phieunhap.getMaPNCuoi();
            txtNgayLap.Text = DateTime.Now.ToShortDateString();
            txtMaNVLap.Text = bus_nhanvien.getMaNV(this.HoTenNV);
            txtHoTenNV.Text = this.HoTenNV;
            cbbTenNCC.DataSource = bus_phieunhap.getCbbNCC();
            cbbTenNCC.DisplayMember = "TENNCC";
        }

        private void txtMaNL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(bus_phieunhap.checkNguyenLieu(txtMaNL.Text))
                {
                    txtTenNL.Text = bus_phieunhap.getNguyenLieu(txtMaNL.Text).Rows[0].Field<string> (1);
                    txtDonVi.Text = bus_phieunhap.getNguyenLieu(txtMaNL.Text).Rows[0].Field<string>(2);
                }    
                else
                {
                    MessageBox.Show("Nguyên liệu mới!");
                    txtTenNL.Text = "";
                    txtDonVi.Text = "";
                }    
            }    
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaTien.Text != "")
            {
                float gt = (float)Convert.ToDouble(txtGiaTien.Text);
                int sl = Convert.ToInt32(txtSLNhap.Text);
                float tt = gt * sl;
                txtThanhTien.Text = tt.ToString();
            }
            else txtThanhTien.Text = "0";
        }

        private void btnThemVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            string manl = txtMaNL.Text;
            string tennl = txtTenNL.Text;
            string donvi = txtDonVi.Text;
            string slnhap = txtSLNhap.Text;
            string giatien = txtGiaTien.Text;
            string thanhtien = txtThanhTien.Text;
            dgvCTPN.Rows.Add(manl, tennl, donvi, slnhap, giatien, thanhtien);
            double tt = 0;
            foreach(DataGridViewRow row in dgvCTPN.Rows)
            {
                tt += Convert.ToDouble(row.Cells[5].Value);                
            }
            txtTongTien.Text = tt.ToString();
            txtMaNL.Text ="";
            txtTenNL.Text = "";
            txtDonVi.Text = "";
            txtSLNhap.Text = "";
            txtGiaTien.Text = "";
            txtThanhTien.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maphieu = txtMaPhieu.Text;
            string mancc = bus_phieunhap.getMaNCC(cbbTenNCC.Text);
            string manv = txtMaNVLap.Text;
            DateTime ngaylap = Convert.ToDateTime(txtNgayLap.Text);
            float tongtien = (float)Convert.ToDouble(txtTongTien.Text);
            DTO_PhieuNhap phieunhap = new DTO_PhieuNhap(maphieu, manv, mancc, ngaylap, tongtien);
            if(bus_phieunhap.themPhieuNhap(phieunhap))
            {
                foreach (DataGridViewRow row in dgvCTPN.Rows)
                {
                    string manl = row.Cells[0].Value.ToString();
                    string tennl = row.Cells[1].Value.ToString();
                    string donvi = row.Cells[2].Value.ToString();
                    int soluong = Convert.ToInt32(row.Cells[3].Value.ToString());
                    float giatien = (float)Convert.ToDouble(row.Cells[4].Value.ToString());
                    float thanhtien = (float)Convert.ToDouble(row.Cells[5].Value.ToString());
                    if (bus_phieunhap.checkNguyenLieu(row.Cells[0].Value.ToString()) == false)
                    {
                        DTO_NguyenLieu nguyenlieu = new DTO_NguyenLieu(manl, tennl, donvi, soluong);
                        bus_nguyenlieu.themNguyenLieu(nguyenlieu);
                    }      
                    DTO_CTPN ctpn = new DTO_CTPN(maphieu, manl, giatien, soluong, thanhtien);
                    bus_ctpn.themCTPN(ctpn);
                }
                MessageBox.Show("Nhập thành công!");
                btnInPhieu.Enabled = true;
            }    
            else
            {
                MessageBox.Show("Nhập không thành công!");
            }    
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            FormInPhieuNhap inpn = new FormInPhieuNhap(txtMaPhieu.Text);
            inpn.ShowDialog();
        }
    }
}

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
    public partial class FormGoiMon : UserControl
    {
        string _MaNV;
        string MaHD;
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        BUS_HoaDon bus_hoadon = new BUS_HoaDon();
        BUS_ChiTietHoaDon bus_cthd = new BUS_ChiTietHoaDon();
        BUS_TienDua bus_tiendua = new BUS_TienDua();
        public FormGoiMon()
        {
            InitializeComponent();
        }
        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;
            }
        }

        private void FormGoiMon_Load(object sender, EventArgs e)
        {
            txtHoTenNV.Text = bus_nhanvien.getHoTenNV(MaNV);
            this.cbbTenNhom.SelectedItem = "Tất cả";
            dgvChonTD.DataSource = bus_cthd.getAllThucDon();
        }

        private void cbbTenNhom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cbbTenNhom.SelectedItem.ToString() != "Tất cả")
            {
                string manhom = bus_cthd.getMaNhom(this.cbbTenNhom.GetItemText(this.cbbTenNhom.SelectedItem));
                dgvChonTD.DataSource = bus_cthd.getTheoTungNhomThucDon(manhom);
            }
            else dgvChonTD.DataSource = bus_cthd.getAllThucDon();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if(dgvChonTD.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn món!");
            }    
            else
            {
                string matd = dgvChonTD.CurrentRow.Cells[0].Value.ToString();
                string tentd = dgvChonTD.CurrentRow.Cells[1].Value.ToString();
                string giaban = dgvChonTD.CurrentRow.Cells[2].Value.ToString();
                string giamgia = dgvChonTD.CurrentRow.Cells[3].Value.ToString();
                dgvTDDuocChon.Rows.Add(matd, tentd, giaban, 1, giamgia);
                updateTien();
            }    
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if(dgvTDDuocChon.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!");
            }    
            else
            {
                foreach(DataGridViewRow row in dgvTDDuocChon.SelectedRows)
                {
                    dgvTDDuocChon.Rows.RemoveAt(row.Index);
                }
                updateTien();
            }    
        }

        private void dgvTDDuocChon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateTien();
        }
        private void updateTien()
        {
            float thanhtien = 0;
            foreach (DataGridViewRow row in dgvTDDuocChon.Rows)
            {
                float gb = (float)Convert.ToDouble(row.Cells[2].Value);
                int sl = Convert.ToInt32(row.Cells[3].Value);
                int gg = Convert.ToInt32(row.Cells[4].Value);
                thanhtien += gb * sl - gb * sl * gg / 100;
            }
            txtThanhTien.Text = thanhtien.ToString();
            lblTongTien.Text = thanhtien.ToString();
        }

        private void txtGiamGia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                float thanhtien = (float)(Convert.ToDouble(txtThanhTien.Text) - Convert.ToDouble(txtThanhTien.Text) * Convert.ToDouble(txtGiamGia.Text) / 100);
                lblTongTien.Text = thanhtien.ToString();
            }    
        }

        private void txtKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float thanhtien = (float)(Convert.ToDouble(txtThanhTien.Text));
                float khachdua = (float)(Convert.ToDouble(txtKhachDua.Text));
                txtTienThua.Text = (khachdua - thanhtien).ToString();
            }
        }

        private void btnLuuCSDL_Click(object sender, EventArgs e)
        {
            string mahd = bus_hoadon.getMaHDCuoi();
            this.MaHD = mahd;
            string tenkh = txtTenKH.Text;
            string manv = this.MaNV;
            DateTime ngaylap = DateTime.Now;
            float tongtien = (float)Convert.ToDouble(lblTongTien.Text);
            DTO_HoaDon hd = new DTO_HoaDon(mahd, tenkh, manv, ngaylap, tongtien);
            if (bus_hoadon.themHoaDon(hd))
            {
                foreach(DataGridViewRow row in dgvTDDuocChon.Rows)
                {
                    string matd = row.Cells[0].Value.ToString();
                    int sl = Convert.ToInt32(row.Cells[3].Value);
                    float thanhtien;
                    float gb = (float)Convert.ToDouble(row.Cells[2].Value);
                    int gg = Convert.ToInt32(row.Cells[4].Value);
                    thanhtien = gb * sl - gb * sl * gg / 100;
                    DTO_CTHD cthd = new DTO_CTHD(mahd, matd, sl, thanhtien);
                    bus_cthd.themCTHD(cthd);
                }
                float tienhang = (float)Convert.ToDouble(txtThanhTien.Text);
                float giamgia = (float)Convert.ToDouble(txtGiamGia.Text);
                float khachdua = (float)Convert.ToDouble(txtKhachDua.Text);
                float tralai = (float)Convert.ToDouble(txtTienThua.Text);
                DTO_TienDua td = new DTO_TienDua(mahd, tienhang, giamgia, khachdua, tralai);
                bus_tiendua.themTienDua(td);
                MessageBox.Show("Đã lưu vào csdl!");
                btnInHoaDon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {        
            dgvTDDuocChon.Rows.Clear();
            txtTenKH.Text = "";
            txtThanhTien.Text = "";
            txtGiamGia.Text = "";
            txtKhachDua.Text = "";
            txtTienThua.Text = "";
            lblTongTien.Text = "";
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lập hóa đơn thành công!");
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            FormInHoaDon inhoadon = new FormInHoaDon(this.MaHD);
            inhoadon.ShowDialog();
        }
    }
}

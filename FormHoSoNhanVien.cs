using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO_KFC;
using BUS_KFC;


namespace KFC
{
    public partial class FormHoSoNhanVien : UserControl
    {
        string _fileanh;
        string _byteanh;
        BUS_HoSoNhanVien bus_hsnv = new BUS_HoSoNhanVien();
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public FormHoSoNhanVien()
        {
            InitializeComponent();
        }
        public string FileAnh
        {
            get
            {
                return _fileanh;
            }
            set
            {
                _fileanh = value;
            }
        }
        public string ByteAnh
        {
            get
            {
                return _byteanh;
            }
            set
            {
                _byteanh = value;
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void refreshAll()
        {
            dgvHSNV.DataSource = bus_hsnv.getAllHSNV();
            cbbTenNV.DataSource = bus_hsnv.getcbbTenNVChuaCo();
            cbbTenNV.DisplayMember = "HoTenNV";
            cbbTenNV.SelectedItem = null;
            cbbDanToc.SelectedItem = null;
            cbbTonGiao.SelectedItem = null;
            cbbTinhThanh.SelectedItem = null;
            cbbBangCap.SelectedItem = null;
            pictureBox1.Image = null;
        }    
        private void FormHoSoNhanVien_Load(object sender, EventArgs e)
        {
            dgvHSNV.DataSource = bus_hsnv.getAllHSNV();
            cbbTenNV.DataSource = bus_hsnv.getcbbTenNVChuaCo();
            cbbTenNV.DisplayMember = "HoTenNV";
            cbbTenNV.SelectedItem = null;
        }
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(this.FileAnh, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.FileAnh = openFile.FileName;
            }
            this.ByteAnh = Convert.ToBase64String(converImgToByte());
            pictureBox1.Image = ByteToImg(this.ByteAnh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = bus_nhanvien.getMaNV(cbbTenNV.Text);
            DateTime ngayvaolam = dtpNgayVaoLam.Value;
            string dantoc = cbbDanToc.Text;
            string tongiao = cbbTonGiao.Text;
            string tinhthanh = cbbTinhThanh.Text;
            string bangcap = cbbBangCap.Text;
            DTO_HoSoNhanVien hsnv = new DTO_HoSoNhanVien(manv, dantoc, tongiao, tinhthanh, ngayvaolam, bangcap, this.ByteAnh);
            if (bus_hsnv.themHSNV(hsnv)) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công!");
            refreshAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = bus_nhanvien.getMaNV(cbbTenNV.Text);
            DateTime ngayvaolam = dtpNgayVaoLam.Value;
            string dantoc = cbbDanToc.Text;
            string tongiao = cbbTonGiao.Text;
            string tinhthanh = cbbTinhThanh.Text;
            string bangcap = cbbBangCap.Text;
            DTO_HoSoNhanVien hsnv = new DTO_HoSoNhanVien(manv, dantoc, tongiao, tinhthanh, ngayvaolam, bangcap, this.ByteAnh);
            if (bus_hsnv.suaHSNV(hsnv)) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công!");
            refreshAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = bus_nhanvien.getMaNV(cbbTenNV.Text);
            if (bus_hsnv.xoaHSNV(manv)) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công!");
            refreshAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void dgvHSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbTenNV.DataSource = bus_hsnv.getcbbTenNV();
            cbbTenNV.DisplayMember = "HoTenNV";
            cbbTenNV.SelectedItem = null;
            cbbTenNV.SelectedIndex = cbbTenNV.FindStringExact(dgvHSNV.CurrentRow.Cells[0].Value.ToString());
            cbbDanToc.SelectedIndex = cbbDanToc.FindStringExact(dgvHSNV.CurrentRow.Cells[2].Value.ToString());
            cbbTonGiao.SelectedIndex = cbbTonGiao.FindStringExact(dgvHSNV.CurrentRow.Cells[3].Value.ToString());
            cbbTinhThanh.SelectedIndex = cbbTinhThanh.FindStringExact(dgvHSNV.CurrentRow.Cells[4].Value.ToString());
            cbbBangCap.SelectedIndex = cbbBangCap.FindStringExact(dgvHSNV.CurrentRow.Cells[5].Value.ToString());
            dtpNgayVaoLam.Value = Convert.ToDateTime(dgvHSNV.CurrentRow.Cells[1].Value.ToString());
            string manv = bus_nhanvien.getMaNV(cbbTenNV.Text);
            pictureBox1.Image = ByteToImg(bus_hsnv.getFileAnh(manv));
            this.ByteAnh = bus_hsnv.getFileAnh(manv);
        }
    }
}

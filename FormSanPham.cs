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
    public partial class FormSanPham : UserControl
    {
        string _hotennv;
        FormQLMonAn monan = new FormQLMonAn();
        FormQLNuocUong nuocuong = new FormQLNuocUong();
        FormQLLoai loai = new FormQLLoai();
        FormQLThucDon thucdon = new FormQLThucDon();
        FormQLCTTD cttd = new FormQLCTTD();
        FormQLNhaCungCap ncc = new FormQLNhaCungCap();
        FormQLNguyenLieu nl = new FormQLNguyenLieu();
        FormPhieuNhap pn = new FormPhieuNhap();
        public FormSanPham()
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
        private void FormSanPham_Load(object sender, EventArgs e)
        { 
            pn.HoTenNV = this.HoTenNV;
            this.Controls.Add(monan);
            this.Controls.Add(nuocuong);
            this.Controls.Add(loai);
            this.Controls.Add(thucdon);
            this.Controls.Add(cttd);
            this.Controls.Add(ncc);
            this.Controls.Add(nl);
            this.Controls.Add(pn);
            unVisible();
        }

        private void unVisible()
        {
            foreach (Control a in this.Controls)
            {
                a.Visible = false;
            }
            this.Controls[this.Controls.IndexOf(groupBoxQLSanPham)].Visible = true;
            this.Controls[this.Controls.IndexOf(groupBoxDanhMuc)].Visible = true;
        }
        private void btnMonAn_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(monan)].BringToFront();
            this.Controls[this.Controls.IndexOf(monan)].Visible = true;
        }

        private void btnNuocUong_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(nuocuong)].BringToFront();
            this.Controls[this.Controls.IndexOf(nuocuong)].Visible = true;
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(ncc)].BringToFront();
            this.Controls[this.Controls.IndexOf(ncc)].Visible = true;
        }

        private void btnNhomThucDon_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(loai)].BringToFront();
            this.Controls[this.Controls.IndexOf(loai)].Visible = true;
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(thucdon)].BringToFront();
            this.Controls[this.Controls.IndexOf(thucdon)].Visible = true;
        }

        private void btnCTTD_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(cttd)].BringToFront();
            this.Controls[this.Controls.IndexOf(cttd)].Visible = true;
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(nl)].BringToFront();
            this.Controls[this.Controls.IndexOf(nl)].Visible = true;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(pn)].BringToFront();
            this.Controls[this.Controls.IndexOf(pn)].Visible = true;
        }
    }
}

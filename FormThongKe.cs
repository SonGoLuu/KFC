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
    public partial class FormThongKe : UserControl
    {
        FormThongKeHSNV hsnv = new FormThongKeHSNV();
        FormThongKeHS1NV hs1nv = new FormThongKeHS1NV();
        FormThongKeTienLuong tienluong = new FormThongKeTienLuong();
        FormThongKeThucDon thucdon = new FormThongKeThucDon();
        FormHoaDon hoadon = new FormHoaDon();
        FormThongKeDoanhThu doanhthu = new FormThongKeDoanhThu();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            this.Controls.Add(hsnv);
            this.Controls.Add(hs1nv);
            this.Controls.Add(tienluong);
            this.Controls.Add(thucdon);
            this.Controls.Add(hoadon);
            this.Controls.Add(doanhthu);
            unVisible();
        }
        private void unVisible()
        {
            foreach (Control a in this.Controls)
            {
                a.Visible = false;
            }
            this.Controls[this.Controls.IndexOf(groupBoxChonMon)].Visible = true;
        }

        private void btnHSNV_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(hsnv)].BringToFront();
            this.Controls[this.Controls.IndexOf(hsnv)].Visible = true;
        }

        private void btnHS1NV_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(hs1nv)].BringToFront();
            this.Controls[this.Controls.IndexOf(hs1nv)].Visible = true;
        }

        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(tienluong)].BringToFront();
            this.Controls[this.Controls.IndexOf(tienluong)].Visible = true;
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(thucdon)].BringToFront();
            this.Controls[this.Controls.IndexOf(thucdon)].Visible = true;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(hoadon)].BringToFront();
            this.Controls[this.Controls.IndexOf(hoadon)].Visible = true;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(doanhthu)].BringToFront();
            this.Controls[this.Controls.IndexOf(doanhthu)].Visible = true;
        }
    }
}

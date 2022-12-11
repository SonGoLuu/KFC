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
    public partial class FormHeThong : UserControl
    {
        FormQLNguoiDung qlnd= new FormQLNguoiDung();
        FormPhanQuyen pq = new FormPhanQuyen();
        FormDoiMatKhau dmk = new FormDoiMatKhau();
        KhongCoQuyen khong = new KhongCoQuyen();
        BUS_PhanQuyen bus_phanquyen = new BUS_PhanQuyen();
        string _tentaikhoan;
        public string TenTaiKhoan
        {
            get
            {
                return _tentaikhoan;
            }
            set
            {
                _tentaikhoan = value;
            }
        }
        public FormHeThong()
        {
            InitializeComponent();
        }

        private void FormHeThong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(qlnd);
            this.Controls.Add(khong);
            unVisible();
        }
        private void unVisible()
        {
            foreach (Control a in this.Controls)
            {
                a.Visible = false;
            }
            this.Controls[this.Controls.IndexOf(groupBoxPhanQuyen)].Visible = true;
            this.Controls[this.Controls.IndexOf(groupBoxBaoMat)].Visible = true;
        }
        private bool checkPhanQuyen()
        {
            string tenquyen = bus_phanquyen.getTenQuyen(TenTaiKhoan);
            if (tenquyen.Contains("6")) return true;
            else return false;
        }    
        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            unVisible();
            if(checkPhanQuyen())
            {
                this.Controls[this.Controls.IndexOf(qlnd)].BringToFront();
                this.Controls[this.Controls.IndexOf(qlnd)].Visible = true;
            }    
            else
            {
                this.Controls[this.Controls.IndexOf(khong)].BringToFront();
                this.Controls[this.Controls.IndexOf(khong)].Visible = true;
            }    
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (checkPhanQuyen()) pq.ShowDialog();
            else
            {
                this.Controls[this.Controls.IndexOf(khong)].BringToFront();
                this.Controls[this.Controls.IndexOf(khong)].Visible = true;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            dmk.TenTaiKhoan = this.TenTaiKhoan;
            dmk.ShowDialog();
        }
    }
}

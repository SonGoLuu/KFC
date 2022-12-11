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
    public partial class FormDoiMatKhau : Form
    {
        BUS_TaiKhoan bus_taikhoan = new BUS_TaiKhoan();
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
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtCu.Text == bus_taikhoan.getMatKhau(TenTaiKhoan))
            {
                if(txtNhapLai.Text == txtMoi.Text)
                {
                    if (bus_taikhoan.suaTaiKhoan(TenTaiKhoan, txtMoi.Text))
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    else MessageBox.Show("Đổi mật khẩu không thành công!");
                }
                else MessageBox.Show("Nhập lại mật khẩu bị sai!");
            }
            else MessageBox.Show("Nhập sai mật khẩu hiện tại!");
        }
    }
}

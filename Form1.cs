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
    public partial class Form1 : Form
    {
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Texts !="" && txtMatKhau.Texts !="")
            {
                if(tk.checkTaiKhoan(txtTenTaiKhoan.Texts, txtMatKhau.Texts))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    FormMainUI formMainUI = new FormMainUI();
                    formMainUI.MaNV = tk.getMaNV(txtTenTaiKhoan.Texts);
                    formMainUI.ShowDialog();
                }    
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }    
            }   
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
            }      
        }
    }
}

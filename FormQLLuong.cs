using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class FormQLLuong : UserControl
    {
        FormLuong formLuong = new FormLuong();
        FormBangKeLuong bkl = new FormBangKeLuong();
        public FormQLLuong()
        {
            InitializeComponent();
        }

        private void FormQLLuong_Load(object sender, EventArgs e)
        {
            this.Controls.Add(formLuong);
            this.Controls.Add(bkl);
            unVisible();
        }
        private void unVisible()
        {
            foreach (Control a in this.Controls)
            {
                a.Visible = false;
            }
            this.Controls[this.Controls.IndexOf(groupBoxLuong)].Visible = true;
        }

        private void btnLuongChucDanh_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(formLuong)].BringToFront();
            this.Controls[this.Controls.IndexOf(formLuong)].Visible = true;
        }

        private void btnBangKeLuong_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(bkl)].BringToFront();
            this.Controls[this.Controls.IndexOf(bkl)].Visible = true;
        }
    }
}

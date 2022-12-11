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
    public partial class FormNhanSu : UserControl
    {
        FormQLNhanVien qlnv = new FormQLNhanVien();
        FormHoSoNhanVien hsnv = new FormHoSoNhanVien();
        FormChucDanh cd = new FormChucDanh();
        public FormNhanSu()
        {
            InitializeComponent();
        }

        private void FormNhanSu_Load(object sender, EventArgs e)
        {
            this.Controls.Add(qlnv);
            this.Controls.Add(hsnv);
            this.Controls.Add(cd);
            unVisible();
        }
        private void unVisible()
        {
            foreach (Control a in this.Controls)
            {
                a.Visible = false;
            }
            this.Controls[this.Controls.IndexOf(groupBoxNhanSu)].Visible = true;
            this.Controls[this.Controls.IndexOf(groupBoxChucDanh)].Visible = true;
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(qlnv)].BringToFront();
            this.Controls[this.Controls.IndexOf(qlnv)].Visible = true;
        }

        private void btnHoSoNhanVien_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(hsnv)].BringToFront();
            this.Controls[this.Controls.IndexOf(hsnv)].Visible = true;
        }

        private void btnQLChucDanh_Click(object sender, EventArgs e)
        {
            unVisible();
            this.Controls[this.Controls.IndexOf(cd)].BringToFront();
            this.Controls[this.Controls.IndexOf(cd)].Visible = true;
        }
    }
}

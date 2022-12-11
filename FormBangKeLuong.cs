using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO_KFC;
using BUS_KFC;

namespace KFC
{
    public partial class FormBangKeLuong : UserControl
    {
        BUS_BangKeLuong bus_bkl = new BUS_BangKeLuong();
        public FormBangKeLuong()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            string thang = string.Format("{0:MM/dd/yyyy}", dtpThang.Value);
            MessageBox.Show("Tháng:" + thang);
            dgvBangKeLuong.DataSource = bus_bkl.loadDgvBangKeLuong(thang);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvBangKeLuong.Rows)
            {
                string manv = row.Cells[0].Value.ToString();
                int nghiphep = Convert.ToInt32(row.Cells[2].Value.ToString());
                float thuclinh = (float)Convert.ToDouble(row.Cells[6].Value.ToString());
                DateTime thang = dtpThang.Value;
                DTO_BangKeLuong bkl = new DTO_BangKeLuong(manv, nghiphep, thuclinh, thang);
                bus_bkl.themBangKeLuong(bkl);
            }
            MessageBox.Show("Đã lưu!");
        }

        private void dgvBangKeLuong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int nghiphep = Convert.ToInt32(dgvBangKeLuong.CurrentRow.Cells[2].Value.ToString());
            float tienphucap = Convert.ToInt32(dgvBangKeLuong.CurrentRow.Cells[4].Value.ToString()) * (float)Convert.ToDouble(dgvBangKeLuong.CurrentRow.Cells[3].Value.ToString()) /100;
            float tongluong = (30-nghiphep) * (float)Convert.ToDouble(dgvBangKeLuong.CurrentRow.Cells[3].Value.ToString()) /30;
            float thuclinh = tongluong + tienphucap;
            dgvBangKeLuong.CurrentRow.Cells[6].Value = thuclinh.ToString();
        }
    }
}

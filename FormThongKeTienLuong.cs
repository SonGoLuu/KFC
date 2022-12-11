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
using Microsoft.Reporting.WinForms;

namespace KFC
{
    public partial class FormThongKeTienLuong : UserControl
    {
        int _thang;
        public int thang
        {
            get
            {
                return _thang;
            }
            set
            {
                _thang = value;
            }    
        }
        public FormThongKeTienLuong()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.thang = dtpNgaySinh.Value.Month;
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=master;Integrated Security=True");
            cnn.Open();
            string sqlctpn = string.Format("Select A.MANV, A.HOTENNV, A.MACD, A.NGAYSINH, A.CMND, A.DIACHI, A.EMAIL, A.SDTNV, A.GIOITINH From NHANVIEN A, BANGKELUONG B WHERE A.MANV = B.MANV AND MONTH(B.THOIGIAN) = {0} ", thang);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetNhanVien");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From BANGKELUONG WHERE MONTH(THOIGIAN) = {0} ", thang);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetBangKeLuong");
            da2.Fill(dt2);
            string sqlCD = string.Format("Select * From LUONGCHUCDANH");
            SqlDataAdapter da3 = new SqlDataAdapter(sqlCD, cnn);
            DataTable dt3 = new DataTable("DataSetLuongCD");
            da3.Fill(dt3);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetNhanVien", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetBangKeLuong", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSetLuongCD", dt3);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

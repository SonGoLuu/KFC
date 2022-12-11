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
using System.IO;
using DTO_KFC;
using BUS_KFC;

namespace KFC
{
    public partial class FormThongKeHS1NV : UserControl
    {
        byte[] byteanh;
        BUS_NVChucDanh bus_nvchucdanh = new BUS_NVChucDanh();
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public FormThongKeHS1NV()
        {
            InitializeComponent();
        }
        public List<LoadAnhReport> GetAnh()
        {
            List<LoadAnhReport> anh = new List<LoadAnhReport>();
            LoadAnhReport temp = new LoadAnhReport(byteanh);
            anh.Add(temp);
            return anh;
        }
        private void FormThongKeHS1NV_Load(object sender, EventArgs e)
        {
            cbbHoTenNV.DataSource = bus_nvchucdanh.getcbbNV();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedItem = null;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=master;Integrated Security=True");
            cnn.Open();
            string manv = bus_nhanvien.getMaNV(cbbHoTenNV.Text);
            string sqlctpn = string.Format("Select * From NHANVIEN Where MaNV ='{0}'", manv);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetNhanVien");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From HoSoNhanVien Where MaNV ='{0}'", manv);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetHSNV");
            da2.Fill(dt2);
            string fileanh = dt2.Rows[0].Field<string>(6);
            byte[] imgBytes = Convert.FromBase64String(fileanh);
            this.byteanh = imgBytes;
            List<LoadAnhReport> loadanh = GetAnh();
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetNhanVien", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetHSNV", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSetAnh", loadanh);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            cbbHoTenNV.DataSource = bus_nvchucdanh.getcbbNV();
            cbbHoTenNV.DisplayMember = "HoTenNV";
            cbbHoTenNV.SelectedItem = null;
        }
    }
}

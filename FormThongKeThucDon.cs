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
    public partial class FormThongKeThucDon : UserControl
    {
        int _thang;
        int _nam;
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
        public int nam
        {
            get
            {
                return _nam;
            }
            set
            {
                _nam = value;
            }
        }
        public FormThongKeThucDon()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.thang = dtpNgaySinh.Value.Month;
            this.nam = dtpNgaySinh.Value.Year;
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=master;Integrated Security=True");
            cnn.Open();
            string sqlctpn = string.Format("Select DISTINCT A.MATHUCDON, A.TENTHUCDON, A.MANHOM, A.CHITIET, A.GIABAN, A.GIAMGIA  From THUCDON A, CHITIETHOADON B, HOADON C WHERE A.MATHUCDON = B.MATHUCDON AND B.MAHD = C.MAHD AND MONTH(C.NGAYLAP) = {0} AND YEAR(C.NGAYLAP) = {1} ", thang, nam);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetThucDon");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select DISTINCT A.MAHD, A.MATHUCDON, A.SLMUA, A.THANHTIEN From CHITIETHOADON A, HOADON B WHERE A.MAHD = B.MAHD AND MONTH(B.NGAYLAP) = {0} AND YEAR(B.NGAYLAP) = {1}", thang, nam);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetCTHD");
            da2.Fill(dt2);
            string sqlCD = string.Format("Select * From NHOMTHUCDON");
            SqlDataAdapter da3 = new SqlDataAdapter(sqlCD, cnn);
            DataTable dt3 = new DataTable("DataSetNhom");
            da3.Fill(dt3);
            string sqlhd = string.Format("Select * From HOADON WHERE MONTH(NGAYLAP) = {0} AND YEAR(NGAYLAP) = {1}", thang, nam);
            SqlDataAdapter da4 = new SqlDataAdapter(sqlhd, cnn);
            DataTable dt4 = new DataTable("DataSetHoaDon");
            da4.Fill(dt4);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetThucDon", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetCTHD", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSetNhom", dt3);
            ReportDataSource rds4 = new ReportDataSource("DataSetHoaDon", dt4);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.LocalReport.DataSources.Add(rds4);
            this.reportViewer1.RefreshReport();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

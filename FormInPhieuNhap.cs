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
    public partial class FormInPhieuNhap : Form
    {
        string maphieu;
        public FormInPhieuNhap()
        {
            InitializeComponent();
        }
        public FormInPhieuNhap(string maphieu) : this()
        {
            this.maphieu = maphieu;
        }
        private void FormInPhieuNhap_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=master;Integrated Security=True");
            cnn.Open();
            string sqlctpn = string.Format("Select * From ChiTietPhieuNhap Where MaPhieu = '{0}'", this.maphieu);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetCTPN");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From NguyenLieu");
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetNguyenLieu");
            da2.Fill(dt2);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetCTPN", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetNguyenLieu", dt2);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
    }
}

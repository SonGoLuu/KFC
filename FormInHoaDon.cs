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
    public partial class FormInHoaDon : Form
    {
        string mahd;
        public FormInHoaDon()
        {
            InitializeComponent();
        }
        public FormInHoaDon(string mahd) : this()
        {
            this.mahd = mahd;
        }
        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=master;Integrated Security=True");
            cnn.Open();
            string sqlctpn = string.Format("Select * From ChiTietHoaDon Where MaHD = '{0}'", this.mahd);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetCTHD");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From ThucDon");
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetThucDon");
            da2.Fill(dt2);
            string sqltd = string.Format("Select * From TienDua Where MaHD = '{0}'", this.mahd);
            SqlDataAdapter da3 = new SqlDataAdapter(sqltd, cnn);
            DataTable dt3 = new DataTable("DataSetTienDua");
            da3.Fill(dt3);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetCTHD", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetThucDon", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSetTienDua", dt3);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }
    }
}

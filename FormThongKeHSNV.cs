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
    public partial class FormThongKeHSNV : UserControl
    {
        public FormThongKeHSNV()
        {
            InitializeComponent();
        }

        private void FormThongKeHSNV_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void reportViewer1_VisibleChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=master;Integrated Security=True");
            cnn.Open();
            string sqlctpn = string.Format("Select * From NHANVIEN Where MaCD IS NOT NULL");
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetNhanVien");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From ChucDanh");
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetChucDanh");
            da2.Fill(dt2);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetNhanVien", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetChucDanh", dt2);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
    }
}

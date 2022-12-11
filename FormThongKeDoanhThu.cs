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
    public partial class FormThongKeDoanhThu : UserControl
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormThongKeDoanhThu_VisibleChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=master;Integrated Security=True");
            cnn.Open();
            string sqlctpn = string.Format("Select * From HOADON");
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetHoaDon");
            da1.Fill(dt1);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetHoaDon", dt1);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}

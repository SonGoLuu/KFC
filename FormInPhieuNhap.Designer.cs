
namespace KFC
{
    partial class FormInPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KFCDataSet = new KFC.KFCDataSet();
            this.ChiTietPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietPhieuNhapTableAdapter = new KFC.KFCDataSetTableAdapters.ChiTietPhieuNhapTableAdapter();
            this.NguyenLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NguyenLieuTableAdapter = new KFC.KFCDataSetTableAdapters.NguyenLieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguyenLieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSetCTPN";
            reportDataSource3.Value = this.ChiTietPhieuNhapBindingSource;
            reportDataSource4.Name = "DataSetNguyenLieu";
            reportDataSource4.Value = this.NguyenLieuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KFC.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(439, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // KFCDataSet
            // 
            this.KFCDataSet.DataSetName = "KFCDataSet";
            this.KFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietPhieuNhapBindingSource
            // 
            this.ChiTietPhieuNhapBindingSource.DataMember = "ChiTietPhieuNhap";
            this.ChiTietPhieuNhapBindingSource.DataSource = this.KFCDataSet;
            // 
            // ChiTietPhieuNhapTableAdapter
            // 
            this.ChiTietPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // NguyenLieuBindingSource
            // 
            this.NguyenLieuBindingSource.DataMember = "NguyenLieu";
            this.NguyenLieuBindingSource.DataSource = this.KFCDataSet;
            // 
            // NguyenLieuTableAdapter
            // 
            this.NguyenLieuTableAdapter.ClearBeforeFill = true;
            // 
            // FormInPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 416);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu nhập";
            this.Load += new System.EventHandler(this.FormInPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguyenLieuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietPhieuNhapBindingSource;
        private KFCDataSet KFCDataSet;
        private System.Windows.Forms.BindingSource NguyenLieuBindingSource;
        private KFCDataSetTableAdapters.ChiTietPhieuNhapTableAdapter ChiTietPhieuNhapTableAdapter;
        private KFCDataSetTableAdapters.NguyenLieuTableAdapter NguyenLieuTableAdapter;
    }
}
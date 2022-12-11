
namespace KFC
{
    partial class FormInHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KFCDataSet = new KFC.KFCDataSet();
            this.ChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietHoaDonTableAdapter = new KFC.KFCDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.ThucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThucDonTableAdapter = new KFC.KFCDataSetTableAdapters.ThucDonTableAdapter();
            this.TienDuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TienDuaTableAdapter = new KFC.KFCDataSetTableAdapters.TienDuaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TienDuaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetCTHD";
            reportDataSource1.Value = this.ChiTietHoaDonBindingSource;
            reportDataSource2.Name = "DataSetThucDon";
            reportDataSource2.Value = this.ThucDonBindingSource;
            reportDataSource3.Name = "DataSetTienDua";
            reportDataSource3.Value = this.TienDuaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KFC.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(441, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // KFCDataSet
            // 
            this.KFCDataSet.DataSetName = "KFCDataSet";
            this.KFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietHoaDonBindingSource
            // 
            this.ChiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.ChiTietHoaDonBindingSource.DataSource = this.KFCDataSet;
            // 
            // ChiTietHoaDonTableAdapter
            // 
            this.ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // ThucDonBindingSource
            // 
            this.ThucDonBindingSource.DataMember = "ThucDon";
            this.ThucDonBindingSource.DataSource = this.KFCDataSet;
            // 
            // ThucDonTableAdapter
            // 
            this.ThucDonTableAdapter.ClearBeforeFill = true;
            // 
            // TienDuaBindingSource
            // 
            this.TienDuaBindingSource.DataMember = "TienDua";
            this.TienDuaBindingSource.DataSource = this.KFCDataSet;
            // 
            // TienDuaTableAdapter
            // 
            this.TienDuaTableAdapter.ClearBeforeFill = true;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 416);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TienDuaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBindingSource;
        private KFCDataSet KFCDataSet;
        private System.Windows.Forms.BindingSource ThucDonBindingSource;
        private System.Windows.Forms.BindingSource TienDuaBindingSource;
        private KFCDataSetTableAdapters.ChiTietHoaDonTableAdapter ChiTietHoaDonTableAdapter;
        private KFCDataSetTableAdapters.ThucDonTableAdapter ThucDonTableAdapter;
        private KFCDataSetTableAdapters.TienDuaTableAdapter TienDuaTableAdapter;
    }
}
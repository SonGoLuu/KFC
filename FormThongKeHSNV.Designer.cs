
namespace KFC
{
    partial class FormThongKeHSNV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeHSNV));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KFCDataSet = new KFC.KFCDataSet();
            this.ChucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblgigido = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhanVienTableAdapter = new KFC.KFCDataSetTableAdapters.NhanVienTableAdapter();
            this.ChucDanhTableAdapter = new KFC.KFCDataSetTableAdapters.ChucDanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChucDanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.KFCDataSet;
            // 
            // KFCDataSet
            // 
            this.KFCDataSet.DataSetName = "KFCDataSet";
            this.KFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChucDanhBindingSource
            // 
            this.ChucDanhBindingSource.DataMember = "ChucDanh";
            this.ChucDanhBindingSource.DataSource = this.KFCDataSet;
            // 
            // btnReturn
            // 
            this.btnReturn.CheckedState.Parent = this.btnReturn;
            this.btnReturn.HoverState.Parent = this.btnReturn;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageSize = new System.Drawing.Size(27, 27);
            this.btnReturn.Location = new System.Drawing.Point(34, 10);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PressedState.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(27, 27);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblgigido
            // 
            this.lblgigido.BackColor = System.Drawing.Color.Transparent;
            this.lblgigido.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgigido.ForeColor = System.Drawing.Color.Crimson;
            this.lblgigido.Location = new System.Drawing.Point(67, 14);
            this.lblgigido.Name = "lblgigido";
            this.lblgigido.Size = new System.Drawing.Size(240, 23);
            this.lblgigido.TabIndex = 10;
            this.lblgigido.Text = "THỐNG KÊ NHÂN VIÊN CỬA HÀNG";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetNhanVien";
            reportDataSource1.Value = this.NhanVienBindingSource;
            reportDataSource2.Name = "DataSetChucDanh";
            reportDataSource2.Value = this.ChucDanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KFC.ReportHSNV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(857, 494);
            this.reportViewer1.TabIndex = 12;
            this.reportViewer1.VisibleChanged += new System.EventHandler(this.reportViewer1_VisibleChanged);
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ChucDanhTableAdapter
            // 
            this.ChucDanhTableAdapter.ClearBeforeFill = true;
            // 
            // FormThongKeHSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblgigido);
            this.Name = "FormThongKeHSNV";
            this.Size = new System.Drawing.Size(857, 537);
            this.Load += new System.EventHandler(this.FormThongKeHSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChucDanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnReturn;
        private System.Windows.Forms.Label lblgigido;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private KFCDataSet KFCDataSet;
        private System.Windows.Forms.BindingSource ChucDanhBindingSource;
        private KFCDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private KFCDataSetTableAdapters.ChucDanhTableAdapter ChucDanhTableAdapter;
    }
}

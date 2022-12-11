
namespace KFC
{
    partial class FormThongKeThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeThucDon));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtpNgaySinh = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXem = new RJCodeAdvance.RJControls.RJButton();
            this.btnReturn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblgigido = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KFCDataSet = new KFC.KFCDataSet();
            this.ThucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThucDonTableAdapter = new KFC.KFCDataSetTableAdapters.ThucDonTableAdapter();
            this.ChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietHoaDonTableAdapter = new KFC.KFCDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.NhomThucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhomThucDonTableAdapter = new KFC.KFCDataSetTableAdapters.NhomThucDonTableAdapter();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTableAdapter = new KFC.KFCDataSetTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomThucDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgaySinh.BorderSize = 0;
            this.dtpNgaySinh.CustomFormat = "MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(558, 44);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(4, 22);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(118, 22);
            this.dtpNgaySinh.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpNgaySinh.TabIndex = 50;
            this.dtpNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(500, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Tháng:";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnXem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnXem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXem.BorderRadius = 5;
            this.btnXem.BorderSize = 0;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(695, 39);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(98, 30);
            this.btnXem.TabIndex = 48;
            this.btnXem.Text = "BÁO CÁO";
            this.btnXem.TextColor = System.Drawing.Color.White;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            this.btnReturn.TabIndex = 47;
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
            this.lblgigido.TabIndex = 46;
            this.lblgigido.Text = "THỐNG KÊ THỰC ĐƠN ĐÃ BÁN";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetThucDon";
            reportDataSource1.Value = this.ThucDonBindingSource;
            reportDataSource2.Name = "DataSetCTHD";
            reportDataSource2.Value = this.ChiTietHoaDonBindingSource;
            reportDataSource3.Name = "DataSetNhom";
            reportDataSource3.Value = this.NhomThucDonBindingSource;
            reportDataSource4.Name = "DataSetHoaDon";
            reportDataSource4.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KFC.ReportThucDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(857, 462);
            this.reportViewer1.TabIndex = 51;
            // 
            // KFCDataSet
            // 
            this.KFCDataSet.DataSetName = "KFCDataSet";
            this.KFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ChiTietHoaDonBindingSource
            // 
            this.ChiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.ChiTietHoaDonBindingSource.DataSource = this.KFCDataSet;
            // 
            // ChiTietHoaDonTableAdapter
            // 
            this.ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // NhomThucDonBindingSource
            // 
            this.NhomThucDonBindingSource.DataMember = "NhomThucDon";
            this.NhomThucDonBindingSource.DataSource = this.KFCDataSet;
            // 
            // NhomThucDonTableAdapter
            // 
            this.NhomThucDonTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.KFCDataSet;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FormThongKeThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblgigido);
            this.Name = "FormThongKeThucDon";
            this.Size = new System.Drawing.Size(857, 537);
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomThucDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJDatePicker dtpNgaySinh;
        private System.Windows.Forms.Label label10;
        private RJCodeAdvance.RJControls.RJButton btnXem;
        private Guna.UI2.WinForms.Guna2ImageButton btnReturn;
        private System.Windows.Forms.Label lblgigido;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThucDonBindingSource;
        private KFCDataSet KFCDataSet;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBindingSource;
        private System.Windows.Forms.BindingSource NhomThucDonBindingSource;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private KFCDataSetTableAdapters.ThucDonTableAdapter ThucDonTableAdapter;
        private KFCDataSetTableAdapters.ChiTietHoaDonTableAdapter ChiTietHoaDonTableAdapter;
        private KFCDataSetTableAdapters.NhomThucDonTableAdapter NhomThucDonTableAdapter;
        private KFCDataSetTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
    }
}

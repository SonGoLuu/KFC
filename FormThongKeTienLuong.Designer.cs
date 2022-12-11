
namespace KFC
{
    partial class FormThongKeTienLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeTienLuong));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnXem = new RJCodeAdvance.RJControls.RJButton();
            this.btnReturn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblgigido = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KFCDataSet = new KFC.KFCDataSet();
            this.BangKeLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BangKeLuongTableAdapter = new KFC.KFCDataSetTableAdapters.BangKeLuongTableAdapter();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienTableAdapter = new KFC.KFCDataSetTableAdapters.NhanVienTableAdapter();
            this.LuongChucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LuongChucDanhTableAdapter = new KFC.KFCDataSetTableAdapters.LuongChucDanhTableAdapter();
            this.dtpNgaySinh = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangKeLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongChucDanhBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnXem.TabIndex = 42;
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
            this.btnReturn.TabIndex = 41;
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
            this.lblgigido.TabIndex = 40;
            this.lblgigido.Text = "THỐNG KÊ HỒ SƠ 1 NHÂN VIÊN";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetBangKeLuong";
            reportDataSource1.Value = this.BangKeLuongBindingSource;
            reportDataSource2.Name = "DataSetNhanVien";
            reportDataSource2.Value = this.NhanVienBindingSource;
            reportDataSource3.Name = "DataSetLuongCD";
            reportDataSource3.Value = this.LuongChucDanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KFC.ReportTienLuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(857, 462);
            this.reportViewer1.TabIndex = 43;
            // 
            // KFCDataSet
            // 
            this.KFCDataSet.DataSetName = "KFCDataSet";
            this.KFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BangKeLuongBindingSource
            // 
            this.BangKeLuongBindingSource.DataMember = "BangKeLuong";
            this.BangKeLuongBindingSource.DataSource = this.KFCDataSet;
            // 
            // BangKeLuongTableAdapter
            // 
            this.BangKeLuongTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.KFCDataSet;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // LuongChucDanhBindingSource
            // 
            this.LuongChucDanhBindingSource.DataMember = "LuongChucDanh";
            this.LuongChucDanhBindingSource.DataSource = this.KFCDataSet;
            // 
            // LuongChucDanhTableAdapter
            // 
            this.LuongChucDanhTableAdapter.ClearBeforeFill = true;
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
            this.dtpNgaySinh.TabIndex = 45;
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
            this.label10.TabIndex = 44;
            this.label10.Text = "Tháng:";
            // 
            // FormThongKeTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblgigido);
            this.Name = "FormThongKeTienLuong";
            this.Size = new System.Drawing.Size(857, 537);
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangKeLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongChucDanhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnXem;
        private Guna.UI2.WinForms.Guna2ImageButton btnReturn;
        private System.Windows.Forms.Label lblgigido;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BangKeLuongBindingSource;
        private KFCDataSet KFCDataSet;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private System.Windows.Forms.BindingSource LuongChucDanhBindingSource;
        private KFCDataSetTableAdapters.BangKeLuongTableAdapter BangKeLuongTableAdapter;
        private KFCDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private KFCDataSetTableAdapters.LuongChucDanhTableAdapter LuongChucDanhTableAdapter;
        private RJCodeAdvance.RJControls.RJDatePicker dtpNgaySinh;
        private System.Windows.Forms.Label label10;
    }
}

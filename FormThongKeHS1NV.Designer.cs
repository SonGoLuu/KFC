
namespace KFC
{
    partial class FormThongKeHS1NV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeHS1NV));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KFCDataSet = new KFC.KFCDataSet();
            this.HoSoNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblgigido = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhanVienTableAdapter = new KFC.KFCDataSetTableAdapters.NhanVienTableAdapter();
            this.HoSoNhanVienTableAdapter = new KFC.KFCDataSetTableAdapters.HoSoNhanVienTableAdapter();
            this.cbbHoTenNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXem = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.LoadAnhReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoSoNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadAnhReportBindingSource)).BeginInit();
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
            // HoSoNhanVienBindingSource
            // 
            this.HoSoNhanVienBindingSource.DataMember = "HoSoNhanVien";
            this.HoSoNhanVienBindingSource.DataSource = this.KFCDataSet;
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
            this.btnReturn.TabIndex = 13;
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
            this.lblgigido.TabIndex = 12;
            this.lblgigido.Text = "THỐNG KÊ HỒ SƠ 1 NHÂN VIÊN";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetNhanVien";
            reportDataSource1.Value = this.NhanVienBindingSource;
            reportDataSource2.Name = "DataSetHSNV";
            reportDataSource2.Value = this.HoSoNhanVienBindingSource;
            reportDataSource3.Name = "DataSetAnh";
            reportDataSource3.Value = this.LoadAnhReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KFC.ReportHS1NV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(857, 459);
            this.reportViewer1.TabIndex = 14;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // HoSoNhanVienTableAdapter
            // 
            this.HoSoNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.BackColor = System.Drawing.Color.Transparent;
            this.cbbHoTenNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHoTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHoTenNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbbHoTenNV.FocusedState.Parent = this.cbbHoTenNV;
            this.cbbHoTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbHoTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.HoverState.Parent = this.cbbHoTenNV;
            this.cbbHoTenNV.ItemHeight = 22;
            this.cbbHoTenNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbHoTenNV.ItemsAppearance.Parent = this.cbbHoTenNV;
            this.cbbHoTenNV.Location = new System.Drawing.Point(440, 44);
            this.cbbHoTenNV.MinimumSize = new System.Drawing.Size(10, 0);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.ShadowDecoration.Parent = this.cbbHoTenNV;
            this.cbbHoTenNV.Size = new System.Drawing.Size(194, 28);
            this.cbbHoTenNV.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(350, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên nhân viên";
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
            this.btnXem.Location = new System.Drawing.Point(653, 44);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(113, 30);
            this.btnXem.TabIndex = 39;
            this.btnXem.Text = "XEM HỒ SƠ";
            this.btnXem.TextColor = System.Drawing.Color.White;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 5;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(772, 44);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(76, 30);
            this.rjButton1.TabIndex = 40;
            this.rjButton1.Text = "CẬP NHẬT";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // LoadAnhReportBindingSource
            // 
            this.LoadAnhReportBindingSource.DataSource = typeof(DTO_KFC.LoadAnhReport);
            // 
            // FormThongKeHS1NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbbHoTenNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblgigido);
            this.Name = "FormThongKeHS1NV";
            this.Size = new System.Drawing.Size(857, 537);
            this.Load += new System.EventHandler(this.FormThongKeHS1NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoSoNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadAnhReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnReturn;
        private System.Windows.Forms.Label lblgigido;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private KFCDataSet KFCDataSet;
        private System.Windows.Forms.BindingSource HoSoNhanVienBindingSource;
        private System.Windows.Forms.BindingSource LoadAnhReportBindingSource;
        private KFCDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private KFCDataSetTableAdapters.HoSoNhanVienTableAdapter HoSoNhanVienTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox cbbHoTenNV;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJButton btnXem;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
    }
}

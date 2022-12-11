
namespace KFC
{
    partial class FormHoSoNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoSoNhanVien));
            this.groupBoxDSMonAn = new System.Windows.Forms.GroupBox();
            this.dgvHSNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCapNhat = new RJCodeAdvance.RJControls.RJButton();
            this.btnXoa = new RJCodeAdvance.RJControls.RJButton();
            this.btnSua = new RJCodeAdvance.RJControls.RJButton();
            this.btnThem = new RJCodeAdvance.RJControls.RJButton();
            this.btnReturn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblgigido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new RJCodeAdvance.RJControls.RJDatePicker();
            this.cbbTenNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDanToc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTonGiao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbBangCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTinhThanh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDSMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDSMonAn
            // 
            this.groupBoxDSMonAn.Controls.Add(this.dgvHSNV);
            this.groupBoxDSMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDSMonAn.ForeColor = System.Drawing.Color.Crimson;
            this.groupBoxDSMonAn.Location = new System.Drawing.Point(34, 255);
            this.groupBoxDSMonAn.Name = "groupBoxDSMonAn";
            this.groupBoxDSMonAn.Size = new System.Drawing.Size(786, 234);
            this.groupBoxDSMonAn.TabIndex = 34;
            this.groupBoxDSMonAn.TabStop = false;
            this.groupBoxDSMonAn.Text = "Hồ sơ nhân viên";
            // 
            // dgvHSNV
            // 
            this.dgvHSNV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvHSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHSNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvHSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHSNV.ColumnHeadersHeight = 34;
            this.dgvHSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHSNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHSNV.EnableHeadersVisualStyles = false;
            this.dgvHSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvHSNV.Location = new System.Drawing.Point(10, 25);
            this.dgvHSNV.Name = "dgvHSNV";
            this.dgvHSNV.ReadOnly = true;
            this.dgvHSNV.RowHeadersVisible = false;
            this.dgvHSNV.RowTemplate.Height = 32;
            this.dgvHSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSNV.Size = new System.Drawing.Size(766, 196);
            this.dgvHSNV.TabIndex = 0;
            this.dgvHSNV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvHSNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvHSNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHSNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHSNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHSNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHSNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHSNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvHSNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvHSNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHSNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHSNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHSNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHSNV.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvHSNV.ThemeStyle.ReadOnly = true;
            this.dgvHSNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvHSNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHSNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHSNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Crimson;
            this.dgvHSNV.ThemeStyle.RowsStyle.Height = 32;
            this.dgvHSNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvHSNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHSNV_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 5;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(612, 213);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 30);
            this.btnCapNhat.TabIndex = 33;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(461, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 5;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(307, 213);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 5;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(153, 213);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblgigido
            // 
            this.lblgigido.BackColor = System.Drawing.Color.Transparent;
            this.lblgigido.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgigido.ForeColor = System.Drawing.Color.Crimson;
            this.lblgigido.Location = new System.Drawing.Point(67, 14);
            this.lblgigido.Name = "lblgigido";
            this.lblgigido.Size = new System.Drawing.Size(198, 23);
            this.lblgigido.TabIndex = 27;
            this.lblgigido.Text = "QUẢN LÝ HỒ SƠ NHÂN VIÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(384, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ngày vào làm";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgayVaoLam.BorderSize = 0;
            this.dtpNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(475, 65);
            this.dtpNgayVaoLam.MinimumSize = new System.Drawing.Size(4, 22);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(127, 22);
            this.dtpNgayVaoLam.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpNgayVaoLam.TabIndex = 20;
            this.dtpNgayVaoLam.TextColor = System.Drawing.Color.White;
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTenNV.FocusedState.Parent = this.cbbTenNV;
            this.cbbTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.HoverState.Parent = this.cbbTenNV;
            this.cbbTenNV.ItemHeight = 22;
            this.cbbTenNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbTenNV.ItemsAppearance.Parent = this.cbbTenNV;
            this.cbbTenNV.Location = new System.Drawing.Point(102, 22);
            this.cbbTenNV.MinimumSize = new System.Drawing.Size(10, 0);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.ShadowDecoration.Parent = this.cbbTenNV;
            this.cbbTenNV.Size = new System.Drawing.Size(194, 28);
            this.cbbTenNV.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(348, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Dân tộc";
            // 
            // cbbDanToc
            // 
            this.cbbDanToc.BackColor = System.Drawing.Color.Transparent;
            this.cbbDanToc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDanToc.DropDownHeight = 120;
            this.cbbDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanToc.DropDownWidth = 20;
            this.cbbDanToc.FocusedColor = System.Drawing.Color.Empty;
            this.cbbDanToc.FocusedState.Parent = this.cbbDanToc;
            this.cbbDanToc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDanToc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbDanToc.FormattingEnabled = true;
            this.cbbDanToc.HoverState.Parent = this.cbbDanToc;
            this.cbbDanToc.IntegralHeight = false;
            this.cbbDanToc.ItemHeight = 22;
            this.cbbDanToc.Items.AddRange(new object[] {
            "Kinh",
            "Tày",
            "Thái",
            "Hoa",
            "Khmer",
            "Mường",
            "Nùng",
            "Mông",
            "Dao",
            "Gia Rai",
            "Ngái",
            "Ê Đê",
            "Ba Na",
            "Xơ Đăng",
            "Sán Chay",
            "Cơ Ho",
            "Chăm",
            "Sán Dìu",
            "Hrê",
            "Mnông",
            "Raglay",
            "Xtiêng",
            "Bru Vân Kiều",
            "Thổ",
            "Giáy",
            "Cơ Tu",
            "Gié Triêng",
            "Mạ",
            "Khơ mú",
            "Co",
            "Tà Ôi",
            "Chơ Ro",
            "Kháng",
            "Xinh Mun",
            "Hà Nhì",
            "Chu Ru",
            "Lào",
            "La Chí",
            "La Ha",
            "Phù Lá",
            "La Hủ",
            "Lự",
            "Lô Lô",
            "Chứt",
            "Mảng",
            "Pà Thẻn",
            "Cơ Lao",
            "Cống",
            "Bố Y",
            "Si La",
            "Pu Péo",
            "Brâu",
            "Ơ Đu",
            "Rơ Măm",
            "Người nước ngoài",
            "Không xác định"});
            this.cbbDanToc.ItemsAppearance.Parent = this.cbbDanToc;
            this.cbbDanToc.Location = new System.Drawing.Point(403, 22);
            this.cbbDanToc.Name = "cbbDanToc";
            this.cbbDanToc.ShadowDecoration.Parent = this.cbbDanToc;
            this.cbbDanToc.Size = new System.Drawing.Size(199, 28);
            this.cbbDanToc.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tôn giáo";
            // 
            // cbbTonGiao
            // 
            this.cbbTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.cbbTonGiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTonGiao.DropDownHeight = 120;
            this.cbbTonGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTonGiao.DropDownWidth = 20;
            this.cbbTonGiao.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTonGiao.FocusedState.Parent = this.cbbTonGiao;
            this.cbbTonGiao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTonGiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTonGiao.FormattingEnabled = true;
            this.cbbTonGiao.HoverState.Parent = this.cbbTonGiao;
            this.cbbTonGiao.IntegralHeight = false;
            this.cbbTonGiao.ItemHeight = 22;
            this.cbbTonGiao.Items.AddRange(new object[] {
            "Không",
            "Phật giáo",
            "Công giáo",
            "Tin lành",
            "Cao Đài",
            "Hòa Hảo",
            "Hồi giáo",
            "Baha\'i giáo",
            "Tịnh độ Cư sĩ Phật hội Việt Nam",
            "Đạo Tứ Ân Hiếu nghĩa",
            "Bửu Sơn Kỳ hương",
            "Minh Sư Đạo",
            "Minh Lý Đạo",
            "Bà la môn",
            "Mormon",
            "Hiếu",
            " Nghĩa Tà Lơn",
            "Cơ đốc Phục lâm"});
            this.cbbTonGiao.ItemsAppearance.Parent = this.cbbTonGiao;
            this.cbbTonGiao.Location = new System.Drawing.Point(102, 65);
            this.cbbTonGiao.Name = "cbbTonGiao";
            this.cbbTonGiao.ShadowDecoration.Parent = this.cbbTonGiao;
            this.cbbTonGiao.Size = new System.Drawing.Size(251, 28);
            this.cbbTonGiao.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cbbBangCap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbTinhThanh);
            this.groupBox2.Controls.Add(this.cbbTonGiao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbDanToc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbTenNV);
            this.groupBox2.Controls.Add(this.dtpNgayVaoLam);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(34, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 146);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(624, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(19, 114);
            this.btnLoad.TabIndex = 36;
            this.btnLoad.TabStop = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(663, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // cbbBangCap
            // 
            this.cbbBangCap.BackColor = System.Drawing.Color.Transparent;
            this.cbbBangCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbBangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBangCap.FocusedColor = System.Drawing.Color.Empty;
            this.cbbBangCap.FocusedState.Parent = this.cbbBangCap;
            this.cbbBangCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbBangCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbBangCap.FormattingEnabled = true;
            this.cbbBangCap.HoverState.Parent = this.cbbBangCap;
            this.cbbBangCap.ItemHeight = 22;
            this.cbbBangCap.Items.AddRange(new object[] {
            "Cao đẳng",
            "Đại học",
            "Thạc sĩ",
            "Tiến sĩ"});
            this.cbbBangCap.ItemsAppearance.Parent = this.cbbBangCap;
            this.cbbBangCap.Location = new System.Drawing.Point(403, 106);
            this.cbbBangCap.Name = "cbbBangCap";
            this.cbbBangCap.ShadowDecoration.Parent = this.cbbBangCap;
            this.cbbBangCap.Size = new System.Drawing.Size(199, 28);
            this.cbbBangCap.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(334, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bằng cấp";
            // 
            // cbbTinhThanh
            // 
            this.cbbTinhThanh.BackColor = System.Drawing.Color.Transparent;
            this.cbbTinhThanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTinhThanh.DropDownHeight = 120;
            this.cbbTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhThanh.DropDownWidth = 20;
            this.cbbTinhThanh.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTinhThanh.FocusedState.Parent = this.cbbTinhThanh;
            this.cbbTinhThanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTinhThanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTinhThanh.FormattingEnabled = true;
            this.cbbTinhThanh.HoverState.Parent = this.cbbTinhThanh;
            this.cbbTinhThanh.IntegralHeight = false;
            this.cbbTinhThanh.ItemHeight = 22;
            this.cbbTinhThanh.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa-Vũng Tàu",
            "Bạc Liêu",
            "Bắc Kạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tây",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hòa Bình",
            "Hồ Chí Minh",
            "Hậu Giang",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên – Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cbbTinhThanh.ItemsAppearance.Parent = this.cbbTinhThanh;
            this.cbbTinhThanh.Location = new System.Drawing.Point(102, 108);
            this.cbbTinhThanh.Name = "cbbTinhThanh";
            this.cbbTinhThanh.ShadowDecoration.Parent = this.cbbTinhThanh;
            this.cbbTinhThanh.Size = new System.Drawing.Size(194, 28);
            this.cbbTinhThanh.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(13, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tỉnh thành";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "HOTENNV";
            this.Column1.HeaderText = "Tên nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "NGAYVAOLAM";
            this.Column2.HeaderText = "Ngày vào làm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "DANTOC";
            this.Column3.HeaderText = "Dân tộc";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "TONGIAO";
            this.Column4.HeaderText = "Tôn giáo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 155;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "TINHTHANH";
            this.Column5.HeaderText = "Tỉnh thành";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "BANGCAP";
            this.Column6.HeaderText = "Bằng cấp";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 95;
            // 
            // FormHoSoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBoxDSMonAn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblgigido);
            this.Name = "FormHoSoNhanVien";
            this.Size = new System.Drawing.Size(857, 537);
            this.Load += new System.EventHandler(this.FormHoSoNhanVien_Load);
            this.groupBoxDSMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDSMonAn;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHSNV;
        private RJCodeAdvance.RJControls.RJButton btnCapNhat;
        private RJCodeAdvance.RJControls.RJButton btnXoa;
        private RJCodeAdvance.RJControls.RJButton btnSua;
        private RJCodeAdvance.RJControls.RJButton btnThem;
        private Guna.UI2.WinForms.Guna2ImageButton btnReturn;
        private System.Windows.Forms.Label lblgigido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private RJCodeAdvance.RJControls.RJDatePicker dtpNgayVaoLam;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTenNV;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbDanToc;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTonGiao;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbBangCap;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTinhThanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

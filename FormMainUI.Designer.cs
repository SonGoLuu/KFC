
namespace KFC
{
    partial class FormMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUI));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.anhNhanVien = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lblTenCD = new System.Windows.Forms.Label();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new RJCodeAdvance.RJControls.RJButton();
            this.btnHeThong = new RJCodeAdvance.RJControls.RJButton();
            this.btnThongKe = new RJCodeAdvance.RJControls.RJButton();
            this.btnLuong = new RJCodeAdvance.RJControls.RJButton();
            this.btnNhanSu = new RJCodeAdvance.RJControls.RJButton();
            this.btnSanPham = new RJCodeAdvance.RJControls.RJButton();
            this.btnGoiMon = new RJCodeAdvance.RJControls.RJButton();
            this.btnTrangChu = new RJCodeAdvance.RJControls.RJButton();
            this.lblgigido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.panelLogo.Controls.Add(this.anhNhanVien);
            this.panelLogo.Controls.Add(this.lblTenCD);
            this.panelLogo.Controls.Add(this.lblHoTenNV);
            this.panelLogo.Location = new System.Drawing.Point(0, -2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // anhNhanVien
            // 
            this.anhNhanVien.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.anhNhanVien.BorderColor = System.Drawing.Color.AliceBlue;
            this.anhNhanVien.BorderColor2 = System.Drawing.Color.HotPink;
            this.anhNhanVien.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.anhNhanVien.BorderSize = 2;
            this.anhNhanVien.GradientAngle = 50F;
            this.anhNhanVien.Location = new System.Drawing.Point(12, 18);
            this.anhNhanVien.Name = "anhNhanVien";
            this.anhNhanVien.Size = new System.Drawing.Size(87, 87);
            this.anhNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhNhanVien.TabIndex = 10;
            this.anhNhanVien.TabStop = false;
            // 
            // lblTenCD
            // 
            this.lblTenCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.lblTenCD.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTenCD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTenCD.Location = new System.Drawing.Point(105, 66);
            this.lblTenCD.Name = "lblTenCD";
            this.lblTenCD.Size = new System.Drawing.Size(109, 23);
            this.lblTenCD.TabIndex = 9;
            this.lblTenCD.Text = "Admin";
            // 
            // lblHoTenNV
            // 
            this.lblHoTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.lblHoTenNV.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblHoTenNV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHoTenNV.Location = new System.Drawing.Point(105, 43);
            this.lblHoTenNV.Name = "lblHoTenNV";
            this.lblHoTenNV.Size = new System.Drawing.Size(109, 23);
            this.lblHoTenNV.TabIndex = 8;
            this.lblHoTenNV.Text = "Trần Huỳnh Lưu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panelMenu);
            this.panel3.Controls.Add(this.panelLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 571);
            this.panel3.TabIndex = 6;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnHeThong);
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnLuong);
            this.panelMenu.Controls.Add(this.btnNhanSu);
            this.panelMenu.Controls.Add(this.btnSanPham);
            this.panelMenu.Controls.Add(this.btnGoiMon);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Location = new System.Drawing.Point(0, 127);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 444);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnDangXuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnDangXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangXuat.BorderRadius = 0;
            this.btnDangXuat.BorderSize = 0;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 378);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(217, 54);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "  ĐĂNG XUẤT";
            this.btnDangXuat.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnHeThong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnHeThong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHeThong.BorderRadius = 0;
            this.btnHeThong.BorderSize = 0;
            this.btnHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Image")));
            this.btnHeThong.Location = new System.Drawing.Point(0, 324);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(217, 54);
            this.btnHeThong.TabIndex = 6;
            this.btnHeThong.Text = "  HỆ THỐNG";
            this.btnHeThong.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHeThong.UseVisualStyleBackColor = false;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnThongKe.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThongKe.BorderRadius = 0;
            this.btnThongKe.BorderSize = 0;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(0, 270);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(217, 54);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "  THỐNG KÊ";
            this.btnThongKe.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnLuong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnLuong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuong.BorderRadius = 0;
            this.btnLuong.BorderSize = 0;
            this.btnLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuong.FlatAppearance.BorderSize = 0;
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuong.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnLuong.Image")));
            this.btnLuong.Location = new System.Drawing.Point(0, 216);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(217, 54);
            this.btnLuong.TabIndex = 4;
            this.btnLuong.Text = "  LƯƠNG";
            this.btnLuong.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnNhanSu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnNhanSu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhanSu.BorderRadius = 0;
            this.btnNhanSu.BorderSize = 0;
            this.btnNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanSu.FlatAppearance.BorderSize = 0;
            this.btnNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanSu.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanSu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhanSu.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanSu.Image")));
            this.btnNhanSu.Location = new System.Drawing.Point(0, 162);
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.Size = new System.Drawing.Size(217, 54);
            this.btnNhanSu.TabIndex = 3;
            this.btnNhanSu.Text = "  NHÂN SỰ";
            this.btnNhanSu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhanSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanSu.UseVisualStyleBackColor = false;
            this.btnNhanSu.Click += new System.EventHandler(this.btnNhanSu_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSanPham.BorderRadius = 0;
            this.btnSanPham.BorderSize = 0;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanPham.Image")));
            this.btnSanPham.Location = new System.Drawing.Point(0, 108);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(217, 54);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "  SẢN PHẨM";
            this.btnSanPham.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnGoiMon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnGoiMon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGoiMon.BorderRadius = 0;
            this.btnGoiMon.BorderSize = 0;
            this.btnGoiMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoiMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoiMon.FlatAppearance.BorderSize = 0;
            this.btnGoiMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoiMon.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoiMon.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiMon.Image")));
            this.btnGoiMon.Location = new System.Drawing.Point(0, 54);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(217, 54);
            this.btnGoiMon.TabIndex = 1;
            this.btnGoiMon.Text = "  GỌI MÓN";
            this.btnGoiMon.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoiMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoiMon.UseVisualStyleBackColor = false;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnTrangChu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrangChu.BorderRadius = 0;
            this.btnTrangChu.BorderSize = 0;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(217, 54);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "  TRANG CHỦ";
            this.btnTrangChu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // lblgigido
            // 
            this.lblgigido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.lblgigido.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgigido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgigido.Location = new System.Drawing.Point(18, 6);
            this.lblgigido.Name = "lblgigido";
            this.lblgigido.Size = new System.Drawing.Size(246, 23);
            this.lblgigido.TabIndex = 7;
            this.lblgigido.Text = "KFC - Vị ngon trên từng ngón tay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Controls.Add(this.lblgigido);
            this.panel1.Location = new System.Drawing.Point(217, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 34);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(827, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 8;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Location = new System.Drawing.Point(731, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(75, 23);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pictureBoxHome);
            this.panelHome.Location = new System.Drawing.Point(217, 34);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(857, 537);
            this.panelHome.TabIndex = 7;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(857, 537);
            this.pictureBoxHome.TabIndex = 2;
            this.pictureBoxHome.TabStop = false;
            // 
            // FormMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 571);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainUI";
            this.Load += new System.EventHandler(this.FormMainUI_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblTenCD;
        private System.Windows.Forms.Label lblHoTenNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblgigido;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox anhNhanVien;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private RJCodeAdvance.RJControls.RJButton btnTrangChu;
        private RJCodeAdvance.RJControls.RJButton btnHeThong;
        private RJCodeAdvance.RJControls.RJButton btnThongKe;
        private RJCodeAdvance.RJControls.RJButton btnLuong;
        private RJCodeAdvance.RJControls.RJButton btnNhanSu;
        private RJCodeAdvance.RJControls.RJButton btnSanPham;
        private RJCodeAdvance.RJControls.RJButton btnGoiMon;
        private RJCodeAdvance.RJControls.RJButton btnDangXuat;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBoxHome;
    }
}
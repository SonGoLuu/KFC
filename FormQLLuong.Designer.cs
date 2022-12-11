
namespace KFC
{
    partial class FormQLLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLLuong));
            this.groupBoxLuong = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBangKeLuong = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuongChucDanh = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.groupBoxLuong.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBangKeLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuongChucDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLuong
            // 
            this.groupBoxLuong.Controls.Add(this.groupBox2);
            this.groupBoxLuong.Controls.Add(this.groupBox1);
            this.groupBoxLuong.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLuong.ForeColor = System.Drawing.Color.Crimson;
            this.groupBoxLuong.Location = new System.Drawing.Point(181, 162);
            this.groupBoxLuong.Name = "groupBoxLuong";
            this.groupBoxLuong.Size = new System.Drawing.Size(500, 221);
            this.groupBoxLuong.TabIndex = 2;
            this.groupBoxLuong.TabStop = false;
            this.groupBoxLuong.Text = "Quản lý lương";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBangKeLuong);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(267, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng kê lương";
            // 
            // btnBangKeLuong
            // 
            this.btnBangKeLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBangKeLuong.Image")));
            this.btnBangKeLuong.Location = new System.Drawing.Point(26, 22);
            this.btnBangKeLuong.Name = "btnBangKeLuong";
            this.btnBangKeLuong.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBangKeLuong.ShadowDecoration.Parent = this.btnBangKeLuong;
            this.btnBangKeLuong.Size = new System.Drawing.Size(135, 135);
            this.btnBangKeLuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBangKeLuong.TabIndex = 1;
            this.btnBangKeLuong.TabStop = false;
            this.btnBangKeLuong.Click += new System.EventHandler(this.btnBangKeLuong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuongChucDanh);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(37, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý lương chức danh";
            // 
            // btnLuongChucDanh
            // 
            this.btnLuongChucDanh.Image = ((System.Drawing.Image)(resources.GetObject("btnLuongChucDanh.Image")));
            this.btnLuongChucDanh.Location = new System.Drawing.Point(27, 22);
            this.btnLuongChucDanh.Name = "btnLuongChucDanh";
            this.btnLuongChucDanh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLuongChucDanh.ShadowDecoration.Parent = this.btnLuongChucDanh;
            this.btnLuongChucDanh.Size = new System.Drawing.Size(135, 135);
            this.btnLuongChucDanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLuongChucDanh.TabIndex = 0;
            this.btnLuongChucDanh.TabStop = false;
            this.btnLuongChucDanh.Click += new System.EventHandler(this.btnLuongChucDanh_Click);
            // 
            // FormQLLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBoxLuong);
            this.Name = "FormQLLuong";
            this.Size = new System.Drawing.Size(857, 537);
            this.Load += new System.EventHandler(this.FormQLLuong_Load);
            this.groupBoxLuong.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBangKeLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLuongChucDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnBangKeLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnLuongChucDanh;
    }
}

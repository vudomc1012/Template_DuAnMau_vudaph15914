
namespace _3_GUI_Presentationlayer_QLBH
{
    partial class frmNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.Data_NhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_Ql = new System.Windows.Forms.RadioButton();
            this.rbtn_Nv = new System.Windows.Forms.RadioButton();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.Label();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.txt_tinhtrang = new System.Windows.Forms.Label();
            this.rbtn_HD = new System.Windows.Forms.RadioButton();
            this.rbtn_KhongHD = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_NhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxTimKiem);
            this.groupBox1.Controls.Add(this.Data_NhanVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 293);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(646, 26);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(180, 27);
            this.tbxTimKiem.TabIndex = 84;
            // 
            // Data_NhanVien
            // 
            this.Data_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_NhanVien.Location = new System.Drawing.Point(7, 59);
            this.Data_NhanVien.Name = "Data_NhanVien";
            this.Data_NhanVien.RowHeadersWidth = 51;
            this.Data_NhanVien.RowTemplate.Height = 29;
            this.Data_NhanVien.Size = new System.Drawing.Size(820, 228);
            this.Data_NhanVien.TabIndex = 0;
            this.Data_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_NhanVien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_Ql);
            this.groupBox2.Controls.Add(this.rbtn_Nv);
            this.groupBox2.Controls.Add(this.tbxEmail);
            this.groupBox2.Controls.Add(this.tbxHoTen);
            this.groupBox2.Controls.Add(this.lblRole);
            this.groupBox2.Controls.Add(this.lblTenNV);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Location = new System.Drawing.Point(13, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 212);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            // 
            // rbtn_Ql
            // 
            this.rbtn_Ql.AutoSize = true;
            this.rbtn_Ql.Location = new System.Drawing.Point(267, 150);
            this.rbtn_Ql.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_Ql.Name = "rbtn_Ql";
            this.rbtn_Ql.Size = new System.Drawing.Size(80, 24);
            this.rbtn_Ql.TabIndex = 78;
            this.rbtn_Ql.Text = "Quản lý";
            this.rbtn_Ql.UseVisualStyleBackColor = true;
            this.rbtn_Ql.Click += new System.EventHandler(this.rbtn_Ql_Click);
            // 
            // rbtn_Nv
            // 
            this.rbtn_Nv.AutoSize = true;
            this.rbtn_Nv.Checked = true;
            this.rbtn_Nv.Location = new System.Drawing.Point(155, 152);
            this.rbtn_Nv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_Nv.Name = "rbtn_Nv";
            this.rbtn_Nv.Size = new System.Drawing.Size(96, 24);
            this.rbtn_Nv.TabIndex = 77;
            this.rbtn_Nv.TabStop = true;
            this.rbtn_Nv.Text = "Nhân viên";
            this.rbtn_Nv.UseVisualStyleBackColor = true;
            this.rbtn_Nv.Click += new System.EventHandler(this.rbtn_Nv_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(155, 35);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(180, 27);
            this.tbxEmail.TabIndex = 76;
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Location = new System.Drawing.Point(155, 87);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(180, 27);
            this.tbxHoTen.TabIndex = 75;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(24, 152);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(24, 90);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(111, 20);
            this.lblTenNV.TabIndex = 3;
            this.lblTenNV.Text = "Tên Nhân Viên :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email :";
            // 
            // txt_diachi
            // 
            this.txt_diachi.AutoSize = true;
            this.txt_diachi.Location = new System.Drawing.Point(428, 82);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(55, 20);
            this.txt_diachi.TabIndex = 77;
            this.txt_diachi.Text = "Địa chỉ";
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(499, 63);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDiaChi.Multiline = true;
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(346, 98);
            this.tbxDiaChi.TabIndex = 78;
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.AutoSize = true;
            this.txt_tinhtrang.Location = new System.Drawing.Point(428, 199);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(76, 20);
            this.txt_tinhtrang.TabIndex = 79;
            this.txt_tinhtrang.Text = "Tình trạng";
            // 
            // rbtn_HD
            // 
            this.rbtn_HD.AutoSize = true;
            this.rbtn_HD.Checked = true;
            this.rbtn_HD.Location = new System.Drawing.Point(534, 199);
            this.rbtn_HD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_HD.Name = "rbtn_HD";
            this.rbtn_HD.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HD.TabIndex = 80;
            this.rbtn_HD.TabStop = true;
            this.rbtn_HD.Text = "Hoạt động";
            this.rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // rbtn_KhongHD
            // 
            this.rbtn_KhongHD.AutoSize = true;
            this.rbtn_KhongHD.Location = new System.Drawing.Point(658, 199);
            this.rbtn_KhongHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_KhongHD.Name = "rbtn_KhongHD";
            this.rbtn_KhongHD.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KhongHD.TabIndex = 81;
            this.rbtn_KhongHD.Text = "Không hoạt động";
            this.rbtn_KhongHD.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 617);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 82;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(141, 617);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 83;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(266, 617);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 84;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(389, 617);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 85;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(512, 617);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(94, 29);
            this.btnBoqua.TabIndex = 86;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(633, 617);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(94, 29);
            this.btnDanhSach.TabIndex = 87;
            this.btnDanhSach.Text = "Danh Sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(745, 617);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 29);
            this.btnDong.TabIndex = 88;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 658);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rbtn_KhongHD);
            this.Controls.Add(this.rbtn_HD);
            this.Controls.Add(this.txt_tinhtrang);
            this.Controls.Add(this.tbxDiaChi);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_NhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Data_NhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.RadioButton rbtn_Ql;
        private System.Windows.Forms.RadioButton rbtn_Nv;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label txt_diachi;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.Label txt_tinhtrang;
        private System.Windows.Forms.RadioButton rbtn_HD;
        private System.Windows.Forms.RadioButton rbtn_KhongHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnDong;
    }
}

namespace _3_GUI_Presentationlayer_QLBH
{
    partial class frmKhachHang
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
            this.cbxKhongHoatDong = new System.Windows.Forms.CheckBox();
            this.cbxHoatDong = new System.Windows.Forms.CheckBox();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblHovaten = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Data_KhachHang = new System.Windows.Forms.DataGridView();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(282, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxKhongHoatDong);
            this.groupBox1.Controls.Add(this.cbxHoatDong);
            this.groupBox1.Controls.Add(this.rbtnNu);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.tbxDiaChi);
            this.groupBox1.Controls.Add(this.tbxHoTen);
            this.groupBox1.Controls.Add(this.tbxSdt);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblDiachi);
            this.groupBox1.Controls.Add(this.lblHovaten);
            this.groupBox1.Controls.Add(this.lblDienThoai);
            this.groupBox1.Location = new System.Drawing.Point(11, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(724, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbxKhongHoatDong
            // 
            this.cbxKhongHoatDong.AutoSize = true;
            this.cbxKhongHoatDong.Location = new System.Drawing.Point(572, 110);
            this.cbxKhongHoatDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxKhongHoatDong.Name = "cbxKhongHoatDong";
            this.cbxKhongHoatDong.Size = new System.Drawing.Size(122, 19);
            this.cbxKhongHoatDong.TabIndex = 28;
            this.cbxKhongHoatDong.Text = "Không Hoạt Động";
            this.cbxKhongHoatDong.UseVisualStyleBackColor = true;
            this.cbxKhongHoatDong.Click += new System.EventHandler(this.cbxKhongHoatDong_Click);
            // 
            // cbxHoatDong
            // 
            this.cbxHoatDong.AutoSize = true;
            this.cbxHoatDong.Location = new System.Drawing.Point(454, 110);
            this.cbxHoatDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxHoatDong.Name = "cbxHoatDong";
            this.cbxHoatDong.Size = new System.Drawing.Size(84, 19);
            this.cbxHoatDong.TabIndex = 27;
            this.cbxHoatDong.Text = "Hoạt Động";
            this.cbxHoatDong.UseVisualStyleBackColor = true;
            this.cbxHoatDong.CheckedChanged += new System.EventHandler(this.cbxHoatDong_CheckedChanged);
            this.cbxHoatDong.Click += new System.EventHandler(this.cbxHoatDong_Click);
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(572, 74);
            this.rbtnNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(41, 19);
            this.rbtnNu.TabIndex = 26;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(454, 72);
            this.rbtnNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(51, 19);
            this.rbtnNam.TabIndex = 25;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(454, 26);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(162, 23);
            this.tbxDiaChi.TabIndex = 24;
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Location = new System.Drawing.Point(135, 71);
            this.tbxHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(162, 23);
            this.tbxHoTen.TabIndex = 23;
            // 
            // tbxSdt
            // 
            this.tbxSdt.Location = new System.Drawing.Point(135, 26);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(162, 23);
            this.tbxSdt.TabIndex = 22;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(354, 111);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(61, 15);
            this.lblTrangThai.TabIndex = 21;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(354, 71);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(54, 15);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Giới Tính";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(354, 26);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(45, 15);
            this.lblDiachi.TabIndex = 4;
            this.lblDiachi.Text = "Địa Chỉ";
            // 
            // lblHovaten
            // 
            this.lblHovaten.AutoSize = true;
            this.lblHovaten.Location = new System.Drawing.Point(28, 71);
            this.lblHovaten.Name = "lblHovaten";
            this.lblHovaten.Size = new System.Drawing.Size(59, 15);
            this.lblHovaten.TabIndex = 3;
            this.lblHovaten.Text = "Họ Và Tên";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(28, 26);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(63, 15);
            this.lblDienThoai.TabIndex = 2;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Data_KhachHang);
            this.groupBox2.Controls.Add(this.tbxTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(11, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(724, 218);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // Data_KhachHang
            // 
            this.Data_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_KhachHang.Location = new System.Drawing.Point(6, 40);
            this.Data_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data_KhachHang.Name = "Data_KhachHang";
            this.Data_KhachHang.RowHeadersWidth = 51;
            this.Data_KhachHang.RowTemplate.Height = 29;
            this.Data_KhachHang.Size = new System.Drawing.Size(714, 178);
            this.Data_KhachHang.TabIndex = 1;
            this.Data_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_KhachHang_CellContentClick);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(557, 13);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(162, 23);
            this.tbxTimKiem.TabIndex = 24;
            this.tbxTimKiem.TextChanged += new System.EventHandler(this.tbxTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 428);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 38);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(122, 428);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 38);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(226, 428);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 38);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(333, 428);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 38);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(438, 428);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(82, 38);
            this.btnBoQua.TabIndex = 30;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(545, 428);
            this.btnDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(82, 38);
            this.btnDanhSach.TabIndex = 31;
            this.btnDanhSach.Text = "Danh Sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(648, 428);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(82, 38);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 480);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxKhongHoatDong;
        private System.Windows.Forms.CheckBox cbxHoatDong;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblHovaten;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Data_KhachHang;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnDong;
    }
}
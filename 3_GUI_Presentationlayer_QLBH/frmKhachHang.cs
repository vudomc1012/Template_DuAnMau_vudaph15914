using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;
using _2_BusinessLayer_QLBH.IService;
using _2_BusinessLayer_QLBH.Service;

namespace _3_GUI_Presentationlayer_QLBH
{
    public partial class frmKhachHang : Form
    {
        private IQLKhachHangService _iQlKhachHangService;
       private string _MaNV;
        private string _Sdt;
        public frmKhachHang()
        {
            InitializeComponent();
            _iQlKhachHangService = new QLKhachHangService();
            loadata();
        }

        void loadata()
        {

            _iQlKhachHangService.GetLstKhachHangs();
            Data_KhachHang.ColumnCount = 5;
            Data_KhachHang.Columns[0].Name = "Số điện thoại";
            Data_KhachHang.Columns[1].Name = "Tên Khách Hàng";
            Data_KhachHang.Columns[2].Name = "Địa chỉ";
            Data_KhachHang.Columns[3].Name = "Giới tính";
            Data_KhachHang.Columns[4].Name = "Trạng thái";
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Add");
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                Data_KhachHang.Columns.Add(comboBox);
            }

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "OK";
                button.Text = ("OK");
                button.UseColumnTextForButtonValue = true;
                this.Data_KhachHang.Columns.Add(button);
            }
            Data_KhachHang.Rows.Clear();
            foreach (var x in _iQlKhachHangService.GetLstKhachHangs())
            {
                Data_KhachHang.Rows.Add(x.DienThoai, x.TenKhach, x.DiaChi, x.Phai, x.TinhTrang == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        void loadataSearch(string ten)
        {
            _iQlKhachHangService.GetLstKhachHangs();
            Data_KhachHang.ColumnCount = 5;
            Data_KhachHang.Columns[0].Name = "Số điện thoại";
            Data_KhachHang.Columns[1].Name = "Tên Khách Hàng";
            Data_KhachHang.Columns[2].Name = "Địa chỉ";
            Data_KhachHang.Columns[3].Name = "Giới tính";
            Data_KhachHang.Columns[4].Name = "Trạng thái";
            Data_KhachHang.Rows.Clear();
            foreach (var x in _iQlKhachHangService.Search(ten))
            {
                Data_KhachHang.Rows.Add(x.DienThoai, x.TenKhach, x.DiaChi, x.Phai, x.TinhTrang == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            _Sdt = khachHang.DienThoai = tbxSdt.Text;
            khachHang.TenKhach = tbxHoTen.Text;
            khachHang.DiaChi = tbxDiaChi.Text;
            khachHang.Phai = rbtnNam.Checked ? "Nam" : "Nữ";
            khachHang.TinhTrang = (byte)(cbxHoatDong.Checked ? 1 : 0);
            // khachHang.MaNv = frmLogin._MaNV;
            khachHang.MaNv = "NV4";
            khachHang.statsSave = 0;
            if ((MessageBox.Show("Bạn có muốn thêm không ?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iQlKhachHangService.Add(khachHang));
            }
            loadata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kh = _iQlKhachHangService.GetLstKhachHangs().Where(c => c.DienThoai == _Sdt).FirstOrDefault();
            kh.TenKhach = tbxHoTen.Text;
            kh.DiaChi = tbxDiaChi.Text;
            kh.Phai = rbtnNam.Checked ? "Nam" : "Nữ";
            if ((MessageBox.Show("Bạn có chắc chắc muốn sửa?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iQlKhachHangService.Edit(kh));
            }
            loadata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kh = _iQlKhachHangService.GetLstKhachHangs().Where(c => c.DienThoai == _Sdt).FirstOrDefault();
            kh.TinhTrang = 0;
            cbxKhongHoatDong.Checked = true;
            if ((MessageBox.Show("Bạn có chắc chắc xoá",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iQlKhachHangService.Remove(kh));
            }
            loadata();
        }

        private void Data_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxSdt.Text = Data_KhachHang.Rows[index].Cells[0].Value.ToString();
            tbxHoTen.Text = Data_KhachHang.Rows[index].Cells[1].Value.ToString();
            tbxDiaChi.Text = Data_KhachHang.Rows[index].Cells[2].Value.ToString();
            var kh = _iQlKhachHangService.GetLstKhachHangs().Where(c => c.DienThoai == tbxSdt.Text).FirstOrDefault();
            if (kh.Phai == "Nam")
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }

            if (kh.TinhTrang == 1)
            {
                cbxHoatDong.Checked = true;
            }
            else
            {
                cbxKhongHoatDong.Checked = true;
            }
        }

        private void cbxHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxHoatDong_Click(object sender, EventArgs e)
        {
            if (cbxHoatDong.Checked)
            {
                cbxKhongHoatDong.Checked = false;
            }
        }

        private void cbxKhongHoatDong_Click(object sender, EventArgs e)
        {
            if (cbxKhongHoatDong.Checked)
            {
                cbxHoatDong.Checked = false;
            }
        }

        private void tbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbxTimKiem.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iQlKhachHangService.Save());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            tbxSdt.Text = "";
            tbxHoTen.Text = "";
            tbxDiaChi.Text = "";
            rbtnNam.Checked = true;
            rbtnNu.Checked = true;
            cbxHoatDong.Checked = true;
            cbxKhongHoatDong.Checked = true;
        }
    }
}

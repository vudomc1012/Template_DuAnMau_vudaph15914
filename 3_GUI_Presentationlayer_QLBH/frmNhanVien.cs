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
    public partial class frmNhanVien : Form
    {
        IQLNhanVienService _IqLNhanVienService = new QLNhanVienService();
        private string _Manv;
        public frmNhanVien()
        {
            InitializeComponent();
            loadata();
            Data_NhanVien.Columns["MANV"].Visible = false;
            rbtn_HD.Checked = true;
            rbtn_Nv.Checked = true;

        }
        void loadata()
        {
            _IqLNhanVienService.GetLstNhanViens();
            Data_NhanVien.ColumnCount = 7;
            Data_NhanVien.Columns[0].Name = "Id";
            Data_NhanVien.Columns[1].Name = "Tên nhân viên";
            Data_NhanVien.Columns[2].Name = "Email";
            Data_NhanVien.Columns[3].Name = "Vai trò";
            Data_NhanVien.Columns[4].Name = "Địa chỉ";
            Data_NhanVien.Columns[5].Name = "Tình trạng";
            Data_NhanVien.Columns[6].Name = "MANV";
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "Chức năng";
            dgvCmb.Items.Add("Thêm");
            dgvCmb.Items.Add("Sửa");
            dgvCmb.Items.Add("Xóa");
            DataGridViewButtonColumn DBtn = new DataGridViewButtonColumn();
            DBtn.HeaderText = "Xác nhận";
            DBtn.Name = "Lưu";
            Data_NhanVien.Columns.Add(dgvCmb);
            Data_NhanVien.Columns.Add(DBtn);
            Data_NhanVien.Rows.Clear();
            foreach (var x in _IqLNhanVienService.GetLstNhanViens())
            {
                Data_NhanVien.Rows.Add(x.Id, x.TenNv, x.Email, x.VaiTro == 1 ? "Nhân viên" : "Quản lý", x.DiaChi, x.TinhTrang == 1 ? "Hoạt động" : "Không hoạt đông", x.MaNv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien NhanVien = new NhanVien();
            NhanVien.Id = Data_NhanVien.Rows.Cast<DataGridViewRow>()
                .Max(r => Convert.ToInt32(r.Cells["Id"].Value)) + 1;
            NhanVien.MaNv = "NV" + NhanVien.Id;
            NhanVien.TenNv = tbxHoTen.Text;
            NhanVien.Email = tbxEmail.Text;
            NhanVien.VaiTro = (byte)(rbtn_Nv.Checked ? 1 : 0);
            NhanVien.DiaChi = tbxDiaChi.Text;
            NhanVien.TinhTrang = (byte)(rbtn_HD.Checked ? 1 : 0);
            NhanVien.MatKhau = "123@123";
            NhanVien.statsSave = 0;
            NhanVien.Loginf = 0;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_IqLNhanVienService.Add(NhanVien));
                loadata();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var nhanVien = _IqLNhanVienService.GetLstNhanViens().Where(c => c.MaNv == _Manv).FirstOrDefault();
            nhanVien.TenNv = tbxHoTen.Text;
            nhanVien.Email = tbxEmail.Text;
            nhanVien.VaiTro = (byte)(rbtn_Nv.Checked ? 1 : 0);
            nhanVien.DiaChi = tbxDiaChi.Text;
            nhanVien.TinhTrang = (byte)(rbtn_HD.Checked ? 1 : 0);
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {

                _IqLNhanVienService.Update(nhanVien);
                loadata();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var nhanVien = _IqLNhanVienService.GetLstNhanViens().Where(c => c.MaNv == _Manv).FirstOrDefault();
            rbtn_KhongHD.Checked = true;
            nhanVien.TinhTrang = 0;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_IqLNhanVienService.Remove(nhanVien));
                loadata();
            }
        }

        private void Data_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _Manv = Data_NhanVien.Rows[rowindex].Cells[6].Value.ToString();
            tbxHoTen.Text = Data_NhanVien.Rows[rowindex].Cells[1].Value.ToString();
            tbxEmail.Text = Data_NhanVien.Rows[rowindex].Cells[2].Value.ToString();
            tbxDiaChi.Text = Data_NhanVien.Rows[rowindex].Cells[4].Value.ToString();
            var nv = _IqLNhanVienService.GetLstNhanViens().Where(c => c.MaNv == _Manv).FirstOrDefault();
            if (nv.VaiTro == 0)
            {
                rbtn_Ql.Checked = true;
            }
            else
            {
                rbtn_Nv.Checked = true;
            }

            if (nv.TinhTrang == 0)
            {
                rbtn_KhongHD.Checked = true;
            }
            else
            {
                rbtn_HD.Checked = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IqLNhanVienService.save());
        }

        private void rbtn_Nv_Click(object sender, EventArgs e)
        {
            if (rbtn_Nv.Checked)
            {
                rbtn_Ql.Checked = false;
            }
        }

        private void rbtn_Ql_Click(object sender, EventArgs e)
        {
            if (rbtn_Ql.Checked)
            {
                rbtn_Nv.Checked = false;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (QLNhanVienService._statsSave == false)
            {
                if (MessageBox.Show("Bạn vừa thay đổi dữ liệu\nBạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _IqLNhanVienService.save();
                    this.Close();
                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }
        }
    }
}

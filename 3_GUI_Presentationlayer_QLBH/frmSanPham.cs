using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;
using _2_BusinessLayer_QLBH.IService;
using _2_BusinessLayer_QLBH.Service;

namespace _3_GUI_Presentationlayer_QLBH
{
    public partial class frmSanPham : Form
    {
        private IQLSanPhamService _iQlSanPhamService;
        private int _masp;
        private byte[] _arrImg;
        private string path = "";
        public frmSanPham()
        {
            InitializeComponent();
            _iQlSanPhamService = new QLSanPhamService();
            load();
        }
        void load()
        {
            Data_SanPham.ColumnCount = 7;
            Data_SanPham.Columns[0].Name = "Tên sản phẩm";
            Data_SanPham.Columns[1].Name = "Số lượng";
            Data_SanPham.Columns[2].Name = "Giá nhập";
            Data_SanPham.Columns[3].Name = "Giá bán";
            Data_SanPham.Columns[4].Name = "Hình ảnh";
            Data_SanPham.Columns[5].Name = "Ghi chú";
            Data_SanPham.Columns[6].Name = "Mã";
            Data_SanPham.Columns[6].Visible = false;
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "Chức năng";
            dgvCmb.Items.Add("Thêm");
            dgvCmb.Items.Add("Sửa");
            dgvCmb.Items.Add("Xóa");
            DataGridViewButtonColumn DBtn = new DataGridViewButtonColumn();
            DBtn.HeaderText = "Xác nhận";
            DBtn.Name = "Lưu";
            Data_SanPham.Columns.Add(dgvCmb);
            Data_SanPham.Columns.Add(DBtn);
            Data_SanPham.Rows.Clear();
            foreach (var x in _iQlSanPhamService.GetLstsSanPhams())
            {
                Data_SanPham.Rows.Add(x.TenSanPham, x.SoLuong, x.DonGiaBan, x.DonGiaNhap, x.HinhAnh, x.GhiChu, x.MaSanPham);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            // sanPham.MaNv = frmLogin._MaNV;
            sanPham.MaSanPham = Data_SanPham.Rows.Cast<DataGridViewRow>()
                .Max(r => Convert.ToInt32(r.Cells["Mã"].Value)) + 1;
            sanPham.TenSanPham = tbxTensp.Text;
            sanPham.SoLuong = Convert.ToInt32(tbxSl.Text);
            sanPham.DonGiaBan = Convert.ToDouble(tbxban.Text);
            sanPham.DonGiaNhap = Convert.ToDouble(tbxGiaNhap.Text);
            sanPham.HinhAnh = path;
            sanPham.GhiChu = tbxGhiChu.Text;
            sanPham.statsSave = 0;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlSanPhamService.Add(sanPham);
            }
            load();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var sanPham = _iQlSanPhamService.GetLstsSanPhams().Where(c => c.MaSanPham == _masp).FirstOrDefault();
            //sanPham.MaNv = frmLogin._MaNV;
            sanPham.TenSanPham = tbxTensp.Text;
            sanPham.SoLuong = Convert.ToInt32(tbxSl.Text);
            sanPham.DonGiaBan = Convert.ToDouble(tbxban.Text);
            sanPham.DonGiaNhap = Convert.ToDouble(tbxGiaNhap.Text);
            sanPham.HinhAnh = path;
            sanPham.GhiChu = tbxGhiChu.Text;

            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlSanPhamService.Edit(sanPham);
            }
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLSanPhamService qlSanPham = new QLSanPhamService();
            if (MessageBox.Show("Bạn có chắc xóa không", "Có", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var sanPham = _iQlSanPhamService.GetLstsSanPhams().Where(c => c.MaSanPham == _masp).FirstOrDefault();
                var xoa = sanPham.MaSanPham;
                MessageBox.Show(qlSanPham.Remove(sanPham));
                load();
            }
        }

        private void Data_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex == -1 || _iQlSanPhamService.GetLstsSanPhams().Count == rowIndex)
            {
                return;
            }

            _masp = Convert.ToInt32(Data_SanPham.Rows[rowIndex].Cells[6].Value.ToString());
            tbxTensp.Text = Data_SanPham.Rows[rowIndex].Cells[0].Value.ToString();
            tbxSl.Text = Data_SanPham.Rows[rowIndex].Cells[1].Value.ToString();
            tbxGiaNhap.Text = Data_SanPham.Rows[rowIndex].Cells[2].Value.ToString();
            tbxban.Text = Data_SanPham.Rows[rowIndex].Cells[3].Value.ToString();
            string path = Data_SanPham.Rows[rowIndex].Cells[4].Value.ToString();
            tbxGhiChu.Text = Data_SanPham.Rows[rowIndex].Cells[5].Value.ToString();
            pictureBox1.Image = byteArrayToImage(ChuyenAnh(path));
            pictureBox1.Image = Image.FromFile(path);
            pictureBox1.Image = Image.FromFile(path);
            var sanpham = _iQlSanPhamService.GetLstsSanPhams().Where(c => c.MaSanPham == _masp).FirstOrDefault();
            if (Data_SanPham.Columns[rowIndex].Name == "Sửa")
            {
                if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                    "Thông báo",
                    MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    _iQlSanPhamService.Edit(sanpham);
                    load();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //_iQlSanPhamService.save();
            MessageBox.Show(_iQlSanPhamService.save());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (QLSanPhamService._StatsSave == false)
            {
                if (MessageBox.Show("Bạn vừa thay đổi dữ liệu\nBạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _iQlSanPhamService.save();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnimg_Click(object sender, EventArgs e)
        {
            string path1 = ChuyenFile();
            _arrImg = ChuyenAnh(path1);
            pictureBox1.Image = Image.FromFile(path1);
        }
        public string ChuyenFile()
        {
            path = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.jfif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return path = dlg.FileName;
            }
            return path;
        }
        public byte[] ChuyenAnh(string pathIMG)
        {
            try
            {
                Image theImage = Image.FromFile(pathIMG);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    theImage.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            tbxTensp.Text = "";
            tbxSl.Text = "";
            tbxGiaNhap.Text = "";
            tbxban.Text = "";
            tbxGhiChu.Text = "";
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                return Image.FromStream(ms, true);
            }
            catch
            {
                throw;
            }
        }
    }
}

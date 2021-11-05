using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BusinessLayer_QLBH.IService;
using _2_BusinessLayer_QLBH.Service;

namespace _3_GUI_Presentationlayer_QLBH
{
    public partial class frmDoiMatKhau : Form
    {
        private IQLNhanVienService _iqlQlNhanVienService;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            _iqlQlNhanVienService = new QLNhanVienService();
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            if (_iqlQlNhanVienService.GetLstNhanViens().Where(c => c.Email == tbxTk.Text && c.MatKhau == tbxMkCu.Text) != null)
            {
                if (tbxNhaplaimk.Text != tbxMatKhauMoi.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không chính xác", "Thông báo");
                }
                else
                {
                    var nhanv = _iqlQlNhanVienService.GetLstNhanViens().Where(c => c.Email == tbxTk.Text)
                        .FirstOrDefault();
                    nhanv.MatKhau = tbxMatKhauMoi.Text;

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

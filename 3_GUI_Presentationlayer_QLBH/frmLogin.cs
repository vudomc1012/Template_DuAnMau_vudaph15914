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
    public partial class frmLogin : Form
    {
        private IQLNhanVienService _iQlNhanVienService;
        private frmMain Main;
        public static string _MaNV;
        public static int checkForm = -1;
        public frmLogin()
        {
            InitializeComponent();
            _iQlNhanVienService = new QLNhanVienService();
            Main = new frmMain();
        }

        public int checkLogin(string email, string pass)
        {
            try
            {
                var nhanvien = _iQlNhanVienService.GetLstNhanViens().Where(c => c.Email == email).FirstOrDefault();

                if (nhanvien != null)
                {
                    bool ktra = nhanvien.MatKhau == /*uni.MaHoaPass*/(pass) ? true : false;
                    if (ktra)
                    {
                        var role = nhanvien.VaiTro;
                        return role;
                    }
                }


                return -1;

            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = tbxEmail.Text;
            var pass = tbxMatKhau.Text;
            checkForm = checkLogin(email, (pass));
            if (checkForm == 0)
            {
                this.Hide();
                frmMain frmMain = new frmMain();//Khởi tạo lớp đối tượng
                frmMain.Show();
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            else if (checkForm == 1)
            {
                frmMain frmMain = new frmMain();//Khởi tạo lớp đối tượng
                //this.Hide();
                this.Close();
                frmMain.Show();
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm trả lại Acc & Pass", "Thông báo");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmMain frmMain = new frmMain();
            //Main.frmMain_Load(sender, e);
            //frmMain.ActiveForm.Hide();
            //frmMain.Show();
        }

        private void LinkQuenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau frmQuenMatKhau = new frmQuenMatKhau();
            frmQuenMatKhau.Show();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau();
            doiMatKhau.Show();

        }
    }
}

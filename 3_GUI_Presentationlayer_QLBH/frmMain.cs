using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_GUI_Presentationlayer_QLBH;

namespace _3_GUI_Presentationlayer_QLBH
{
    public partial class frmMain : Form
    {
        public static int _CheckLogin = 0;
        public frmMain()
        {
            InitializeComponent();
            _CheckLogin = frmLogin.checkForm;
            closemenu();
            open();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.Show();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        public void open()
        {
            if (_CheckLogin == 1)
            {
                openMenuNV();
            }
            else if (_CheckLogin == 0)
            {
                openMenuQL();
            }
        }
        public void closemenu()
        {
            nhânViênToolStripMenuItem.Enabled = false;
            quảnLýToolStripMenuItem.Enabled = false;
            kháchHàngToolStripMenuItem.Enabled = false;
        }

        public void openMenuQL()  
        {
            nhânViênToolStripMenuItem.Enabled = true;
            quảnLýToolStripMenuItem.Enabled = true;
            kháchHàngToolStripMenuItem.Enabled = true;
        }
        public void openMenuNV()
        {
            nhânViênToolStripMenuItem.Enabled = false;
            quảnLýToolStripMenuItem.Enabled = true;
            kháchHàngToolStripMenuItem.Enabled = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}

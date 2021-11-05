using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_Presentationlayer_QLBH
{
    public partial class frmQuenMatKhau : Form
    {
        private string _pass;
        private string _code;

        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _pass;
            _pass = PassRandom(6);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
            NetworkCredential cred = new NetworkCredential("vudaph15914@fpt.edu.vn", "Anhvudomc10122");
            MailMessage mgs = new MailMessage();
            mgs.From = new MailAddress("vudaph15914@fpt.edu.vn");
            mgs.To.Add(tbxEmail.Text);
            mgs.Subject = "Mật Khẩu";
            mgs.Body = "Mật khẩu là: " + _pass + "";
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(mgs);
        }
        public string PassRandom(int lengthCode)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";//String char for random password
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, lengthCode)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        public void SendMail(string mail)
        {
            _pass = PassRandom(6); //Random tự động 
            _code = PassRandom(6);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
            NetworkCredential cred = new NetworkCredential("vudaph15914@fpt.edu.vn", "Anhvudomc10122");
            MailMessage mgs = new MailMessage();
            mgs.From = new MailAddress("vudaph15914@fpt.edu.vn");
            mgs.To.Add(mail);
            mgs.Subject = "Quên mật khẩu";
            mgs.Body = "Mật khẩu mới là: " + _pass + "\nMã xác nhận của bạn là :" + _code + "\n Mã sẽ vô hiệu lực sau 1 phút";
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(mgs);
        }
    }
}

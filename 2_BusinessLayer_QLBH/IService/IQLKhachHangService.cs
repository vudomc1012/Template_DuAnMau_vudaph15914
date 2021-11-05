using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

namespace _2_BusinessLayer_QLBH.IService
{
    public interface IQLKhachHangService
    {
        public string Add(KhachHang khachHang);
        public string Edit(KhachHang khachHang);
        public string Remove(KhachHang khachHang);
        public string Save();
        public List<KhachHang> Search(string nv);
        public List<KhachHang> GetLstKhachHangs();
        public void GetKhDb();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

namespace _1_DAL_DatabaseAccessLayer_QLBH.IDALService
{
    public interface IKhachHangService
    {
        public string AddKH(KhachHang khachHang);
        public string EditKH(KhachHang khachHang);
        public string remoteKH(KhachHang khachHang);
        public string save();
        public List<KhachHang> GetLstKHformDB();
    }
}

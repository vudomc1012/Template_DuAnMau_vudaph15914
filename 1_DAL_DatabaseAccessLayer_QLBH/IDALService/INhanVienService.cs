using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

namespace _1_DAL_DatabaseAccessLayer_QLBH.IDALService
{
    public interface INhanVienService
    {
        public string AddNV(NhanVien nhanVien);
        public string EditNV(NhanVien nhanVien);
        public string remoteNV(NhanVien nhanVien);
        public string Save();
        public List<NhanVien> GetLstNVformDB();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

namespace _1_DAL_DatabaseAccessLayer_QLBH.IDALService
{
    public interface ISanPhamService
    {
        public string AddSP(SanPham sanPham);
        public string EditSP(SanPham sanPham);
        public string remoteSP(SanPham sanPham);
        public string Save();
        public List<SanPham> GetLstSPformDB();
    }
}

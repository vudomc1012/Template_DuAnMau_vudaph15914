using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

namespace _2_BusinessLayer_QLBH.IService
{
    public interface IQLSanPhamService
    {
        public string Add(SanPham sanPham);
        public string Edit(SanPham sanPham);
        public string Remove(SanPham sanPham);
        public string save();
        public List<SanPham> Search(string nv);
        public List<SanPham> GetLstsSanPhams();
        public void GetDB();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

namespace _2_BusinessLayer_QLBH.IService
{
    public interface IQLNhanVienService
    {
        public string Add(NhanVien nhanVien);
        public string Update(NhanVien nhanVien);
        public string Remove(NhanVien nhanVien);
        public string save();
        public List<NhanVien> Search(string nv);
        public List<NhanVien> GetLstNhanViens();
        public void GetLst();
    }
}

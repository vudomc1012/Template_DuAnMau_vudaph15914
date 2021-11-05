using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.DALService;
using _1_DAL_DatabaseAccessLayer_QLBH.IDALService;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;
using _2_BusinessLayer_QLBH.IService;

namespace _2_BusinessLayer_QLBH.Service
{
    public class QLNhanVienService : IQLNhanVienService
    {
        private INhanVienService _iNhanVienService;
        private List<NhanVien> _getLstNhanViens;
        public static bool _statsSave = true;

        public QLNhanVienService()
        {
            _iNhanVienService = new NhanVienService();
            GetLst();
        }

        public string Add(NhanVien nhanVien)
        {
            _statsSave = false;
            _getLstNhanViens.Add(nhanVien);
            return _iNhanVienService.AddNV(nhanVien);
        }

        public string Update(NhanVien nhanVien)
        {
            _statsSave = false;
            var index = _getLstNhanViens.FindIndex(c => c == nhanVien);
            _getLstNhanViens[index] = nhanVien;
            return _iNhanVienService.EditNV(nhanVien);
        }

        public string Remove(NhanVien nhanVien)
        {
            _statsSave = false;
            var index = _getLstNhanViens.FindIndex(c => c == nhanVien);
            _getLstNhanViens[index] = nhanVien;
            return _iNhanVienService.EditNV(nhanVien);
        }

        public string save()
        {
            foreach (var x in _getLstNhanViens.Where(c => c.statsSave == 0))
            {

                x.statsSave = 1;
                _iNhanVienService.AddNV(x);

            }
            _statsSave = true;
            return _iNhanVienService.Save();
        }

        public List<NhanVien> Search(string nv)
        {
            return _getLstNhanViens.Where(c => c.TenNv.StartsWith(nv)).ToList();
        }

        public List<NhanVien> GetLstNhanViens()
        {
            return _getLstNhanViens;
        }

        public void GetLst()
        {
            _getLstNhanViens = _iNhanVienService.GetLstNVformDB();
        }
    }
}

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
    public class QLSanPhamService : IQLSanPhamService
    {
        private ISanPhamService _iSanPhamService;
        private List<SanPham> _lstSanPhams;
        public static bool _StatsSave = true;
        public QLSanPhamService()
        {
            _iSanPhamService = new SanPhamService();
            _lstSanPhams = new List<SanPham>();
            GetDB();

        }
        public string Add(SanPham sanPham)
        {
            _StatsSave = false;
            _lstSanPhams.Add(sanPham);
            return _iSanPhamService.AddSP(sanPham);
        }

        public string Edit(SanPham sanPham)
        {
            _StatsSave = false;
            int index = _iSanPhamService.GetLstSPformDB().FindIndex(c => c == sanPham);
            _lstSanPhams[index] = sanPham;
            return _iSanPhamService.EditSP(sanPham);
        }

        public string Remove(SanPham sanPham)
        {
            _StatsSave = false;
            int index = _iSanPhamService.GetLstSPformDB().FindIndex(c => c == sanPham);
            _lstSanPhams[index] = sanPham;
            return _iSanPhamService.EditSP(sanPham);
        }

        public string save()
        {
            foreach (var x in _lstSanPhams.Where(c => c.statsSave == 0))
            {
                x.statsSave = 1;
                _iSanPhamService.AddSP(x);
            }
            _StatsSave = true;
            return _iSanPhamService.Save();
        }

        public List<SanPham> Search(string nv)
        {
            return _lstSanPhams.Where(c => c.TenSanPham.StartsWith(nv)).ToList();
        }

        public List<SanPham> GetLstsSanPhams()
        {
            return _lstSanPhams;
        }

        public void GetDB()
        {
            _lstSanPhams = _iSanPhamService.GetLstSPformDB().ToList();
        }
    }
}

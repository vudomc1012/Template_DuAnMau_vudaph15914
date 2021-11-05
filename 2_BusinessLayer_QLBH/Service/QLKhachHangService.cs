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
    public class QLKhachHangService : IQLKhachHangService
    {
        private IKhachHangService _iKhachHangService;
        private List<KhachHang> _getLstKhachHangs;
        public static bool _statsSave = true;

        public QLKhachHangService()
        {
            _iKhachHangService = new KhachHangService();
            _getLstKhachHangs = new List<KhachHang>();
            GetKhDb();
        }

        public string Add(KhachHang khachHang)
        {

            _statsSave = false;
            _getLstKhachHangs.Add(khachHang);
            return _iKhachHangService.AddKH(khachHang);
        }

        public string Edit(KhachHang khachHang)
        {
            _statsSave = false;
            int index = _getLstKhachHangs.FindIndex(c => c == khachHang);
            _getLstKhachHangs[index] = khachHang;
            return _iKhachHangService.EditKH(khachHang);
        }

        public string Remove(KhachHang khachHang)
        {
            _statsSave = false;
            int index = _getLstKhachHangs.FindIndex(c => c == khachHang);
            _getLstKhachHangs[index] = khachHang;
            return _iKhachHangService.EditKH(khachHang);
        }

        public string Save()
        {
            foreach (var x in _getLstKhachHangs.Where(c => c.statsSave == 0))
            {
                x.statsSave = 1;
                _iKhachHangService.AddKH(x);
            }

            _statsSave = true;

            return _iKhachHangService.save();
        }

        public List<KhachHang> Search(string ten)
        {
            return _getLstKhachHangs.Where(c => c.TenKhach.StartsWith(ten)).ToList();
        }

        public List<KhachHang> GetLstKhachHangs()
        {
            return _getLstKhachHangs;
        }

        public void GetKhDb()
        {
            _getLstKhachHangs = _iKhachHangService.GetLstKHformDB();
        }
    }
}

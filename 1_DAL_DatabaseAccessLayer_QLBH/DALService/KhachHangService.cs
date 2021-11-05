using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DatabaseAccessLayer_QLBH.Context;
using _1_DAL_DatabaseAccessLayer_QLBH.IDALService;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

namespace _1_DAL_DatabaseAccessLayer_QLBH.DALService
{
    public class KhachHangService : IKhachHangService
    {
        DatabaseContext _dbContext;
        private List<KhachHang> _getLstKhachHangs;
        public KhachHangService()
        {
            _dbContext = new DatabaseContext();
            _getLstKhachHangs = new List<KhachHang>();
            GetLstKHformDB();
        }
        public string AddKH(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Add(khachHang);

            return "Thêm thành công";
        }

        public string EditKH(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Update(khachHang);

            return "Sửa thành công";
        }

        public string remoteKH(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Update(khachHang);

            return "Sửa thành công";
        }

        public string save()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }

        public List<KhachHang> GetLstKHformDB()
        {
            return _getLstKhachHangs = _dbContext.KhachHangs.ToList();
        }
    }
}

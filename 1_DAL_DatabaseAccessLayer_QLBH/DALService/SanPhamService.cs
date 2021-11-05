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
    public class SanPhamService : ISanPhamService
    {
        private DatabaseContext _dbContext;
        private List<SanPham> _GetLstsp;
        public SanPhamService()
        {
            _dbContext = new DatabaseContext();
            _GetLstsp = new List<SanPham>();
            GetLstSPformDB();
        }
        public string AddSP(SanPham sanPham)
        {
            _dbContext.SanPhams.Add(sanPham);
            return "Thêm thành công";
        }

        public string EditSP(SanPham sanPham)
        {
            _dbContext.SanPhams.Update(sanPham);
            return "Sửa thành công";
        }

        public string remoteSP(SanPham sanPham)
        {
            _dbContext.SanPhams.Update(sanPham);

            return "Xóa thành công";
        }

        public string Save()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }

        public List<SanPham> GetLstSPformDB()
        {
            return _GetLstsp = _dbContext.SanPhams.ToList();
        }
    }
}

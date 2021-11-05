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
    public class NhanVienService : INhanVienService
    {
        private DatabaseContext _dbContext;
        private List<NhanVien> _GetLstNV;

        public NhanVienService()
        {
            _dbContext = new DatabaseContext();
            _GetLstNV = new List<NhanVien>();

        }
        public string AddNV(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Add(nhanVien);

            return "Thêm thành công";
        }

        public string EditNV(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Update(nhanVien);

            return "Sửa thành công";
        }

        public string remoteNV(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Update(nhanVien);

            return "Xóa thành công";
        }
        public List<NhanVien> GetLstNVformDB()
        {
            return _GetLstNV = _dbContext.NhanViens.ToList(); 
        }
        public string Save()
        {
            try
            {
                _dbContext.SaveChanges();
                return "Lưu thành công";
            }
            catch (Exception e)
            {
                return e.Message;

            }
        }
    }
}

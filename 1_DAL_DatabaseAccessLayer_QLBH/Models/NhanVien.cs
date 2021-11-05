using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DatabaseAccessLayer_QLBH.Models
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            KhachHangs = new HashSet<KhachHang>();
            SanPhams = new HashSet<SanPham>();
        }

        public int? Id { get; set; }
        [Key]
        [Column("MaNV")]
        [StringLength(20)]
        public string MaNv { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [Column("TenNV")]
        [StringLength(50)]
        public string TenNv { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        public byte VaiTro { get; set; }
        public byte TinhTrang { get; set; }
        public byte Loginf { get; set; }
        public byte statsSave { get; set; }
        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [InverseProperty(nameof(KhachHang.MaNvNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        [InverseProperty(nameof(SanPham.MaNvNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}

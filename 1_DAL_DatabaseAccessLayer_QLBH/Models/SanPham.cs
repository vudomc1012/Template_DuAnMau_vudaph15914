using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DatabaseAccessLayer_QLBH.Models
{
    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSanPham { get; set; }
        [Required]
        [StringLength(50)]
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaBan { get; set; }
        public double DonGiaNhap { get; set; }
        [Required]
        [StringLength(400)]
        public string HinhAnh { get; set; }
        [Required]
        [StringLength(20)]
        public string GhiChu { get; set; }
        public byte statsSave { get; set; }
        [Required]
        [Column("MaNV")]
        [StringLength(20)]
        public string MaNv { get; set; }

        [ForeignKey(nameof(MaNv))]
        [InverseProperty(nameof(NhanVien.SanPhams))]
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}

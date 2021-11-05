using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DatabaseAccessLayer_QLBH.Migrations
{
    public partial class Vu9876 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VaiTro = table.Column<byte>(type: "tinyint", nullable: false),
                    TinhTrang = table.Column<byte>(type: "tinyint", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__2725D70A7FF9AD11", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    DienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TenKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phai = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaNV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__1F031877DF2266FE", x => x.DienThoai);
                    table.ForeignKey(
                        name: "FK__KhachHang__MaNV__3C69FB99",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<double>(type: "float", nullable: false),
                    DonGiaNhap = table.Column<double>(type: "float", nullable: false),
                    HinhAnh = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MaNV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__FAC7442D5ACC255A", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK__SanPham__MaNV__398D8EEE",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaNV",
                table: "KhachHang",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaNV",
                table: "SanPham",
                column: "MaNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}

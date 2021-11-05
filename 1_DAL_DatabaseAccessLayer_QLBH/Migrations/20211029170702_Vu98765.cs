using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DatabaseAccessLayer_QLBH.Migrations
{
    public partial class Vu98765 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "statsSave",
                table: "SanPham",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Loginf",
                table: "NhanVien",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "statsSave",
                table: "NhanVien",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "TinhTrang",
                table: "KhachHang",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "statsSave",
                table: "KhachHang",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "statsSave",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "Loginf",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "statsSave",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "statsSave",
                table: "KhachHang");
        }
    }
}

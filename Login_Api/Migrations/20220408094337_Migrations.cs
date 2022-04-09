using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Login_Api.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DangNhap",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Matkhau = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangNhap", x => x.LoginId);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__DangNhap__4DDA28192B3845B8",
                table: "DangNhap",
                column: "LoginId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangNhap");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenVanCuong2022560.Migrations
{
    public partial class Create_Table_NVC0560 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NVC0560",
                columns: table => new
                {
                    NVCID = table.Column<string>(type: "TEXT", nullable: false),
                    NVCName = table.Column<string>(type: "TEXT", nullable: false),
                    NVCGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVC0560", x => x.NVCID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NVC0560");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool_WebApi.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Services",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Services",
                table: "RoomTypes");
        }
    }
}

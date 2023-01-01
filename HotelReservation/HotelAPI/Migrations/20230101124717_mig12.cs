using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool_WebApi.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BedSize",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BedSize",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "RoomTypes");
        }
    }
}

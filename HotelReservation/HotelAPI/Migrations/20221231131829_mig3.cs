using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool_WebApi.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumGuests",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "RoomTypes");

            migrationBuilder.AddColumn<int>(
                name: "MaximumGuests",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

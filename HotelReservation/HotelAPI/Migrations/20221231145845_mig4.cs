using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool_WebApi.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerAddress",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerCity",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerPhone",
                table: "Bookings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCity",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerPhone",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

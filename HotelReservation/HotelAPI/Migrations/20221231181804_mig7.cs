using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool_WebApi.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BasePrice",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ExtraDescription",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ExtraDescription",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Rooms");
        }
    }
}

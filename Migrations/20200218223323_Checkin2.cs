using Microsoft.EntityFrameworkCore.Migrations;

namespace OtroEF.Migrations
{
    public partial class Checkin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "LicensePlate", "Line", "Model" },
                values: new object[] { 1, "Opel", "AAA111", "Corsa", 2008 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "LicensePlate", "Line", "Model" },
                values: new object[] { 2, "Renault", "AAA112", "Logal", 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

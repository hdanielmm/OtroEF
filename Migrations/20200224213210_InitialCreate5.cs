using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtroEF.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VehicleReviews",
                columns: new[] { "Id", "DateReview", "EmployeeId", "VehicleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2020, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, new DateTime(2020, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 4, new DateTime(2020, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 5, new DateTime(2020, 3, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 6, new DateTime(2020, 3, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 7, new DateTime(2020, 3, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "PartReviews",
                columns: new[] { "Id", "DateReview", "Diagnosis", "EmployeeId", "VehiclePartId", "VehicleReviewId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), "Diagnosis 1", 5, 1, 1 },
                    { 2, new DateTime(2020, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "Diagnosis 2", 5, 1, 2 },
                    { 3, new DateTime(2020, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "Diagnosis 3", 5, 1, 3 },
                    { 4, new DateTime(2020, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), "Diagnosis 4", 5, 1, 4 },
                    { 5, new DateTime(2020, 3, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), "Diagnosis 5", 5, 1, 5 },
                    { 6, new DateTime(2020, 3, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), "Diagnosis 6", 5, 1, 6 },
                    { 7, new DateTime(2020, 3, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "Diagnosis 7", 5, 1, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PartReviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PartReviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PartReviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PartReviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PartReviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PartReviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PartReviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleReviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleReviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleReviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleReviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleReviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleReviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleReviews",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}

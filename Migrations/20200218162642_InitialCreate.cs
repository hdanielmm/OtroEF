using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtroEF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LicensePlate = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Model = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateReview = table.Column<DateTime>(nullable: false),
                    LicensePlate = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleReviews_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleReviews_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateReview = table.Column<DateTime>(nullable: false),
                    Diagnosis = table.Column<string>(nullable: true),
                    VehicleReviewId = table.Column<int>(nullable: false),
                    VehiclePartId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartReviews_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartReviews_VehicleParts_VehiclePartId",
                        column: x => x.VehiclePartId,
                        principalTable: "VehicleParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartReviews_VehicleReviews_VehicleReviewId",
                        column: x => x.VehicleReviewId,
                        principalTable: "VehicleReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartReviews_EmployeeId",
                table: "PartReviews",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartReviews_VehiclePartId",
                table: "PartReviews",
                column: "VehiclePartId");

            migrationBuilder.CreateIndex(
                name: "IX_PartReviews_VehicleReviewId",
                table: "PartReviews",
                column: "VehicleReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleReviews_EmployeeId",
                table: "VehicleReviews",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleReviews_VehicleId",
                table: "VehicleReviews",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartReviews");

            migrationBuilder.DropTable(
                name: "VehicleParts");

            migrationBuilder.DropTable(
                name: "VehicleReviews");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}

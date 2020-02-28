﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtroEF.Migrations
{
    public partial class InitialCreate4 : Migration
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
                    VehicleId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Employee01" },
                    { 2, "Employee02" },
                    { 3, "Employee03" },
                    { 4, "Employee04" },
                    { 5, "Employee05" },
                    { 6, "Employee06" },
                    { 7, "Employee07" }
                });

            migrationBuilder.InsertData(
                table: "VehicleParts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Vehicle part 10" },
                    { 9, "Vehicle part 09" },
                    { 8, "Vehicle part 08" },
                    { 7, "Vehicle part 07" },
                    { 6, "Vehicle part 06" },
                    { 5, "Vehicle part 05" },
                    { 4, "Vehicle part 04" },
                    { 3, "Vehicle part 03" },
                    { 2, "Vehicle part 02" },
                    { 12, "Vehicle part 12" },
                    { 11, "Vehicle part 11" },
                    { 1, "Vehicle part 01" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "LicensePlate", "Line", "Model" },
                values: new object[,]
                {
                    { 8, "Renault", "AAA118", "symbol", 2015 },
                    { 6, "Chevrolet", "AAA116", "Corsa", 2013 },
                    { 5, "Renault", "AAA115", "Logan", 2012 },
                    { 4, "Opel", "AAA114", "Corsa", 2011 },
                    { 3, "Chevrolet", "AAA113", "Sail", 2010 },
                    { 2, "Renault", "AAA112", "Sandero", 2009 },
                    { 1, "Opel", "AAA111", "Corsa", 2008 },
                    { 7, "Opel", "AAA117", "Corsa", 2014 }
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
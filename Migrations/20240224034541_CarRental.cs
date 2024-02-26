using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class CarRental : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PricePerNight",
                table: "Hotels",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.CreateTable(
                name: "CarRentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RentalAgency = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PricePerDay = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRentals", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CarRentals",
                columns: new[] { "Id", "IsAvailable", "Model", "PricePerDay", "RentalAgency" },
                values: new object[,]
                {
                    { 1, true, "Toyota Camry", 50.00m, "ABC Rentals" },
                    { 2, false, "Honda Civic", 45.00m, "XYZ Rentals" },
                    { 3, true, "Ford Mustang", 70.00m, "123 Rentals" }
                });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 2, 24, 0, 45, 40, 959, DateTimeKind.Local).AddTicks(6130), new DateTime(2024, 2, 23, 22, 45, 40, 959, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 2, 24, 3, 45, 40, 959, DateTimeKind.Local).AddTicks(6140), new DateTime(2024, 2, 24, 1, 45, 40, 959, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "PricePerNight",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "PricePerNight",
                value: 120f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarRentals");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerNight",
                table: "Hotels",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 33, 8, 753, DateTimeKind.Local).AddTicks(8660), new DateTime(2024, 2, 23, 9, 33, 8, 753, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 2, 23, 14, 33, 8, 753, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 2, 23, 12, 33, 8, 753, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "PricePerNight",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "PricePerNight",
                value: 120m);
        }
    }
}

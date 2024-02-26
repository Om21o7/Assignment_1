using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 
namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class Hotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Flights",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 33, 8, 753, DateTimeKind.Local).AddTicks(8660), new DateTime(2024, 2, 23, 9, 33, 8, 753, DateTimeKind.Local).AddTicks(8620), 200f });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2024, 2, 23, 14, 33, 8, 753, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 2, 23, 12, 33, 8, 753, DateTimeKind.Local).AddTicks(8670), 250f });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "IsAvailable", "Location", "Name", "PricePerNight", "Rating" },
                values: new object[,]
                {
                    { 1, true, "City X", "Hotel ABC", 150m, 4 },
                    { 2, true, "City Y", "Hotel XYZ", 120m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Flights",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2024, 2, 23, 0, 53, 17, 328, DateTimeKind.Local).AddTicks(6130), new DateTime(2024, 2, 22, 22, 53, 17, 328, DateTimeKind.Local).AddTicks(6100), 200m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2024, 2, 23, 3, 53, 17, 328, DateTimeKind.Local).AddTicks(6140), new DateTime(2024, 2, 23, 1, 53, 17, 328, DateTimeKind.Local).AddTicks(6130), 250m });
        }
    }
}

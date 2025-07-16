using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Offer_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 16, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5503), "Делимобиль" },
                    { 2, new DateTime(2025, 6, 21, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5517), "Тачковоз" },
                    { 3, new DateTime(2025, 6, 26, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5519), "ООО Тмыв" },
                    { 4, new DateTime(2025, 7, 1, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5520), "Газпром" },
                    { 5, new DateTime(2025, 7, 6, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5521), "Моторчик" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Brand", "Model", "RegistrationDate", "SupplierId" },
                values: new object[,]
                {
                    { 1, "Toyota", "Camry", new DateTime(2025, 7, 11, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5616), 1 },
                    { 2, "Honda", "Civic", new DateTime(2025, 7, 12, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5617), 1 },
                    { 3, "Ford", "Focus", new DateTime(2025, 7, 13, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5619), 1 },
                    { 4, "BMW", "X5", new DateTime(2025, 7, 14, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5620), 2 },
                    { 5, "Audi", "A4", new DateTime(2025, 7, 15, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5621), 2 },
                    { 6, "Mercedes", "C-Class", new DateTime(2025, 7, 16, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5623), 2 },
                    { 7, "Daewoo", "Matiz", new DateTime(2025, 7, 10, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5624), 3 },
                    { 8, "Hyundai", "Tucson", new DateTime(2025, 7, 11, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5625), 3 },
                    { 9, "Kia", "Sportage", new DateTime(2025, 7, 12, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5626), 3 },
                    { 10, "Nissan", "Juke", new DateTime(2025, 7, 13, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5628), 4 },
                    { 11, "Chevrolet", "Malibu", new DateTime(2025, 7, 14, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5629), 4 },
                    { 12, "Tesla", "Model 3", new DateTime(2025, 7, 15, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5630), 4 },
                    { 13, "Subaru", "Outback", new DateTime(2025, 7, 16, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5631), 5 },
                    { 14, "Mazda", "Miata", new DateTime(2025, 7, 15, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5632), 5 },
                    { 15, "Lada", "Samara", new DateTime(2025, 7, 14, 22, 30, 53, 380, DateTimeKind.Local).AddTicks(5634), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_SupplierId",
                table: "Offers",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}

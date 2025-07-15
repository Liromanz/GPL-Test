using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Offer_API.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    { 1, new DateTime(2025, 6, 15, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1027), "Делимобиль" },
                    { 2, new DateTime(2025, 6, 20, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1047), "Тачковоз" },
                    { 3, new DateTime(2025, 6, 25, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1050), "ООО Тмыв" },
                    { 4, new DateTime(2025, 6, 30, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1052), "Газпром" },
                    { 5, new DateTime(2025, 7, 5, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1054), "Моторчик" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Brand", "Model", "RegistrationDate", "SupplierId" },
                values: new object[,]
                {
                    { 1, "Toyota", "Camry", new DateTime(2025, 7, 10, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1213), 1 },
                    { 2, "Honda", "Civic", new DateTime(2025, 7, 11, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1217), 1 },
                    { 3, "Ford", "Focus", new DateTime(2025, 7, 12, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1220), 1 },
                    { 4, "BMW", "X5", new DateTime(2025, 7, 13, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1223), 2 },
                    { 5, "Audi", "A4", new DateTime(2025, 7, 14, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1225), 2 },
                    { 6, "Mercedes", "C-Class", new DateTime(2025, 7, 15, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1228), 2 },
                    { 7, "Daewoo", "Matiz", new DateTime(2025, 7, 9, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1230), 3 },
                    { 8, "Hyundai", "Tucson", new DateTime(2025, 7, 10, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1232), 3 },
                    { 9, "Kia", "Sportage", new DateTime(2025, 7, 11, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1235), 3 },
                    { 10, "Nissan", "Juke", new DateTime(2025, 7, 12, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1237), 4 },
                    { 11, "Chevrolet", "Malibu", new DateTime(2025, 7, 13, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1239), 4 },
                    { 12, "Tesla", "Model 3", new DateTime(2025, 7, 14, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1242), 4 },
                    { 13, "Subaru", "Outback", new DateTime(2025, 7, 15, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1245), 5 },
                    { 14, "Mazda", "Miata", new DateTime(2025, 7, 14, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1247), 5 },
                    { 15, "Lada", "Samara", new DateTime(2025, 7, 13, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1249), 5 }
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

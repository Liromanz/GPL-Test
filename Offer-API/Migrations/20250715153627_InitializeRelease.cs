using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Offer_API.Migrations
{
    /// <inheritdoc />
    public partial class InitializeRelease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 10, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 11, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 12, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 13, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 14, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 15, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 9, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 10, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 11, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 12, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 13, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 14, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 15, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 14, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 13, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 18, 36, 26, 529, DateTimeKind.Local).AddTicks(4077));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 10, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 11, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 12, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 13, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 14, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 15, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 9, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 10, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 11, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 12, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 13, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 14, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 15, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 14, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2025, 7, 13, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 17, 39, 21, 552, DateTimeKind.Local).AddTicks(1054));
        }
    }
}

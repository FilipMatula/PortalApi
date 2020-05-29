using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class tatoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Tattoos",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Tattoos",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Tattoos",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Technique",
                table: "Tattoos",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 30, 16, 36, 25, 452, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 5, 31, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 1, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 2, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 3, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Color", "Date", "Gender", "Style", "Technique" },
                values: new object[] { "Rzeszow", "Czarny", new DateTime(2020, 6, 10, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(9711), "Kobieta", "Styl1", "Handpoke" });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Color", "Date", "Gender", "Style", "Technique" },
                values: new object[] { "Warszawa", "Bialy", new DateTime(2020, 6, 11, 16, 36, 25, 456, DateTimeKind.Local).AddTicks(940), "Mezczyzna", "Styl2", "Handpoke" });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Color", "Date", "Gender", "Style", "Technique" },
                values: new object[] { "Krakow", "Niebieski", new DateTime(2020, 6, 12, 16, 36, 25, 456, DateTimeKind.Local).AddTicks(975), "Kobieta", "Styl3", "Maszynka" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "Technique",
                table: "Tattoos");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 29, 21, 9, 5, 807, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 5, 30, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 5, 31, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 1, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 2, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 9, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(2614), "A1" });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 10, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(3493), "A2" });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 11, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(3518), "A1" });
        }
    }
}

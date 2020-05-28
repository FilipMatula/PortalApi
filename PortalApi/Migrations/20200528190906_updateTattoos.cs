using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class updateTattoos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 29, 21, 7, 44, 928, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 5, 30, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 5, 31, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 1, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 2, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 28, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 9, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(8097), null });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 10, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(8945), null });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 11, 21, 7, 44, 931, DateTimeKind.Local).AddTicks(8981), null });
        }
    }
}

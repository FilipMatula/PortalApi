using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class modelsV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 31, 20, 5, 34, 215, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 1, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 3, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 4, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 30, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 30, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 30, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 30, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 30, 20, 5, 34, 218, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 2, 20, 5, 34, 219, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 3, 20, 5, 34, 220, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Tattoo" },
                values: new object[] { new DateTime(2020, 7, 3, 20, 5, 34, 220, DateTimeKind.Local).AddTicks(416), false });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 31, 20, 5, 34, 219, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 1, 20, 5, 34, 219, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 20, 5, 34, 219, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 20, 5, 34, 219, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 12, 20, 5, 34, 219, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 13, 20, 5, 34, 219, DateTimeKind.Local).AddTicks(2699));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 6, 34, 67, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 1, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 3, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 4, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 30, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 30, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 30, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 30, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 30, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 2, 19, 6, 34, 71, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 3, 19, 6, 34, 71, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Tattoo" },
                values: new object[] { new DateTime(2020, 7, 3, 19, 6, 34, 71, DateTimeKind.Local).AddTicks(7286), true });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 6, 34, 71, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 1, 19, 6, 34, 71, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 19, 6, 34, 71, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 12, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 13, 19, 6, 34, 70, DateTimeKind.Local).AddTicks(9428));
        }
    }
}

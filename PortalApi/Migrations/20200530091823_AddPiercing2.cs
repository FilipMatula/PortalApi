using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class AddPiercing2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 31, 11, 18, 23, 500, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 1, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 3, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 4, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 30, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 30, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 30, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 30, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 30, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Pierce" },
                values: new object[] { new DateTime(2020, 5, 31, 11, 18, 23, 504, DateTimeKind.Local).AddTicks(3457), "Kolczyk" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Pierce" },
                values: new object[] { new DateTime(2020, 6, 1, 11, 18, 23, 504, DateTimeKind.Local).AddTicks(3934), "Kolczyk" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 11, 18, 23, 504, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 11, 18, 23, 503, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 12, 11, 18, 23, 504, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 13, 11, 18, 23, 504, DateTimeKind.Local).AddTicks(667));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 31, 10, 36, 37, 134, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 3, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 4, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Pierce" },
                values: new object[] { new DateTime(2020, 5, 31, 10, 36, 37, 138, DateTimeKind.Local).AddTicks(1512), "kolczyk" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Pierce" },
                values: new object[] { new DateTime(2020, 6, 1, 10, 36, 37, 138, DateTimeKind.Local).AddTicks(1998), "kolczyk2" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 10, 36, 37, 138, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(8602));
        }
    }
}

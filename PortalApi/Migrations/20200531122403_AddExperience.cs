using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class AddExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "Photographers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 14, 24, 2, 687, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 4, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 5, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 14, 24, 2, 692, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 14, 24, 2, 692, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 4, 14, 24, 2, 692, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Experience" },
                values: new object[] { new DateTime(2020, 6, 11, 14, 24, 2, 692, DateTimeKind.Local).AddTicks(9853), 1 });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Experience" },
                values: new object[] { new DateTime(2020, 6, 22, 14, 24, 2, 693, DateTimeKind.Local).AddTicks(361), 3 });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Experience" },
                values: new object[] { new DateTime(2020, 7, 3, 14, 24, 2, 693, DateTimeKind.Local).AddTicks(383), 3 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 14, 24, 2, 692, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 14, 24, 2, 692, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 14, 24, 2, 692, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 12, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 13, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 14, 14, 24, 2, 691, DateTimeKind.Local).AddTicks(8377));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Photographers");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 14, 10, 25, 169, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 4, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 5, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 4, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 14, 10, 25, 174, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 22, 14, 10, 25, 174, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 3, 14, 10, 25, 174, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 12, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 13, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 14, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(351));
        }
    }
}

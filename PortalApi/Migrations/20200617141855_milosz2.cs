using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class milosz2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 22, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 18, 54, 842, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 18, 54, 842, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 18, 54, 842, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 16, 18, 54, 837, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 16, 18, 54, 837, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 21, 16, 18, 54, 837, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 16, 18, 54, 841, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 9, 16, 18, 54, 841, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 16, 18, 54, 841, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "Studio" },
                values: new object[] { "bardzo duzo pracy :)", 3, "FACEBOOK link e", "INSTAGRAM link 3", "TWITTER link 3", 3, "PiercerRZ3" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 29, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 1, 16, 18, 54, 836, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 2, 18, 54, 831, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 4, 18, 54, 834, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 17, 18, 18, 54, 834, DateTimeKind.Local).AddTicks(8218));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 22, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 15, 13, 364, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 15, 13, 364, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 15, 13, 364, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 16, 15, 13, 359, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 16, 15, 13, 359, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 21, 16, 15, 13, 359, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 16, 15, 13, 363, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 9, 16, 15, 13, 363, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 16, 15, 13, 363, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "Studio" },
                values: new object[] { null, 0, null, null, null, 0, null });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 29, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 1, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 2, 15, 13, 353, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 4, 15, 13, 356, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 17, 18, 15, 13, 356, DateTimeKind.Local).AddTicks(7010));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class milosz6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 25, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 26, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 33, 15, 297, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 18, 33, 15, 297, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 18, 33, 15, 297, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 24, 18, 33, 15, 293, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 25, 18, 33, 15, 293, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 25, 18, 33, 15, 293, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter", "UserId" },
                values: new object[] { "Phothographer 1 about ", "FACEBOOK 1 Photographer", "INSTAGRAM 1 PHOTOGRAPHER", "TWITTER 1 PHOTOGRAPHER", 4 });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter", "UserId" },
                values: new object[] { "Phothographer 2 about ", "FACEBOOK 2 Photographer", "INSTAGRAM 2 PHOTOGRAPHER", "TWITTER 2 PHOTOGRAPHER", 5 });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { "Phothographer 3 about ", "FACEBOOK 3 Photographer", "INSTAGRAM 3 PHOTOGRAPHER", "TWITTER 3 PHOTOGRAPHER" });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 2, 18, 33, 15, 297, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 13, 18, 33, 15, 297, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 24, 18, 33, 15, 297, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 33, 15, 292, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 18, 33, 15, 292, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 18, 33, 15, 292, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 5, 18, 33, 15, 291, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 19, 33, 15, 286, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 20, 33, 15, 289, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 21, 33, 15, 289, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 23, 33, 15, 289, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 22, 33, 15, 289, DateTimeKind.Local).AddTicks(5116));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 16, 9, 11, 207, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 16, 9, 11, 207, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 16, 9, 11, 207, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 25, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 26, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 16, 9, 11, 215, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 16, 9, 11, 215, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 16, 9, 11, 215, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 24, 16, 9, 11, 210, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 25, 16, 9, 11, 210, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 25, 16, 9, 11, 210, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter", "UserId" },
                values: new object[] { null, null, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter", "UserId" },
                values: new object[] { null, null, null, null, 2 });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 2, 16, 9, 11, 215, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 13, 16, 9, 11, 215, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 24, 16, 9, 11, 215, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 5, 16, 9, 11, 208, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 9, 11, 203, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 18, 9, 11, 205, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 19, 9, 11, 205, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 21, 9, 11, 205, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 20, 9, 11, 205, DateTimeKind.Local).AddTicks(6250));
        }
    }
}

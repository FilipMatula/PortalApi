using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 4, 12, 945, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 16, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 16, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 16, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 16, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 16, 18, 4, 12, 947, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 4, 12, 955, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 4, 12, 955, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 4, 12, 955, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 19, 18, 4, 12, 949, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 20, 18, 4, 12, 949, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 18, 4, 12, 949, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 27, 18, 4, 12, 954, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 8, 18, 4, 12, 954, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 19, 18, 4, 12, 954, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 4, 12, 948, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 4, 12, 948, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 4, 12, 948, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 18, 4, 12, 948, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 29, 18, 4, 12, 948, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 30, 18, 4, 12, 948, DateTimeKind.Local).AddTicks(2305));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 17, 49, 3, 808, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 20, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 21, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 49, 3, 811, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 17, 49, 3, 820, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 17, 49, 3, 820, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 17, 49, 3, 820, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 19, 17, 49, 3, 814, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 20, 17, 49, 3, 814, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 17, 49, 3, 814, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 27, 17, 49, 3, 819, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 8, 17, 49, 3, 819, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 19, 17, 49, 3, 819, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.InsertData(
                table: "Piercers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "RegistrationDate", "Studio", "UserId" },
                values: new object[,]
                {
                    { 3, null, 0, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 2, null, 0, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 17, 49, 3, 812, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 17, 49, 3, 812, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 17, 49, 3, 812, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 17, 49, 3, 812, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 29, 17, 49, 3, 812, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 30, 17, 49, 3, 812, DateTimeKind.Local).AddTicks(1533));
        }
    }
}

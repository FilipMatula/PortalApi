using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class Designsv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 19, 48, 56, 385, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 4, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 5, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 48, 56, 388, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.InsertData(
                table: "AvailableDesignPhotos",
                columns: new[] { "Id", "City", "Color", "Date", "Gender", "ImgSrc", "PersonId", "Style", "Technique" },
                values: new object[,]
                {
                    { 1, "Warszawa", 1, new DateTime(2020, 6, 1, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(7346), 1, "sciezka Available Design 1", 1, 1, 2 },
                    { 3, "Krakow", 1, new DateTime(2020, 6, 3, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(8280), 2, "sciezka Available Design 3", 3, 3, 2 },
                    { 2, "Poznan", 1, new DateTime(2020, 6, 2, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(8255), 2, "sciezka Available Design 2", 2, 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 4, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 22, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 3, 19, 48, 56, 390, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 19, 48, 56, 389, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 19, 48, 56, 389, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 19, 48, 56, 389, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 12, 19, 48, 56, 389, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 13, 19, 48, 56, 389, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 14, 19, 48, 56, 389, DateTimeKind.Local).AddTicks(3377));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvailableDesignPhotos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvailableDesignPhotos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvailableDesignPhotos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 19, 43, 33, 296, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 4, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 5, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 4, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 22, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 3, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 2, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 3, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 12, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 13, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 14, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(9331));
        }
    }
}

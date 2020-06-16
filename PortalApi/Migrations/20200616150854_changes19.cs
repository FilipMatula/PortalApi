using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImgSrc",
                table: "AvailableDesigns",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 17, 8, 53, 991, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 20, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 21, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 16, 17, 8, 53, 993, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 17, 8, 54, 1, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 17, 8, 54, 1, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 17, 8, 54, 1, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 19, 17, 8, 53, 995, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 20, 17, 8, 53, 995, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 17, 8, 53, 995, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 27, 17, 8, 54, 0, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 8, 17, 8, 54, 0, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 19, 17, 8, 54, 0, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 17, 8, 53, 994, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 17, 8, 53, 994, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 17, 8, 53, 994, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 17, 8, 53, 994, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 29, 17, 8, 53, 994, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 30, 17, 8, 53, 994, DateTimeKind.Local).AddTicks(3190));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImgSrc",
                table: "AvailableDesigns",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 41, 40, 345, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 41, 40, 347, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 41, 40, 355, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 41, 40, 355, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 41, 40, 355, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 19, 16, 41, 40, 349, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 20, 16, 41, 40, 349, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 16, 41, 40, 349, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 27, 16, 41, 40, 355, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 8, 16, 41, 40, 355, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 19, 16, 41, 40, 355, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 41, 40, 348, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 41, 40, 348, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 41, 40, 348, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 16, 41, 40, 348, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 29, 16, 41, 40, 348, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 30, 16, 41, 40, 348, DateTimeKind.Local).AddTicks(3454));
        }
    }
}

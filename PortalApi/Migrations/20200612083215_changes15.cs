using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Breast",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hip",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Waist",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 32, 14, 420, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 16, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 17, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 32, 14, 431, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 10, 32, 14, 431, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 10, 32, 14, 431, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Breast", "Height", "Hip", "Waist", "Weight" },
                values: new object[] { 60, 160, 70, 45, 53 });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Breast", "Height", "Hip", "Waist", "Weight" },
                values: new object[] { 80, 180, 90, 65, 73 });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Breast", "Height", "Hip", "Waist", "Weight" },
                values: new object[] { 70, 170, 60, 55, 63 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 15, 10, 32, 14, 425, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 16, 10, 32, 14, 425, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 16, 10, 32, 14, 425, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 23, 10, 32, 14, 430, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 10, 32, 14, 430, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 15, 10, 32, 14, 430, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 32, 14, 424, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 10, 32, 14, 424, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 10, 32, 14, 424, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 24, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 25, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 26, 10, 32, 14, 423, DateTimeKind.Local).AddTicks(9576));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breast",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Hip",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Waist",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Models");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 17, 13, 451, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 16, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 17, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 17, 13, 454, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 17, 13, 462, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 10, 17, 13, 462, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 10, 17, 13, 462, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 15, 10, 17, 13, 456, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 16, 10, 17, 13, 456, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 16, 10, 17, 13, 456, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 23, 10, 17, 13, 461, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 10, 17, 13, 461, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 15, 10, 17, 13, 461, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 17, 13, 455, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 10, 17, 13, 455, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 10, 17, 13, 455, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 24, 10, 17, 13, 455, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 25, 10, 17, 13, 455, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 26, 10, 17, 13, 455, DateTimeKind.Local).AddTicks(1260));
        }
    }
}

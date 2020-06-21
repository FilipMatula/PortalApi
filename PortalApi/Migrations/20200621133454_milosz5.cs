using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class milosz5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Technique",
                table: "Tattooers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 25, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 26, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 21, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 21, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 21, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 21, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 21, 15, 34, 54, 5, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 15, 34, 54, 11, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 15, 34, 54, 11, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 15, 34, 54, 11, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 24, 15, 34, 54, 7, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 25, 15, 34, 54, 7, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 25, 15, 34, 54, 7, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 2, 15, 34, 54, 11, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 13, 15, 34, 54, 11, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 24, 15, 34, 54, 11, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 15, 34, 54, 6, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 15, 34, 54, 6, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 15, 34, 54, 6, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Technique",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Technique",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 15, 34, 54, 6, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 15, 34, 54, 6, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 5, 15, 34, 54, 6, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 16, 34, 54, 0, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 34, 54, 3, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 18, 34, 54, 3, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 20, 34, 54, 3, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 19, 34, 54, 3, DateTimeKind.Local).AddTicks(9299));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Technique",
                table: "Tattooers");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 14, 1, 59, 648, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 25, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 26, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 21, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 21, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 21, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 21, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 21, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 14, 1, 59, 654, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 14, 1, 59, 655, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 14, 1, 59, 655, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 24, 14, 1, 59, 650, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 25, 14, 1, 59, 650, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 25, 14, 1, 59, 650, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 2, 14, 1, 59, 654, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 13, 14, 1, 59, 654, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 24, 14, 1, 59, 654, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 22, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 23, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 24, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 3, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 5, 14, 1, 59, 649, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 15, 1, 59, 644, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 16, 1, 59, 647, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 1, 59, 647, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 19, 1, 59, 647, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 18, 1, 59, 647, DateTimeKind.Local).AddTicks(2147));
        }
    }
}

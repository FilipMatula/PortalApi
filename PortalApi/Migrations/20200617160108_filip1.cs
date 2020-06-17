using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class filip1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ArticleSubCategories",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ArticleCategories",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticleType",
                table: "ArticleCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArticleType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArticleType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArticleType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArticleType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 1, 7, 888, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 1, 7, 888, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 1, 7, 888, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 18, 1, 7, 881, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 18, 1, 7, 881, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 21, 18, 1, 7, 881, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 18, 1, 7, 887, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 9, 18, 1, 7, 887, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 18, 1, 7, 887, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 1, 7, 879, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 1, 7, 879, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 1, 7, 879, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 29, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 1, 18, 1, 7, 878, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 4, 1, 7, 874, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 6, 1, 7, 876, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 17, 20, 1, 7, 876, DateTimeKind.Local).AddTicks(3479));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleType",
                table: "ArticleCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ArticleSubCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ArticleCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

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
    }
}

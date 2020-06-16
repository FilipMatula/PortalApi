using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Style",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "Styles",
                table: "Tattooers");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "AvailableDesigns");

            migrationBuilder.AddColumn<int>(
                name: "TattooStyle",
                table: "Tattoos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TattooStyle",
                table: "Tattooers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ImgSrc",
                table: "PhotographersPhotos",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelingStyle",
                table: "PhotographersPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelingStyle",
                table: "ModelsPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TattooStyle",
                table: "AvailableDesigns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 29, 51, 601, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 16, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "TattooStyle" },
                values: new object[] { new DateTime(2020, 6, 17, 16, 29, 51, 611, DateTimeKind.Local).AddTicks(8946), 1 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "TattooStyle" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 29, 51, 612, DateTimeKind.Local).AddTicks(420), 2 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "TattooStyle" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 29, 51, 612, DateTimeKind.Local).AddTicks(456), 3 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ModelingStyle" },
                values: new object[] { new DateTime(2020, 7, 19, 16, 29, 51, 606, DateTimeKind.Local).AddTicks(1965), 4 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ModelingStyle" },
                values: new object[] { new DateTime(2020, 7, 20, 16, 29, 51, 606, DateTimeKind.Local).AddTicks(2507), 5 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ModelingStyle" },
                values: new object[] { new DateTime(2020, 7, 20, 16, 29, 51, 606, DateTimeKind.Local).AddTicks(2531), 1 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ModelingStyle" },
                values: new object[] { new DateTime(2020, 6, 27, 16, 29, 51, 611, DateTimeKind.Local).AddTicks(1922), 4 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ModelingStyle" },
                values: new object[] { new DateTime(2020, 7, 8, 16, 29, 51, 611, DateTimeKind.Local).AddTicks(2517), 5 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ModelingStyle" },
                values: new object[] { new DateTime(2020, 7, 19, 16, 29, 51, 611, DateTimeKind.Local).AddTicks(2541), 1 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 16, 29, 51, 605, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 16, 29, 51, 605, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 29, 51, 605, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "TattooStyle" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(7109), 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "TattooStyle" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(8249), 2 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "TattooStyle" },
                values: new object[] { new DateTime(2020, 6, 30, 16, 29, 51, 604, DateTimeKind.Local).AddTicks(8280), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TattooStyle",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "TattooStyle",
                table: "Tattooers");

            migrationBuilder.DropColumn(
                name: "ModelingStyle",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "ModelingStyle",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "TattooStyle",
                table: "AvailableDesigns");

            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "Tattoos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Styles",
                table: "Tattooers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ImgSrc",
                table: "PhotographersPhotos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "PhotographersPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "ModelsPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "AvailableDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 15, 18, 13, 17, 13, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 16, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 14, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 14, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 14, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 14, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 14, 18, 13, 17, 16, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 15, 18, 13, 17, 25, DateTimeKind.Local).AddTicks(1423), 1 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 16, 18, 13, 17, 25, DateTimeKind.Local).AddTicks(2856), 2 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 17, 18, 13, 17, 25, DateTimeKind.Local).AddTicks(2893), 3 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 7, 17, 18, 13, 17, 18, DateTimeKind.Local).AddTicks(9837), 4 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 7, 18, 18, 13, 17, 19, DateTimeKind.Local).AddTicks(488), 5 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 7, 18, 18, 13, 17, 19, DateTimeKind.Local).AddTicks(514), 1 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 13, 17, 24, DateTimeKind.Local).AddTicks(6026), 4 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 7, 6, 18, 13, 17, 24, DateTimeKind.Local).AddTicks(6951), 5 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 7, 17, 18, 13, 17, 24, DateTimeKind.Local).AddTicks(6982), 1 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 15, 18, 13, 17, 17, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 16, 18, 13, 17, 17, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 13, 17, 17, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 26, 18, 13, 17, 17, DateTimeKind.Local).AddTicks(1745), 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 27, 18, 13, 17, 17, DateTimeKind.Local).AddTicks(3185), 2 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Style" },
                values: new object[] { new DateTime(2020, 6, 28, 18, 13, 17, 17, DateTimeKind.Local).AddTicks(3224), 3 });
        }
    }
}

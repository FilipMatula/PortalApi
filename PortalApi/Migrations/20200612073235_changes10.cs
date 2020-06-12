using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tattoo",
                table: "ModelsPhotos",
                newName: "BodyDecorations_Tattoo");

            migrationBuilder.RenameColumn(
                name: "Puncture",
                table: "ModelsPhotos",
                newName: "BodyDecorations_Puncture");

            migrationBuilder.AlterColumn<bool>(
                name: "BodyDecorations_Tattoo",
                table: "ModelsPhotos",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "BodyDecorations_Puncture",
                table: "ModelsPhotos",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 32, 34, 940, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 16, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 17, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 32, 34, 945, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 32, 34, 945, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 32, 34, 945, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 15, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 16, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 16, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 23, 9, 32, 34, 945, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 9, 32, 34, 945, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 15, 9, 32, 34, 945, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 24, 9, 32, 34, 943, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 25, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 26, 9, 32, 34, 944, DateTimeKind.Local).AddTicks(312));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BodyDecorations_Tattoo",
                table: "ModelsPhotos",
                newName: "Tattoo");

            migrationBuilder.RenameColumn(
                name: "BodyDecorations_Puncture",
                table: "ModelsPhotos",
                newName: "Puncture");

            migrationBuilder.AlterColumn<bool>(
                name: "Tattoo",
                table: "ModelsPhotos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Puncture",
                table: "ModelsPhotos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 10, 17, 21, 13, 318, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 11, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 12, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 13, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 14, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 10, 17, 21, 13, 323, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 11, 17, 21, 13, 323, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 12, 17, 21, 13, 323, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Puncture" },
                values: new object[] { new DateTime(2020, 7, 12, 17, 21, 13, 322, DateTimeKind.Local).AddTicks(2129), true });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Puncture", "Tattoo" },
                values: new object[] { new DateTime(2020, 7, 13, 17, 21, 13, 322, DateTimeKind.Local).AddTicks(2993), true, true });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 13, 17, 21, 13, 322, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 20, 17, 21, 13, 322, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 1, 17, 21, 13, 322, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 17, 21, 13, 322, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 10, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 11, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 12, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 21, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 22, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 23, 17, 21, 13, 321, DateTimeKind.Local).AddTicks(4568));
        }
    }
}

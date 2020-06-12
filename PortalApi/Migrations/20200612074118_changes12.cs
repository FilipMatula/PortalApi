using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 41, 17, 982, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 16, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 17, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 41, 17, 993, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 41, 17, 993, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 41, 17, 993, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "BodyDecorations_Puncture", "BodyDecorations_Tattoo" },
                values: new object[] { new DateTime(2020, 7, 15, 9, 41, 17, 987, DateTimeKind.Local).AddTicks(3037), false, false });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "BodyDecorations_Tattoo" },
                values: new object[] { new DateTime(2020, 7, 16, 9, 41, 17, 987, DateTimeKind.Local).AddTicks(3656), true });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 16, 9, 41, 17, 987, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 23, 9, 41, 17, 992, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 9, 41, 17, 992, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 15, 9, 41, 17, 992, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 41, 17, 986, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 41, 17, 986, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 24, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 25, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 26, 9, 41, 17, 985, DateTimeKind.Local).AddTicks(6517));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 37, 29, 275, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 16, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 17, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 12, 9, 37, 29, 278, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 37, 29, 287, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 37, 29, 288, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 37, 29, 288, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "BodyDecorations_Puncture", "BodyDecorations_Tattoo" },
                values: new object[] { new DateTime(2020, 7, 15, 9, 37, 29, 281, DateTimeKind.Local).AddTicks(2816), true, true });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "BodyDecorations_Tattoo" },
                values: new object[] { new DateTime(2020, 7, 16, 9, 37, 29, 281, DateTimeKind.Local).AddTicks(3437), false });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 16, 9, 37, 29, 281, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 23, 9, 37, 29, 287, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 4, 9, 37, 29, 287, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 15, 9, 37, 29, 287, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 13, 9, 37, 29, 279, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 14, 9, 37, 29, 279, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 15, 9, 37, 29, 279, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 24, 9, 37, 29, 279, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 25, 9, 37, 29, 279, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 26, 9, 37, 29, 279, DateTimeKind.Local).AddTicks(4658));
        }
    }
}

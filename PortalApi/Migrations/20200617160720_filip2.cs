using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class filip2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 17, 18, 7, 19, 481, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 7, 19, 490, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 7, 19, 490, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 7, 19, 490, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 18, 7, 19, 484, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 18, 7, 19, 484, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 21, 18, 7, 19, 484, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 18, 7, 19, 489, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 9, 18, 7, 19, 489, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 18, 7, 19, 489, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 7, 19, 482, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 7, 19, 482, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 7, 19, 482, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 29, 18, 7, 19, 482, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 18, 7, 19, 482, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 1, 18, 7, 19, 482, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 4, 7, 19, 477, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 6, 7, 19, 479, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 17, 20, 7, 19, 479, DateTimeKind.Local).AddTicks(9082));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Tattooers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Studio", "TattooStyle", "UserId" },
                values: new object[,]
                {
                    { 3, null, 0, null, null, null, null, 0, 3 },
                    { 2, null, 0, null, null, null, null, 0, 2 }
                });

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
    }
}

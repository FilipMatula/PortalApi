using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class milosz4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "FirstName", "Gender", "ImgSrc", "LastName", "PasswordHash", "PasswordSalt", "RegistrationDate", "Username" },
                values: new object[,]
                {
                    { 5, 17, "Gliwice", "SławoKO", 1, "ProfilePhoto5", "sławko Sławko sławko", null, null, new DateTime(2020, 6, 21, 18, 1, 59, 647, DateTimeKind.Local).AddTicks(2147), "SławKOR" },
                    { 4, 14, "Poznan", "Marko", 1, "ProfilePhoto4", "Marko Marko Marko", null, null, new DateTime(2020, 6, 21, 19, 1, 59, 647, DateTimeKind.Local).AddTicks(2142), "MarKO" }
                });

            migrationBuilder.UpdateData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Studio", "TattooStyle", "UserId" },
                values: new object[] { "Marko - sekacja o mnie", 1, "FACEBOOOK LINK 4", "LINK INST 4", "LINK TWITTER 4", "STUDIO Poznan GO", 1, 4 });

            migrationBuilder.InsertData(
                table: "Tattooers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Studio", "TattooStyle", "UserId" },
                values: new object[] { 2, "SławKO- sekacja o mnie", 3, "FACEBOOOK LINK 5", "LINK INST 5", "LINK TWITTER 5", "STUDIO = GLIWICE MAIN = STUDIO", 3, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 20, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 21, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 22, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 23, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 35, 3, 196, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 20, 35, 3, 202, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 20, 20, 35, 3, 202, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 21, 20, 35, 3, 202, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 21, 20, 35, 3, 198, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 22, 20, 35, 3, 198, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 22, 20, 35, 3, 198, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 29, 20, 35, 3, 202, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 10, 20, 35, 3, 202, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 21, 20, 35, 3, 202, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 20, 35, 3, 197, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 20, 20, 35, 3, 197, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 21, 20, 35, 3, 197, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.InsertData(
                table: "Tattooers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Studio", "TattooStyle", "UserId" },
                values: new object[] { 1, null, 0, null, null, null, null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 30, 20, 35, 3, 197, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 1, 20, 35, 3, 197, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 2, 20, 35, 3, 197, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 6, 35, 3, 192, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 8, 35, 3, 195, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 18, 22, 35, 3, 195, DateTimeKind.Local).AddTicks(2235));
        }
    }
}

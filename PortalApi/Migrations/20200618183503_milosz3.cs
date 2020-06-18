using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class milosz3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BodyDecorations_Puncture",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "BodyDecorations_Tattoo",
                table: "Models",
                nullable: true);

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
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { "cos tam robie cos tam nie robie - sekacja o mnie", "", "LINK INST 1", "LINK TWITTER" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { "about about about about abour tasd", "", "LINK INST 2", "LINK TWITTER 2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { "kolejnny kolejny kolejny model model model about 3", "", "LINK INST 3", "LINK TWITTER 3" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyDecorations_Puncture",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "BodyDecorations_Tattoo",
                table: "Models");

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
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "MediaFB", "MediaInstagram", "MediaTwitter" },
                values: new object[] { null, null, null, null });

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
    }
}

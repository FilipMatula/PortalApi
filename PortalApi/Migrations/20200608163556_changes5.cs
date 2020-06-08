using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photographers_People_PersonId",
                table: "Photographers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotographersPhotos_People_PersonId",
                table: "PhotographersPhotos");

            migrationBuilder.DropIndex(
                name: "IX_PhotographersPhotos_PersonId",
                table: "PhotographersPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Photographers_PersonId",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Photographers");

            migrationBuilder.AddColumn<int>(
                name: "PhotographerId",
                table: "PhotographersPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "PhotographersPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "Photographers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Photographers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 35, 55, 286, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 12, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 13, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 35, 55, 291, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 35, 55, 291, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 35, 55, 291, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 12, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.InsertData(
                table: "Photographers",
                columns: new[] { "Id", "About", "City", "Experience", "Gender", "ImgSrc", "MediaFB", "MediaInstagram", "MediaTwitter", "RegistrationDate", "UserId" },
                values: new object[,]
                {
                    { 3, null, "Rzeszow", 2, 2, "ProfilePhoto2", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, null, "Warszawa", 1, 1, "ProfilePhoto2", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 1, null, "Krakow", 3, 2, "ProfilePhoto1", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 35, 55, 289, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "PhotographerId", "Style" },
                values: new object[] { new DateTime(2020, 6, 19, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(9937), 1, 4 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "PhotographerId", "Style" },
                values: new object[] { new DateTime(2020, 6, 30, 18, 35, 55, 291, DateTimeKind.Local).AddTicks(502), 2, 5 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "PhotographerId", "Style" },
                values: new object[] { new DateTime(2020, 7, 11, 18, 35, 55, 291, DateTimeKind.Local).AddTicks(524), 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_PhotographersPhotos_PhotographerId",
                table: "PhotographersPhotos",
                column: "PhotographerId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photographers_Users_UserId",
                table: "Photographers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotographersPhotos_Photographers_PhotographerId",
                table: "PhotographersPhotos",
                column: "PhotographerId",
                principalTable: "Photographers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photographers_Users_UserId",
                table: "Photographers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotographersPhotos_Photographers_PhotographerId",
                table: "PhotographersPhotos");

            migrationBuilder.DropIndex(
                name: "IX_PhotographersPhotos_PhotographerId",
                table: "PhotographersPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers");

            migrationBuilder.DeleteData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PhotographerId",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Photographers");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PhotographersPhotos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "PhotographersPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "PhotographersPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "PhotographersPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Photographers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 6, 4, 900, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 12, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 13, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 6, 4, 905, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 6, 4, 905, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 6, 4, 905, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 12, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Date", "Experience", "Gender", "PersonId" },
                values: new object[] { "Krakow", new DateTime(2020, 6, 19, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(8838), 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Date", "Experience", "Gender", "PersonId" },
                values: new object[] { "Warszawa", new DateTime(2020, 6, 30, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(9619), 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Date", "Experience", "Gender", "PersonId" },
                values: new object[] { "Poznan", new DateTime(2020, 7, 11, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(9641), 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 6, 4, 903, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.CreateIndex(
                name: "IX_PhotographersPhotos_PersonId",
                table: "PhotographersPhotos",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_PersonId",
                table: "Photographers",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photographers_People_PersonId",
                table: "Photographers",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotographersPhotos_People_PersonId",
                table: "PhotographersPhotos",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

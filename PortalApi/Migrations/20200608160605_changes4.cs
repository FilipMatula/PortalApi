using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableDesigns_People_PersonId",
                table: "AvailableDesigns");

            migrationBuilder.DropIndex(
                name: "IX_AvailableDesigns_PersonId",
                table: "AvailableDesigns");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AvailableDesigns");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AvailableDesigns");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "AvailableDesigns");

            migrationBuilder.AddColumn<int>(
                name: "TattooerId",
                table: "AvailableDesigns",
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
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 9, 18, 6, 4, 905, DateTimeKind.Local).AddTicks(3779), 1 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 10, 18, 6, 4, 905, DateTimeKind.Local).AddTicks(4893), 2 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 11, 18, 6, 4, 905, DateTimeKind.Local).AddTicks(4926), 3 });

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
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 6, 4, 904, DateTimeKind.Local).AddTicks(9641));

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
                name: "IX_AvailableDesigns_TattooerId",
                table: "AvailableDesigns",
                column: "TattooerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableDesigns_Tattooers_TattooerId",
                table: "AvailableDesigns",
                column: "TattooerId",
                principalTable: "Tattooers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableDesigns_Tattooers_TattooerId",
                table: "AvailableDesigns");

            migrationBuilder.DropIndex(
                name: "IX_AvailableDesigns_TattooerId",
                table: "AvailableDesigns");

            migrationBuilder.DropColumn(
                name: "TattooerId",
                table: "AvailableDesigns");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AvailableDesigns",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "AvailableDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "AvailableDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 1, 29, 763, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 12, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 13, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Warszawa", new DateTime(2020, 6, 9, 18, 1, 29, 768, DateTimeKind.Local).AddTicks(6935), 1, 1 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Poznan", new DateTime(2020, 6, 10, 18, 1, 29, 768, DateTimeKind.Local).AddTicks(8199), 2, 2 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Krakow", new DateTime(2020, 6, 11, 18, 1, 29, 768, DateTimeKind.Local).AddTicks(8231), 2, 3 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 1, 29, 767, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 12, 18, 1, 29, 767, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 18, 1, 29, 767, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 1, 29, 767, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 18, 1, 29, 767, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 1, 29, 767, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 22, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.CreateIndex(
                name: "IX_AvailableDesigns_PersonId",
                table: "AvailableDesigns",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableDesigns_People_PersonId",
                table: "AvailableDesigns",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tattooers_People_PersonId",
                table: "Tattooers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattoos_People_PersonId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattoos_PersonId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattooers_PersonId",
                table: "Tattooers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Tattooers");

            migrationBuilder.AddColumn<int>(
                name: "TattooerId",
                table: "Tattoos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tattooers",
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
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 1, 29, 768, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 1, 29, 768, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 1, 29, 768, DateTimeKind.Local).AddTicks(8231));

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
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgSrc",
                value: "ProfilePhoto1");

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgSrc",
                value: "ProfilePhoto2");

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgSrc",
                value: "ProfilePhoto2");

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

            migrationBuilder.InsertData(
                table: "Tattooers",
                columns: new[] { "Id", "About", "City", "Experience", "Gender", "ImgSrc", "MediaFB", "MediaInstagram", "MediaTwitter", "RegistrationDate", "Studio", "Styles", "UserId" },
                values: new object[,]
                {
                    { 3, null, "Rzeszow", 0, 2, "ProfilePhoto2", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 3 },
                    { 2, null, "Warszawa", 0, 1, "ProfilePhoto2", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 2 },
                    { 1, null, "Krakow", 0, 2, "ProfilePhoto1", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 20, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(4628), 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 21, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(5740), 2 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 22, 18, 1, 29, 766, DateTimeKind.Local).AddTicks(5770), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Tattoos_TattooerId",
                table: "Tattoos",
                column: "TattooerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tattooers_Users_UserId",
                table: "Tattooers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattoos_Tattooers_TattooerId",
                table: "Tattoos",
                column: "TattooerId",
                principalTable: "Tattooers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tattooers_Users_UserId",
                table: "Tattooers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattoos_Tattooers_TattooerId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattoos_TattooerId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooers");

            migrationBuilder.DeleteData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "TattooerId",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tattooers");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Tattoos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Tattoos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Tattoos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Tattooers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 37, 4, 461, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 12, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 13, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 8, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 8, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 8, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 8, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 37, 4, 466, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 17, 37, 4, 466, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 17, 37, 4, 466, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 11, 17, 37, 4, 465, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 12, 17, 37, 4, 465, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 17, 37, 4, 465, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 17, 37, 4, 465, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 17, 37, 4, 466, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 17, 37, 4, 466, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgSrc",
                value: null);

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgSrc",
                value: null);

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgSrc",
                value: null);

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 17, 37, 4, 465, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 17, 37, 4, 465, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 17, 37, 4, 465, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Rzeszow", new DateTime(2020, 6, 20, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(7081), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Warszawa", new DateTime(2020, 6, 21, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(8156), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Krakow", new DateTime(2020, 6, 22, 17, 37, 4, 464, DateTimeKind.Local).AddTicks(8200), 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Tattoos_PersonId",
                table: "Tattoos",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tattooers_PersonId",
                table: "Tattooers",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tattooers_People_PersonId",
                table: "Tattooers",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattoos_People_PersonId",
                table: "Tattoos",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

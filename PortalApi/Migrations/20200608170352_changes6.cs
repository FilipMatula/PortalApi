using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_People_PersonId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelsPhotos_People_PersonId",
                table: "ModelsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_ModelsPhotos_PersonId",
                table: "ModelsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Models_PersonId",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "City",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Models");

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "ModelsPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "ModelsPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 19, 3, 51, 565, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 12, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 13, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 19, 3, 51, 572, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 19, 3, 51, 573, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 3, 51, 573, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "About", "City", "Gender", "ImgSrc", "MediaFB", "MediaInstagram", "MediaTwitter", "RegistrationDate", "UserId" },
                values: new object[,]
                {
                    { 3, null, "Rzeszow", 2, "ProfilePhoto2", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, null, "Warszawa", 1, "ProfilePhoto2", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 1, null, "Krakow", 2, "ProfilePhoto1", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 19, 3, 51, 572, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 19, 3, 51, 572, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 19, 3, 51, 572, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 20, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 21, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 22, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ModelId", "Style" },
                values: new object[] { new DateTime(2020, 7, 11, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(6957), 1, 4 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ModelId", "Style" },
                values: new object[] { new DateTime(2020, 7, 12, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(8102), 2, 5 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ModelId", "Style" },
                values: new object[] { new DateTime(2020, 7, 12, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(8132), 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ModelsPhotos_ModelId",
                table: "ModelsPhotos",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_UserId",
                table: "Models",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Users_UserId",
                table: "Models",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelsPhotos_Models_ModelId",
                table: "ModelsPhotos",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Users_UserId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelsPhotos_Models_ModelId",
                table: "ModelsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_ModelsPhotos_ModelId",
                table: "ModelsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Models_UserId",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Models");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ModelsPhotos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "ModelsPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "ModelsPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Models",
                type: "int",
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
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Krakow", new DateTime(2020, 7, 11, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(4866), 2, 1 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Warszawa", new DateTime(2020, 7, 12, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(5667), 1, 2 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Date", "Gender", "PersonId" },
                values: new object[] { "Poznan", new DateTime(2020, 7, 12, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(5689), 2, 3 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 35, 55, 290, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 18, 35, 55, 291, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 35, 55, 291, DateTimeKind.Local).AddTicks(524));

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

            migrationBuilder.CreateIndex(
                name: "IX_ModelsPhotos_PersonId",
                table: "ModelsPhotos",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_PersonId",
                table: "Models",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_People_PersonId",
                table: "Models",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelsPhotos_People_PersonId",
                table: "ModelsPhotos",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

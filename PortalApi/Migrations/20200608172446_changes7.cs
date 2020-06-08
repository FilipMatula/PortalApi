using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_People_PersonId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "IX_Articles_PersonId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 9, 19, 24, 45, 720, DateTimeKind.Local).AddTicks(3130), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 10, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5642), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 11, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5779), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5786), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5791), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5795), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5800), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5803), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5807), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5811), 2 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 19, 24, 45, 727, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 19, 24, 45, 727, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 24, 45, 727, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 11, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 12, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 20, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 21, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 22, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

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

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 11, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 12, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 19, 3, 51, 571, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 3 },
                    { 2, 2 }
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
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 9, 19, 3, 51, 565, DateTimeKind.Local).AddTicks(4668), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 10, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1353), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 11, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1433), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 12, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1441), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1446), 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1450), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1454), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1458), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1462), 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 3, 51, 570, DateTimeKind.Local).AddTicks(1466), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_PersonId",
                table: "Articles",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_People_PersonId",
                table: "Articles",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

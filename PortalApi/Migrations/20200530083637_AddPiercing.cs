using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class AddPiercing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piercings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Pierce = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piercings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piercings_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 31, 10, 36, 37, 134, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 2, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 3, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 4, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.InsertData(
                table: "Piercings",
                columns: new[] { "Id", "City", "Date", "Gender", "ImgSrc", "PersonId", "Pierce" },
                values: new object[,]
                {
                    { 1, "Krakow", new DateTime(2020, 5, 31, 10, 36, 37, 138, DateTimeKind.Local).AddTicks(1512), "Kobieta", "sciezka PIERCING 1", 1, "kolczyk" },
                    { 2, "Wroclaw", new DateTime(2020, 6, 1, 10, 36, 37, 138, DateTimeKind.Local).AddTicks(1998), "Mezczyzna", "sciezka PIERCING 2", 1, "kolczyk2" },
                    { 3, "Poznan", new DateTime(2020, 6, 2, 10, 36, 37, 138, DateTimeKind.Local).AddTicks(2029), "Mezczyzna", "sciezka PIERCING 3", 2, "Tunel" }
                });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 11, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 12, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 13, 10, 36, 37, 137, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.CreateIndex(
                name: "IX_Piercings_PersonId",
                table: "Piercings",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piercings");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 30, 16, 36, 25, 452, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 5, 31, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 1, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 2, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 3, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 29, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 10, 16, 36, 25, 455, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 11, 16, 36, 25, 456, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 12, 16, 36, 25, 456, DateTimeKind.Local).AddTicks(975));
        }
    }
}

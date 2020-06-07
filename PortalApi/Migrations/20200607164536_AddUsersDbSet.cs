using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class AddUsersDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 150, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photographers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 150, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photographers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piercers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 150, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Studio = table.Column<string>(maxLength: 50, nullable: true),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true),
                    Punctures = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piercers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piercers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tattooers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 150, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Studio = table.Column<string>(maxLength: 50, nullable: true),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true),
                    Styles = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tattooers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tattooers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Username = table.Column<string>(maxLength: 80, nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 45, 35, 662, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 11, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 12, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 7, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 7, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 7, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 7, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 7, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 45, 35, 667, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 45, 35, 667, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 45, 35, 667, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 10, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 18, 18, 45, 35, 667, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 29, 18, 45, 35, 667, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 10, 18, 45, 35, 667, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 8, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 9, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 10, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 20, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 21, 18, 45, 35, 665, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.CreateIndex(
                name: "IX_Models_PersonId",
                table: "Models",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_PersonId",
                table: "Photographers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercers_PersonId",
                table: "Piercers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tattooers_PersonId",
                table: "Tattooers",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Photographers");

            migrationBuilder.DropTable(
                name: "Piercers");

            migrationBuilder.DropTable(
                name: "Tattooers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 4, 21, 18, 13, 222, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 5, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 6, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 7, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 8, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 3, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 3, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 3, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 3, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 3, 21, 18, 13, 226, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 4, 21, 18, 13, 229, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 5, 21, 18, 13, 230, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 6, 21, 18, 13, 230, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 6, 21, 18, 13, 228, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 7, 21, 18, 13, 228, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 7, 21, 18, 13, 228, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 14, 21, 18, 13, 229, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 25, 21, 18, 13, 229, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 6, 21, 18, 13, 229, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 4, 21, 18, 13, 228, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 5, 21, 18, 13, 228, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 6, 21, 18, 13, 228, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 15, 21, 18, 13, 227, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 16, 21, 18, 13, 227, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 17, 21, 18, 13, 227, DateTimeKind.Local).AddTicks(5797));
        }
    }
}

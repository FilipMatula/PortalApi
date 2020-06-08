using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Piercers_People_PersonId",
                table: "Piercers");

            migrationBuilder.DropForeignKey(
                name: "FK_Piercings_People_PersonId",
                table: "Piercings");

            migrationBuilder.DropIndex(
                name: "IX_Piercings_PersonId",
                table: "Piercings");

            migrationBuilder.DropIndex(
                name: "IX_Piercers_PersonId",
                table: "Piercers");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Piercings");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Piercers");

            migrationBuilder.AddColumn<int>(
                name: "PiercerId",
                table: "Piercings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Piercers",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Piercers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 16, 0, 38, 621, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 12, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 13, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 8, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 8, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 8, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 8, 16, 0, 38, 624, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 16, 0, 38, 627, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 16, 0, 38, 627, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 16, 0, 38, 627, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 11, 16, 0, 38, 626, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 12, 16, 0, 38, 626, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 12, 16, 0, 38, 626, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 19, 16, 0, 38, 626, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 30, 16, 0, 38, 626, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 11, 16, 0, 38, 626, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 20, 16, 0, 38, 625, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 21, 16, 0, 38, 625, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 22, 16, 0, 38, 625, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[,]
                {
                    { 3, null, null, null, null, null },
                    { 2, null, null, null, null, null },
                    { 1, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Piercers",
                columns: new[] { "Id", "About", "City", "Experience", "Gender", "ImgSrc", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "RegistrationDate", "Studio", "UserId" },
                values: new object[] { 1, null, "Krakow", 0, 2, null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.InsertData(
                table: "Piercers",
                columns: new[] { "Id", "About", "City", "Experience", "Gender", "ImgSrc", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "RegistrationDate", "Studio", "UserId" },
                values: new object[] { 2, null, "Warszawa", 0, 1, null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.InsertData(
                table: "Piercers",
                columns: new[] { "Id", "About", "City", "Experience", "Gender", "ImgSrc", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "RegistrationDate", "Studio", "UserId" },
                values: new object[] { 3, null, "Rzeszow", 0, 2, null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "PiercerId" },
                values: new object[] { new DateTime(2020, 6, 9, 16, 0, 38, 625, DateTimeKind.Local).AddTicks(5590), 1 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "PiercerId" },
                values: new object[] { new DateTime(2020, 6, 10, 16, 0, 38, 625, DateTimeKind.Local).AddTicks(6205), 2 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "PiercerId" },
                values: new object[] { new DateTime(2020, 6, 11, 16, 0, 38, 625, DateTimeKind.Local).AddTicks(6230), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Piercings_PiercerId",
                table: "Piercings",
                column: "PiercerId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercers_UserId",
                table: "Piercers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Piercers_Users_UserId",
                table: "Piercers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Piercings_Piercers_PiercerId",
                table: "Piercings",
                column: "PiercerId",
                principalTable: "Piercers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Piercers_Users_UserId",
                table: "Piercers");

            migrationBuilder.DropForeignKey(
                name: "FK_Piercings_Piercers_PiercerId",
                table: "Piercings");

            migrationBuilder.DropIndex(
                name: "IX_Piercings_PiercerId",
                table: "Piercings");

            migrationBuilder.DropIndex(
                name: "IX_Piercers_UserId",
                table: "Piercers");

            migrationBuilder.DeleteData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PiercerId",
                table: "Piercings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Piercers");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Piercings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Piercers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Piercers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(2779), 1 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 9, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(3292), 1 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "PersonId" },
                values: new object[] { new DateTime(2020, 6, 10, 18, 45, 35, 666, DateTimeKind.Local).AddTicks(3312), 2 });

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
                name: "IX_Piercings_PersonId",
                table: "Piercings",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercers_PersonId",
                table: "Piercers",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Piercers_People_PersonId",
                table: "Piercers",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Piercings_People_PersonId",
                table: "Piercings",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

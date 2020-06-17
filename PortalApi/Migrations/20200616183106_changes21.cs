using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Users_UserId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Photographer_Users_UserId",
                table: "Photographer");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattooer_Users_UserId",
                table: "Tattooer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tattooer",
                table: "Tattooer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photographer",
                table: "Photographer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.RenameTable(
                name: "Tattooer",
                newName: "Tattooers");

            migrationBuilder.RenameTable(
                name: "Photographer",
                newName: "Photographers");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Models");

            migrationBuilder.RenameIndex(
                name: "IX_Tattooer_UserId",
                table: "Tattooers",
                newName: "IX_Tattooers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Photographer_UserId",
                table: "Photographers",
                newName: "IX_Photographers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_UserId",
                table: "Models",
                newName: "IX_Models_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tattooers",
                table: "Tattooers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photographers",
                table: "Photographers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 20, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 21, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 20, 31, 6, 67, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 31, 6, 67, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 19, 20, 31, 6, 63, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 20, 20, 31, 6, 63, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 27, 20, 31, 6, 66, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 8, 20, 31, 6, 66, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "Experience", "Studio" },
                values: new object[] { "bardzo duzo pracy - wciaz znajduje czas na pierscienie :)", 2, "PiercerRZ" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 20, 31, 6, 62, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 31, 6, 62, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 29, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 16, 20, 31, 6, 57, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 16, 20, 31, 6, 60, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "FirstName", "Gender", "ImgSrc", "LastName", "PasswordHash", "PasswordSalt", "RegistrationDate", "Username" },
                values: new object[] { 3, 39, "Warszawa", null, 2, "ProfilePhoto3", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 20, 31, 6, 67, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 20, 20, 31, 6, 63, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 19, 20, 31, 6, 66, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.InsertData(
                table: "Piercers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "Studio", "UserId" },
                values: new object[] { 3, null, 0, null, null, null, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 20, 31, 6, 62, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 30, 20, 31, 6, 61, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Users_UserId",
                table: "Models",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photographers_Users_UserId",
                table: "Photographers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattooers_Users_UserId",
                table: "Tattooers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Users_UserId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Photographers_Users_UserId",
                table: "Photographers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattooers_Users_UserId",
                table: "Tattooers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tattooers",
                table: "Tattooers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photographers",
                table: "Photographers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Tattooers",
                newName: "Tattooer");

            migrationBuilder.RenameTable(
                name: "Photographers",
                newName: "Photographer");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Model");

            migrationBuilder.RenameIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooer",
                newName: "IX_Tattooer_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Photographers_UserId",
                table: "Photographer",
                newName: "IX_Photographer_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_UserId",
                table: "Model",
                newName: "IX_Model_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tattooer",
                table: "Tattooer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photographer",
                table: "Photographer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 20, 24, 17, 197, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 19, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 20, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 21, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 16, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 20, 24, 17, 206, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 24, 17, 206, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.InsertData(
                table: "AvailableDesigns",
                columns: new[] { "Id", "Color", "Date", "ImgSrc", "Price", "Reserved", "TattooStyle", "Technique", "UserId" },
                values: new object[] { 3, 1, new DateTime(2020, 6, 19, 20, 24, 17, 206, DateTimeKind.Local).AddTicks(2573), "sciezka Available Design 3", 199.99000000000001, false, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 19, 20, 24, 17, 201, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 20, 20, 24, 17, 201, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.InsertData(
                table: "ModelsPhotos",
                columns: new[] { "Id", "Date", "ImgSrc", "ModelingStyle", "UserId", "BodyDecorations_Puncture", "BodyDecorations_Tattoo" },
                values: new object[] { 3, new DateTime(2020, 7, 20, 20, 24, 17, 201, DateTimeKind.Local).AddTicks(9654), "sciezka MODEL 3", 1, 3, true, false });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 27, 20, 24, 17, 205, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 8, 20, 24, 17, 205, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.InsertData(
                table: "PhotographersPhotos",
                columns: new[] { "Id", "Date", "ImgSrc", "ModelingStyle", "UserId" },
                values: new object[] { 3, new DateTime(2020, 7, 19, 20, 24, 17, 205, DateTimeKind.Local).AddTicks(8266), "sciezka Photographer 3", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "Experience", "Studio" },
                values: new object[] { "Piercer piercer piercer piercer", 3, "RzeszowST" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 17, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 18, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.InsertData(
                table: "Piercings",
                columns: new[] { "Id", "Date", "ImgSrc", "Puncture", "UserId" },
                values: new object[] { 3, new DateTime(2020, 6, 19, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(9589), "sciezka PIERCING 3", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 28, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 29, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.InsertData(
                table: "Tattoos",
                columns: new[] { "Id", "Color", "Date", "ImgSrc", "TattooStyle", "Technique", "UserId" },
                values: new object[] { 3, 1, new DateTime(2020, 6, 30, 20, 24, 17, 200, DateTimeKind.Local).AddTicks(6951), "sciezka TATTOO 3", 3, 2, 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Users_UserId",
                table: "Model",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photographer_Users_UserId",
                table: "Photographer",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattooer_Users_UserId",
                table: "Tattooer",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

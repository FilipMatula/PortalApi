using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class changes8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableDesigns_Tattooers_TattooerId",
                table: "AvailableDesigns");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelsPhotos_Models_ModelId",
                table: "ModelsPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotographersPhotos_Photographers_PhotographerId",
                table: "PhotographersPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Piercings_Piercers_PiercerId",
                table: "Piercings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattoos_Tattooers_TattooerId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattoos_TattooerId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooers");

            migrationBuilder.DropIndex(
                name: "IX_Piercings_PiercerId",
                table: "Piercings");

            migrationBuilder.DropIndex(
                name: "IX_Piercers_UserId",
                table: "Piercers");

            migrationBuilder.DropIndex(
                name: "IX_PhotographersPhotos_PhotographerId",
                table: "PhotographersPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers");

            migrationBuilder.DropIndex(
                name: "IX_ModelsPhotos_ModelId",
                table: "ModelsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Models_UserId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_AvailableDesigns_TattooerId",
                table: "AvailableDesigns");

            migrationBuilder.DropColumn(
                name: "TattooerId",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Tattooers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Tattooers");

            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Tattooers");

            migrationBuilder.DropColumn(
                name: "PiercerId",
                table: "Piercings");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Piercers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Piercers");

            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Piercers");

            migrationBuilder.DropColumn(
                name: "PhotographerId",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "TattooerId",
                table: "AvailableDesigns");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Users",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tattoos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Piercings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PhotographersPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ModelsPhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AvailableDesigns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 10, 16, 18, 57, 227, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 11, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 12, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 13, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 14, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 9, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 9, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 9, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 9, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 9, 16, 18, 57, 230, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 10, 16, 18, 57, 232, DateTimeKind.Local).AddTicks(9939), 1 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 11, 16, 18, 57, 233, DateTimeKind.Local).AddTicks(1679), 2 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 16, 18, 57, 233, DateTimeKind.Local).AddTicks(1712), 3 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 7, 12, 16, 18, 57, 232, DateTimeKind.Local).AddTicks(1048), 1 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 7, 13, 16, 18, 57, 232, DateTimeKind.Local).AddTicks(1673), 2 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 7, 13, 16, 18, 57, 232, DateTimeKind.Local).AddTicks(1698), 3 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 20, 16, 18, 57, 232, DateTimeKind.Local).AddTicks(4444), 1 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 16, 18, 57, 232, DateTimeKind.Local).AddTicks(5028), 2 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 7, 12, 16, 18, 57, 232, DateTimeKind.Local).AddTicks(5054), 3 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 10, 16, 18, 57, 231, DateTimeKind.Local).AddTicks(6273), 1 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 11, 16, 18, 57, 231, DateTimeKind.Local).AddTicks(7413), 2 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 16, 18, 57, 231, DateTimeKind.Local).AddTicks(7436), 3 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 21, 16, 18, 57, 231, DateTimeKind.Local).AddTicks(2272), 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 22, 16, 18, 57, 231, DateTimeKind.Local).AddTicks(3440), 2 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2020, 6, 23, 16, 18, 57, 231, DateTimeKind.Local).AddTicks(3471), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Krakow", 2, "ProfilePhoto1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Rzeszow", 1, "ProfilePhoto12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Warszawa", 2, "ProfilePhoto3" });

            migrationBuilder.CreateIndex(
                name: "IX_Tattoos_UserId",
                table: "Tattoos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piercings_UserId",
                table: "Piercings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercers_UserId",
                table: "Piercers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotographersPhotos_UserId",
                table: "PhotographersPhotos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModelsPhotos_UserId",
                table: "ModelsPhotos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_UserId",
                table: "Models",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AvailableDesigns_UserId",
                table: "AvailableDesigns",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableDesigns_Users_UserId",
                table: "AvailableDesigns",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelsPhotos_Users_UserId",
                table: "ModelsPhotos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotographersPhotos_Users_UserId",
                table: "PhotographersPhotos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Piercings_Users_UserId",
                table: "Piercings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattoos_Users_UserId",
                table: "Tattoos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableDesigns_Users_UserId",
                table: "AvailableDesigns");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelsPhotos_Users_UserId",
                table: "ModelsPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotographersPhotos_Users_UserId",
                table: "PhotographersPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Piercings_Users_UserId",
                table: "Piercings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattoos_Users_UserId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattoos_UserId",
                table: "Tattoos");

            migrationBuilder.DropIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooers");

            migrationBuilder.DropIndex(
                name: "IX_Piercings_UserId",
                table: "Piercings");

            migrationBuilder.DropIndex(
                name: "IX_Piercers_UserId",
                table: "Piercers");

            migrationBuilder.DropIndex(
                name: "IX_PhotographersPhotos_UserId",
                table: "PhotographersPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers");

            migrationBuilder.DropIndex(
                name: "IX_ModelsPhotos_UserId",
                table: "ModelsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Models_UserId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_AvailableDesigns_UserId",
                table: "AvailableDesigns");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Piercings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PhotographersPhotos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ModelsPhotos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AvailableDesigns");

            migrationBuilder.AddColumn<int>(
                name: "TattooerId",
                table: "Tattoos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Tattooers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Tattooers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Tattooers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PiercerId",
                table: "Piercings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Piercers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Piercers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Piercers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotographerId",
                table: "PhotographersPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Photographers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Photographers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Photographers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "ModelsPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Models",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Models",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TattooerId",
                table: "AvailableDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 9, 19, 24, 45, 720, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 10, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 11, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 6, 12, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 6, 13, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 6, 8, 19, 24, 45, 724, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 9, 19, 24, 45, 727, DateTimeKind.Local).AddTicks(2654), 1 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 10, 19, 24, 45, 727, DateTimeKind.Local).AddTicks(6881), 2 });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 11, 19, 24, 45, 727, DateTimeKind.Local).AddTicks(6977), 3 });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Krakow", 2, "ProfilePhoto1" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Warszawa", 1, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Rzeszow", 2, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ModelId" },
                values: new object[] { new DateTime(2020, 7, 11, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(2015), 1 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ModelId" },
                values: new object[] { new DateTime(2020, 7, 12, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(3322), 2 });

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ModelId" },
                values: new object[] { new DateTime(2020, 7, 12, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(3415), 3 });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Krakow", 2, "ProfilePhoto1" });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Warszawa", 1, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "Photographers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Rzeszow", 2, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "PhotographerId" },
                values: new object[] { new DateTime(2020, 6, 19, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(7363), 1 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "PhotographerId" },
                values: new object[] { new DateTime(2020, 6, 30, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(7994), 2 });

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "PhotographerId" },
                values: new object[] { new DateTime(2020, 7, 11, 19, 24, 45, 726, DateTimeKind.Local).AddTicks(8018), 3 });

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Krakow", 2, "ProfilePhoto1" });

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Warszawa", 1, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "Piercers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Rzeszow", 2, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "PiercerId" },
                values: new object[] { new DateTime(2020, 6, 9, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(6206), 1 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "PiercerId" },
                values: new object[] { new DateTime(2020, 6, 10, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(6860), 2 });

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "PiercerId" },
                values: new object[] { new DateTime(2020, 6, 11, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(6889), 3 });

            migrationBuilder.UpdateData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Krakow", 2, "ProfilePhoto1" });

            migrationBuilder.UpdateData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Warszawa", 1, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "Tattooers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Gender", "ImgSrc" },
                values: new object[] { "Rzeszow", 2, "ProfilePhoto2" });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 20, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(1520), 1 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 21, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(2868), 2 });

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "TattooerId" },
                values: new object[] { new DateTime(2020, 6, 22, 19, 24, 45, 725, DateTimeKind.Local).AddTicks(2907), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Tattoos_TattooerId",
                table: "Tattoos",
                column: "TattooerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercings_PiercerId",
                table: "Piercings",
                column: "PiercerId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercers_UserId",
                table: "Piercers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotographersPhotos_PhotographerId",
                table: "PhotographersPhotos",
                column: "PhotographerId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelsPhotos_ModelId",
                table: "ModelsPhotos",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_UserId",
                table: "Models",
                column: "UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ModelsPhotos_Models_ModelId",
                table: "ModelsPhotos",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotographersPhotos_Photographers_PhotographerId",
                table: "PhotographersPhotos",
                column: "PhotographerId",
                principalTable: "Photographers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Piercings_Piercers_PiercerId",
                table: "Piercings",
                column: "PiercerId",
                principalTable: "Piercers",
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
    }
}

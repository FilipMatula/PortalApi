using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class filip1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 20, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(7556), "https://picsum.photos/446/436" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 21, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9668), "https://picsum.photos/426/440" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 22, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9713), "https://picsum.photos/421/433" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 23, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9722), "https://picsum.photos/409/406" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 24, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9728), "https://picsum.photos/443/411" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[] { 1, "Rozmowy6_Content", new DateTime(2020, 7, 25, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9734), "https://picsum.photos/415/402", "Rozmowy6-Title", 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[] { 1, "Rozmowy7_Content", new DateTime(2020, 7, 26, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9742), "https://picsum.photos/445/434", "Rozmowy7-Title", 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[] { 1, "Rozmowy8_Content", new DateTime(2020, 7, 27, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9748), "https://picsum.photos/423/437", "Rozmowy8-Title", 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "Date", "ImgSrc", "Title" },
                values: new object[] { "Wydarzenia1_Content", new DateTime(2020, 7, 20, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9755), "https://picsum.photos/433/402", "Wydarzenia1-Title" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "Date", "ImgSrc", "Title" },
                values: new object[] { "Wydarzenia2_Content", new DateTime(2020, 7, 21, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9762), "https://picsum.photos/423/430", "Wydarzenia2-Title" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[,]
                {
                    { 11, 2, "Wydarzenia3_Content", new DateTime(2020, 7, 22, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9768), "https://picsum.photos/427/436", "Wydarzenia3-Title", 2 },
                    { 12, 2, "Wydarzenia4_Content", new DateTime(2020, 7, 23, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9775), "https://picsum.photos/422/411", "Wydarzenia4-Title", 2 },
                    { 13, 2, "Wydarzenia5_Content", new DateTime(2020, 7, 24, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9783), "https://picsum.photos/448/412", "Wydarzenia5-Title", 2 },
                    { 14, 2, "Wydarzenia6_Content", new DateTime(2020, 7, 25, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9790), "https://picsum.photos/441/423", "Wydarzenia6-Title", 2 },
                    { 15, 2, "Wydarzenia7_Content", new DateTime(2020, 7, 26, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9797), "https://picsum.photos/425/429", "Wydarzenia7-Title", 2 },
                    { 16, 2, "Wydarzenia8_Content", new DateTime(2020, 7, 27, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9807), "https://picsum.photos/402/427", "Wydarzenia8-Title", 2 }
                });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 11, 54, 45, 485, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 11, 54, 45, 485, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 22, 11, 54, 45, 485, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 8, 21, 11, 54, 45, 479, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 8, 22, 11, 54, 45, 479, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 8, 22, 11, 54, 45, 479, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 30, 11, 54, 45, 484, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 8, 10, 11, 54, 45, 484, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 8, 21, 11, 54, 45, 484, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 11, 54, 45, 477, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 11, 54, 45, 477, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 22, 11, 54, 45, 477, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 31, 11, 54, 45, 477, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 8, 1, 11, 54, 45, 477, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 8, 2, 11, 54, 45, 477, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 12, 54, 45, 470, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 13, 54, 45, 474, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 14, 54, 45, 474, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 16, 54, 45, 474, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 15, 54, 45, 474, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "Email", "EmailConfirmationToken", "EmailConfirmed", "FirstName", "Gender", "ImgSrc", "LastName", "PasswordHash", "PasswordSalt", "RegistrationDate", "Username" },
                values: new object[] { 6, 21, "Torun", "slawek@slonce.com", null, true, "Sławomir", 1, "SrcSławekSłoneczny", "Słoneczny", null, null, new DateTime(2020, 7, 19, 11, 54, 45, 474, DateTimeKind.Local).AddTicks(648), "SławKOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 6, 26, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(2612), "sciezka IMG 1" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 6, 27, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3222), "sciezka IMG 2" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 6, 28, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3234), "sciezka IMG 3" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 6, 29, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3238), "sciezka IMG 4" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 6, 30, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3242), "sciezka IMG 5" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[] { 2, "Wydarzenia1_Content", new DateTime(2020, 6, 25, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3246), "sciezka IMG 1", "Wydarzenia1-Title", 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[] { 2, "Wydarzenia2_Content", new DateTime(2020, 6, 25, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3249), "sciezka IMG 2", "Wydarzenia2-Title", 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[] { 2, "Wydarzenia3_Content", new DateTime(2020, 6, 25, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3253), "sciezka IMG 3", "Wydarzenia3-Title", 2 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "Date", "ImgSrc", "Title" },
                values: new object[] { "Wydarzenia4_Content", new DateTime(2020, 6, 25, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3257), "sciezka IMG 4", "Wydarzenia4-Title" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "Date", "ImgSrc", "Title" },
                values: new object[] { "Wydarzenia5_Content", new DateTime(2020, 6, 25, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(3260), "sciezka IMG 5", "Wydarzenia5-Title" });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 26, 20, 44, 48, 565, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 27, 20, 44, 48, 565, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 28, 20, 44, 48, 565, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 28, 20, 44, 48, 561, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 29, 20, 44, 48, 561, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 29, 20, 44, 48, 561, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 6, 20, 44, 48, 565, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 17, 20, 44, 48, 565, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 28, 20, 44, 48, 565, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 26, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 6, 27, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 28, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 7, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 8, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 9, 20, 44, 48, 560, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 25, 21, 44, 48, 555, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 25, 22, 44, 48, 558, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 25, 23, 44, 48, 558, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 26, 1, 44, 48, 558, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 26, 0, 44, 48, 558, DateTimeKind.Local).AddTicks(8811));
        }
    }
}

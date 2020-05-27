using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    ArticleCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleSubCategories_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalTable: "ArticleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    ArticleSubCategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(maxLength: 2500, nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleSubCategories_ArticleSubCategoryId",
                        column: x => x.ArticleSubCategoryId,
                        principalTable: "ArticleSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tatuaż" },
                    { 2, "Piercing" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ArticleSubCategories",
                columns: new[] { "Id", "ArticleCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Rozmowy" },
                    { 2, 1, "Wydarzenia" },
                    { 3, 1, "Porady o tatuażu" },
                    { 4, 1, "Relacje" },
                    { 5, 1, "Różne" },
                    { 6, 1, "Ze świata" },
                    { 7, 1, "Oferty pracy" },
                    { 8, 2, "O przekłuciu" },
                    { 9, 2, "Porady" },
                    { 10, 2, "Rozmowy" },
                    { 11, 2, "Różne" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleSubCategoryId", "Content", "Date", "ImgSrc", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Rozmowy1_Content", new DateTime(2020, 5, 28, 18, 55, 1, 738, DateTimeKind.Local).AddTicks(3873), "sciezka IMG 1", 1, "Rozmowy1-Title" },
                    { 2, 1, "Rozmowy2_Content", new DateTime(2020, 5, 29, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9722), "sciezka IMG 2", 1, "Rozmowy2-Title" },
                    { 3, 1, "Rozmowy3e_Content", new DateTime(2020, 5, 30, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9765), "sciezka IMG 3", 1, "Rozmowy3e-Title" },
                    { 4, 1, "Rozmowy4_Content", new DateTime(2020, 5, 31, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9771), "sciezka IMG 4", 1, "Rozmowy4-Title" },
                    { 5, 1, "Rozmowy5_Content", new DateTime(2020, 6, 1, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9774), "sciezka IMG 5", 1, "Rozmowy5-Title" },
                    { 6, 2, "Wydarzenia1_Content", new DateTime(2020, 5, 27, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9778), "sciezka IMG 1", 2, "Wydarzenia1-Title" },
                    { 7, 2, "Wydarzenia2_Content", new DateTime(2020, 5, 27, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9782), "sciezka IMG 2", 2, "Wydarzenia2-Title" },
                    { 8, 2, "Wydarzenia3_Content", new DateTime(2020, 5, 27, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9786), "sciezka IMG 3", 2, "Wydarzenia3-Title" },
                    { 9, 2, "Wydarzenia4_Content", new DateTime(2020, 5, 27, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9789), "sciezka IMG 4", 2, "Wydarzenia4-Title" },
                    { 10, 2, "Wydarzenia5_Content", new DateTime(2020, 5, 27, 18, 55, 1, 741, DateTimeKind.Local).AddTicks(9793), "sciezka IMG 5", 2, "Wydarzenia5-Title" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleSubCategoryId",
                table: "Articles",
                column: "ArticleSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_PersonId",
                table: "Articles",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleSubCategories_ArticleCategoryId",
                table: "ArticleSubCategories",
                column: "ArticleCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleSubCategories");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "ArticleCategories");
        }
    }
}

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
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    About = table.Column<string>(maxLength: 500, nullable: true),
                    Media = table.Column<string>(maxLength: 200, nullable: true),
                    Piercing = table.Column<bool>(nullable: false),
                    Tattoo = table.Column<bool>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
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
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    About = table.Column<string>(maxLength: 500, nullable: true),
                    Media = table.Column<string>(maxLength: 200, nullable: true),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
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
                name: "Piercings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Pierce = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Tattoos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Style = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Technique = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tattoos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tattoos_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                    { 2, 2 },
                    { 3, 3 }
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
                table: "Models",
                columns: new[] { "Id", "About", "City", "Date", "Gender", "ImgSrc", "Media", "PersonId", "Piercing", "Tattoo" },
                values: new object[,]
                {
                    { 2, "about me - model 2", "Warszawa", new DateTime(2020, 7, 4, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(8436), 1, "sciezka MODEL 2", "/facebook ; /Twitter ; /Instagram", 2, true, true },
                    { 1, "about me - model 1", "Krakow", new DateTime(2020, 7, 3, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(7935), 2, "sciezka MODEL 1", "/facebook ; /Twitter ; /Instagram", 1, true, false },
                    { 3, "about me - model 3", "Poznan", new DateTime(2020, 7, 4, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(8456), 2, "sciezka MODEL 3", "/facebook ; /Twitter ; /Instagram", 3, false, false }
                });

            migrationBuilder.InsertData(
                table: "Photographers",
                columns: new[] { "Id", "About", "City", "Date", "Gender", "ImgSrc", "Media", "PersonId" },
                values: new object[,]
                {
                    { 2, "about me - photographer 2", "Warszawa", new DateTime(2020, 6, 22, 14, 10, 25, 174, DateTimeKind.Local).AddTicks(2265), 1, "sciezka Photographer 2", "/facebook ; /Twitter ; /Instagram", 2 },
                    { 1, "about me - photographer 1", "Krakow", new DateTime(2020, 6, 11, 14, 10, 25, 174, DateTimeKind.Local).AddTicks(1763), 2, "sciezka Photographer 1", "/facebook ; /Twitter ; /Instagram", 1 },
                    { 3, "about me - photographer 3", "Poznan", new DateTime(2020, 7, 3, 14, 10, 25, 174, DateTimeKind.Local).AddTicks(2284), 2, "sciezka Photographer 3", "/facebook ; /Twitter ; /Instagram", 3 }
                });

            migrationBuilder.InsertData(
                table: "Piercings",
                columns: new[] { "Id", "City", "Date", "Gender", "ImgSrc", "PersonId", "Pierce" },
                values: new object[,]
                {
                    { 1, "Krakow", new DateTime(2020, 6, 1, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(3236), 2, "sciezka PIERCING 1", 1, 1 },
                    { 2, "Wroclaw", new DateTime(2020, 6, 2, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(3718), 1, "sciezka PIERCING 2", 1, 2 },
                    { 3, "Poznan", new DateTime(2020, 6, 3, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(3749), 1, "sciezka PIERCING 3", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tattoos",
                columns: new[] { "Id", "City", "Color", "Date", "Gender", "ImgSrc", "PersonId", "Style", "Technique" },
                values: new object[,]
                {
                    { 1, "Rzeszow", 2, new DateTime(2020, 6, 12, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(9435), 2, "sciezka TATTOO 1", 1, 1, 1 },
                    { 2, "Warszawa", 2, new DateTime(2020, 6, 13, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(324), 1, "sciezka TATTOO 2", 1, 2, 2 },
                    { 3, "Krakow", 1, new DateTime(2020, 6, 14, 14, 10, 25, 173, DateTimeKind.Local).AddTicks(351), 2, "sciezka TATTOO 3", 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleSubCategoryId", "Content", "Date", "ImgSrc", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Rozmowy1_Content", new DateTime(2020, 6, 1, 14, 10, 25, 169, DateTimeKind.Local).AddTicks(189), "sciezka IMG 1", 1, "Rozmowy1-Title" },
                    { 2, 1, "Rozmowy2_Content", new DateTime(2020, 6, 2, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5709), "sciezka IMG 2", 1, "Rozmowy2-Title" },
                    { 3, 1, "Rozmowy3e_Content", new DateTime(2020, 6, 3, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5751), "sciezka IMG 3", 1, "Rozmowy3e-Title" },
                    { 4, 1, "Rozmowy4_Content", new DateTime(2020, 6, 4, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5757), "sciezka IMG 4", 1, "Rozmowy4-Title" },
                    { 5, 1, "Rozmowy5_Content", new DateTime(2020, 6, 5, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5762), "sciezka IMG 5", 1, "Rozmowy5-Title" },
                    { 6, 2, "Wydarzenia1_Content", new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5765), "sciezka IMG 1", 2, "Wydarzenia1-Title" },
                    { 7, 2, "Wydarzenia2_Content", new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5803), "sciezka IMG 2", 2, "Wydarzenia2-Title" },
                    { 8, 2, "Wydarzenia3_Content", new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5809), "sciezka IMG 3", 2, "Wydarzenia3-Title" },
                    { 9, 2, "Wydarzenia4_Content", new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5812), "sciezka IMG 4", 2, "Wydarzenia4-Title" },
                    { 10, 2, "Wydarzenia5_Content", new DateTime(2020, 5, 31, 14, 10, 25, 172, DateTimeKind.Local).AddTicks(5816), "sciezka IMG 5", 2, "Wydarzenia5-Title" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Models_PersonId",
                table: "Models",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_PersonId",
                table: "Photographers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercings_PersonId",
                table: "Piercings",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tattoos_PersonId",
                table: "Tattoos",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Photographers");

            migrationBuilder.DropTable(
                name: "Piercings");

            migrationBuilder.DropTable(
                name: "Tattoos");

            migrationBuilder.DropTable(
                name: "ArticleSubCategories");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "ArticleCategories");
        }
    }
}

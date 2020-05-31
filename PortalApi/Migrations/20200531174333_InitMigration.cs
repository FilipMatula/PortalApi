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
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
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
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvailableDesignPhotos",
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
                    table.PrimaryKey("PK_AvailableDesignPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableDesignPhotos_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                    Puncture = table.Column<bool>(nullable: false),
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
                name: "PhotographersPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotographersPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotographersPhotos_People_PersonId",
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
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Puncture = table.Column<int>(nullable: false),
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
                    City = table.Column<string>(maxLength: 50, nullable: false),
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
                    ArticleSubcategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(maxLength: 2500, nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleSubCategories_ArticleSubcategoryId",
                        column: x => x.ArticleSubcategoryId,
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
                table: "Country",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Polska" },
                    { 2, "Niemcy" },
                    { 3, "Francja" }
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
                table: "City",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 7, 3, "Paryż" },
                    { 6, 2, "Frankfurt" },
                    { 5, 2, "Monachium" },
                    { 4, 2, "Berlin" },
                    { 3, 1, "Wroclaw" },
                    { 2, 1, "Krakow" },
                    { 1, 1, "Warszawa" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "City", "Date", "Gender", "ImgSrc", "PersonId", "Puncture", "Tattoo" },
                values: new object[,]
                {
                    { 1, "Krakow", new DateTime(2020, 7, 3, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(6097), 2, "sciezka MODEL 1", 1, true, false },
                    { 2, "Warszawa", new DateTime(2020, 7, 4, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(6591), 1, "sciezka MODEL 2", 2, true, true },
                    { 3, "Poznan", new DateTime(2020, 7, 4, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(6610), 2, "sciezka MODEL 3", 3, false, false }
                });

            migrationBuilder.InsertData(
                table: "PhotographersPhotos",
                columns: new[] { "Id", "City", "Date", "Gender", "ImgSrc", "PersonId" },
                values: new object[,]
                {
                    { 1, "Krakow", new DateTime(2020, 6, 11, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(9114), 2, "sciezka Photographer 1", 1 },
                    { 2, "Warszawa", new DateTime(2020, 6, 22, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(9591), 1, "sciezka Photographer 2", 2 },
                    { 3, "Poznan", new DateTime(2020, 7, 3, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(9610), 2, "sciezka Photographer 3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Piercings",
                columns: new[] { "Id", "City", "Date", "Gender", "ImgSrc", "PersonId", "Puncture" },
                values: new object[,]
                {
                    { 1, "Krakow", new DateTime(2020, 6, 1, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(2201), 2, "sciezka PIERCING 1", 1, 1 },
                    { 2, "Wroclaw", new DateTime(2020, 6, 2, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(2690), 1, "sciezka PIERCING 2", 1, 2 },
                    { 3, "Poznan", new DateTime(2020, 6, 3, 19, 43, 33, 300, DateTimeKind.Local).AddTicks(2745), 1, "sciezka PIERCING 3", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tattoos",
                columns: new[] { "Id", "City", "Color", "Date", "Gender", "ImgSrc", "PersonId", "Style", "Technique" },
                values: new object[,]
                {
                    { 1, "Rzeszow", 2, new DateTime(2020, 6, 12, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(8425), 2, "sciezka TATTOO 1", 1, 1, 2 },
                    { 2, "Warszawa", 2, new DateTime(2020, 6, 13, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(9307), 1, "sciezka TATTOO 2", 1, 2, 1 },
                    { 3, "Krakow", 1, new DateTime(2020, 6, 14, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(9331), 2, "sciezka TATTOO 3", 2, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Rozmowy1_Content", new DateTime(2020, 6, 1, 19, 43, 33, 296, DateTimeKind.Local).AddTicks(246), "sciezka IMG 1", 1, "Rozmowy1-Title" },
                    { 2, 1, "Rozmowy2_Content", new DateTime(2020, 6, 2, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(4990), "sciezka IMG 2", 1, "Rozmowy2-Title" },
                    { 3, 1, "Rozmowy3e_Content", new DateTime(2020, 6, 3, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5030), "sciezka IMG 3", 1, "Rozmowy3e-Title" },
                    { 4, 1, "Rozmowy4_Content", new DateTime(2020, 6, 4, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5035), "sciezka IMG 4", 1, "Rozmowy4-Title" },
                    { 5, 1, "Rozmowy5_Content", new DateTime(2020, 6, 5, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5039), "sciezka IMG 5", 1, "Rozmowy5-Title" },
                    { 6, 2, "Wydarzenia1_Content", new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5043), "sciezka IMG 1", 2, "Wydarzenia1-Title" },
                    { 7, 2, "Wydarzenia2_Content", new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5047), "sciezka IMG 2", 2, "Wydarzenia2-Title" },
                    { 8, 2, "Wydarzenia3_Content", new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5050), "sciezka IMG 3", 2, "Wydarzenia3-Title" },
                    { 9, 2, "Wydarzenia4_Content", new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5054), "sciezka IMG 4", 2, "Wydarzenia4-Title" },
                    { 10, 2, "Wydarzenia5_Content", new DateTime(2020, 5, 31, 19, 43, 33, 299, DateTimeKind.Local).AddTicks(5057), "sciezka IMG 5", 2, "Wydarzenia5-Title" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleSubcategoryId",
                table: "Articles",
                column: "ArticleSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_PersonId",
                table: "Articles",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleSubCategories_ArticleCategoryId",
                table: "ArticleSubCategories",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableDesignPhotos_PersonId",
                table: "AvailableDesignPhotos",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_PersonId",
                table: "Models",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotographersPhotos_PersonId",
                table: "PhotographersPhotos",
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
                name: "AvailableDesignPhotos");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "PhotographersPhotos");

            migrationBuilder.DropTable(
                name: "Piercings");

            migrationBuilder.DropTable(
                name: "Tattoos");

            migrationBuilder.DropTable(
                name: "ArticleSubCategories");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "ArticleCategories");
        }
    }
}

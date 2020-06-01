using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class Initial : Migration
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
                name: "AvailableDesigns",
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
                    table.PrimaryKey("PK_AvailableDesigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableDesigns_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelsPhotos",
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
                    table.PrimaryKey("PK_ModelsPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelsPhotos_People_PersonId",
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
                    Experience = table.Column<int>(nullable: false),
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
                    { 2, "Piercing" },
                    { 3, "Modeling" },
                    { 4, "Fotografia" }
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
                    { 15, 4, "Różne" },
                    { 14, 4, "Rozmowy" },
                    { 13, 3, "Różne" },
                    { 12, 3, "Rozmowy" },
                    { 11, 2, "Różne" },
                    { 9, 2, "Porady" },
                    { 10, 2, "Rozmowy" },
                    { 7, 1, "Oferty pracy" },
                    { 6, 1, "Ze świata" },
                    { 5, 1, "Różne" },
                    { 4, 1, "Relacje" },
                    { 3, 1, "Porady o tatuażu" },
                    { 2, 1, "Wydarzenia" },
                    { 8, 2, "O przekłuciu" }
                });

            migrationBuilder.InsertData(
                table: "AvailableDesigns",
                columns: new[] { "Id", "City", "Color", "Date", "Gender", "ImgSrc", "PersonId", "Style", "Technique" },
                values: new object[,]
                {
                    { 3, "Krakow", 1, new DateTime(2020, 6, 4, 19, 44, 15, 62, DateTimeKind.Local).AddTicks(1213), 2, "sciezka Available Design 3", 3, 3, 2 },
                    { 2, "Poznan", 1, new DateTime(2020, 6, 3, 19, 44, 15, 62, DateTimeKind.Local).AddTicks(1188), 2, "sciezka Available Design 2", 2, 2, 1 },
                    { 1, "Warszawa", 1, new DateTime(2020, 6, 2, 19, 44, 15, 62, DateTimeKind.Local).AddTicks(312), 1, "sciezka Available Design 1", 1, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 7, 3, "Paryż" },
                    { 6, 2, "Frankfurt" },
                    { 4, 2, "Berlin" },
                    { 3, 1, "Wroclaw" },
                    { 2, 1, "Krakow" },
                    { 1, 1, "Warszawa" },
                    { 5, 2, "Monachium" }
                });

            migrationBuilder.InsertData(
                table: "ModelsPhotos",
                columns: new[] { "Id", "City", "Date", "Gender", "ImgSrc", "PersonId", "Puncture", "Tattoo" },
                values: new object[,]
                {
                    { 3, "Poznan", new DateTime(2020, 7, 5, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(3812), 2, "sciezka MODEL 3", 3, false, false },
                    { 1, "Krakow", new DateTime(2020, 7, 4, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(3316), 2, "sciezka MODEL 1", 1, true, false },
                    { 2, "Warszawa", new DateTime(2020, 7, 5, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(3792), 1, "sciezka MODEL 2", 2, true, true }
                });

            migrationBuilder.InsertData(
                table: "PhotographersPhotos",
                columns: new[] { "Id", "City", "Date", "Experience", "Gender", "ImgSrc", "PersonId" },
                values: new object[,]
                {
                    { 1, "Krakow", new DateTime(2020, 6, 12, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(6584), 3, 2, "sciezka Photographer 1", 1 },
                    { 2, "Warszawa", new DateTime(2020, 6, 23, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(7066), 1, 1, "sciezka Photographer 2", 2 },
                    { 3, "Poznan", new DateTime(2020, 7, 4, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(7085), 2, 2, "sciezka Photographer 3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Piercings",
                columns: new[] { "Id", "City", "Date", "Gender", "ImgSrc", "PersonId", "Puncture" },
                values: new object[,]
                {
                    { 1, "Krakow", new DateTime(2020, 6, 2, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(9579), 2, "sciezka PIERCING 1", 1, 1 },
                    { 2, "Wroclaw", new DateTime(2020, 6, 3, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(75), 1, "sciezka PIERCING 2", 1, 2 },
                    { 3, "Poznan", new DateTime(2020, 6, 4, 19, 44, 15, 61, DateTimeKind.Local).AddTicks(111), 1, "sciezka PIERCING 3", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tattoos",
                columns: new[] { "Id", "City", "Color", "Date", "Gender", "ImgSrc", "PersonId", "Style", "Technique" },
                values: new object[,]
                {
                    { 1, "Rzeszow", 2, new DateTime(2020, 6, 13, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(5823), 2, "sciezka TATTOO 1", 1, 1, 2 },
                    { 2, "Warszawa", 2, new DateTime(2020, 6, 14, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(6690), 1, "sciezka TATTOO 2", 1, 2, 1 },
                    { 3, "Krakow", 1, new DateTime(2020, 6, 15, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(6715), 2, "sciezka TATTOO 3", 2, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Rozmowy1_Content", new DateTime(2020, 6, 2, 19, 44, 15, 57, DateTimeKind.Local).AddTicks(1087), "sciezka IMG 1", 1, "Rozmowy1-Title" },
                    { 2, 1, "Rozmowy2_Content", new DateTime(2020, 6, 3, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2422), "sciezka IMG 2", 1, "Rozmowy2-Title" },
                    { 3, 1, "Rozmowy3e_Content", new DateTime(2020, 6, 4, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2481), "sciezka IMG 3", 1, "Rozmowy3e-Title" },
                    { 4, 1, "Rozmowy4_Content", new DateTime(2020, 6, 5, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2489), "sciezka IMG 4", 1, "Rozmowy4-Title" },
                    { 5, 1, "Rozmowy5_Content", new DateTime(2020, 6, 6, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2494), "sciezka IMG 5", 1, "Rozmowy5-Title" },
                    { 6, 2, "Wydarzenia1_Content", new DateTime(2020, 6, 1, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2499), "sciezka IMG 1", 2, "Wydarzenia1-Title" },
                    { 7, 2, "Wydarzenia2_Content", new DateTime(2020, 6, 1, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2504), "sciezka IMG 2", 2, "Wydarzenia2-Title" },
                    { 8, 2, "Wydarzenia3_Content", new DateTime(2020, 6, 1, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2509), "sciezka IMG 3", 2, "Wydarzenia3-Title" },
                    { 9, 2, "Wydarzenia4_Content", new DateTime(2020, 6, 1, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2513), "sciezka IMG 4", 2, "Wydarzenia4-Title" },
                    { 10, 2, "Wydarzenia5_Content", new DateTime(2020, 6, 1, 19, 44, 15, 60, DateTimeKind.Local).AddTicks(2518), "sciezka IMG 5", 2, "Wydarzenia5-Title" }
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
                name: "IX_AvailableDesigns_PersonId",
                table: "AvailableDesigns",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelsPhotos_PersonId",
                table: "ModelsPhotos",
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
                name: "AvailableDesigns");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "ModelsPhotos");

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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class milosz1 : Migration
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Username = table.Column<string>(maxLength: 80, nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    City = table.Column<string>(maxLength: 150, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    UserId = table.Column<int>(nullable: false),
                    TattooStyle = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Technique = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: true),
                    Reserved = table.Column<bool>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableDesigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableDesigns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Breast = table.Column<int>(nullable: false),
                    Waist = table.Column<int>(nullable: false),
                    Hip = table.Column<int>(nullable: false),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelsPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ModelingStyle = table.Column<int>(nullable: false),
                    BodyDecorations_Puncture = table.Column<bool>(nullable: true),
                    BodyDecorations_Tattoo = table.Column<bool>(nullable: true),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelsPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelsPhotos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photographers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photographers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotographersPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ModelingStyle = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotographersPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotographersPhotos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piercers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Studio = table.Column<string>(maxLength: 50, nullable: true),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true),
                    Punctures = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piercers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piercers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piercings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Puncture = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piercings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piercings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tattooers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Studio = table.Column<string>(maxLength: 50, nullable: true),
                    About = table.Column<string>(maxLength: 1500, nullable: true),
                    MediaFB = table.Column<string>(maxLength: 150, nullable: true),
                    MediaInstagram = table.Column<string>(maxLength: 150, nullable: true),
                    MediaTwitter = table.Column<string>(maxLength: 150, nullable: true),
                    TattooStyle = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tattooers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tattooers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tattoos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    TattooStyle = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Technique = table.Column<int>(nullable: false),
                    ImgSrc = table.Column<string>(maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tattoos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tattoos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
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
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                table: "Users",
                columns: new[] { "Id", "Age", "City", "FirstName", "Gender", "ImgSrc", "LastName", "PasswordHash", "PasswordSalt", "RegistrationDate", "Username" },
                values: new object[,]
                {
                    { 1, 18, "Krakow", "Marika", 2, "ProfilePhoto1", "Nowak-Piercer", null, null, new DateTime(2020, 6, 18, 2, 15, 13, 353, DateTimeKind.Local).AddTicks(5633), "Marina" },
                    { 2, 25, "Rzeszow", "Jan", 1, "ProfilePhoto12", "Kowalski-Piercer", null, null, new DateTime(2020, 6, 18, 4, 15, 13, 356, DateTimeKind.Local).AddTicks(6974), "JanKo" },
                    { 3, 31, "Wroclaw", "Mirko", 1, "ProfilePhoto3", "MirkoLastNamePiercer", null, null, new DateTime(2020, 6, 17, 18, 15, 13, 356, DateTimeKind.Local).AddTicks(7010), "MirKO" }
                });

            migrationBuilder.InsertData(
                table: "ArticleSubCategories",
                columns: new[] { "Id", "ArticleCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Rozmowy" },
                    { 14, 4, "Rozmowy" },
                    { 13, 3, "Różne" },
                    { 12, 3, "Rozmowy" },
                    { 11, 2, "Różne" },
                    { 10, 2, "Rozmowy" },
                    { 9, 2, "Porady" },
                    { 15, 4, "Różne" },
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
                columns: new[] { "Id", "Color", "Date", "ImgSrc", "Price", "Reserved", "TattooStyle", "Technique", "UserId" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2020, 6, 20, 16, 15, 13, 364, DateTimeKind.Local).AddTicks(2012), "sciezka Available Design 3", 199.99000000000001, false, 3, 2, 3 },
                    { 1, 1, new DateTime(2020, 6, 18, 16, 15, 13, 364, DateTimeKind.Local).AddTicks(1036), "sciezka Available Design 1", null, false, 1, 2, 1 },
                    { 2, 1, new DateTime(2020, 6, 19, 16, 15, 13, 364, DateTimeKind.Local).AddTicks(1984), "sciezka Available Design 2", 300.0, true, 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 2, 1, "Krakow" },
                    { 5, 2, "Monachium" },
                    { 6, 2, "Frankfurt" },
                    { 7, 3, "Paryż" },
                    { 1, 1, "Warszawa" },
                    { 3, 1, "Wroclaw" },
                    { 4, 2, "Berlin" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "About", "Breast", "Experience", "Height", "Hip", "MediaFB", "MediaInstagram", "MediaTwitter", "UserId", "Waist", "Weight" },
                values: new object[,]
                {
                    { 1, null, 60, 3, 160, 70, null, null, null, 1, 45, 53 },
                    { 3, null, 70, 2, 170, 60, null, null, null, 3, 55, 63 },
                    { 2, null, 80, 1, 180, 90, null, null, null, 2, 65, 73 }
                });

            migrationBuilder.InsertData(
                table: "ModelsPhotos",
                columns: new[] { "Id", "Date", "ImgSrc", "ModelingStyle", "UserId", "BodyDecorations_Puncture", "BodyDecorations_Tattoo" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 7, 21, 16, 15, 13, 359, DateTimeKind.Local).AddTicks(7547), "sciezka MODEL 3", 1, 3, true, false },
                    { 2, new DateTime(2020, 7, 21, 16, 15, 13, 359, DateTimeKind.Local).AddTicks(7528), "sciezka MODEL 2", 5, 2, false, true },
                    { 1, new DateTime(2020, 7, 20, 16, 15, 13, 359, DateTimeKind.Local).AddTicks(7052), "sciezka MODEL 1", 4, 1, false, false }
                });

            migrationBuilder.InsertData(
                table: "Photographers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "UserId" },
                values: new object[,]
                {
                    { 2, null, 1, null, null, null, 2 },
                    { 1, null, 3, null, null, null, 1 },
                    { 3, null, 2, null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "PhotographersPhotos",
                columns: new[] { "Id", "Date", "ImgSrc", "ModelingStyle", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 7, 9, 16, 15, 13, 363, DateTimeKind.Local).AddTicks(7644), "sciezka Photographer 2", 5, 2 },
                    { 1, new DateTime(2020, 6, 28, 16, 15, 13, 363, DateTimeKind.Local).AddTicks(7150), "sciezka Photographer 1", 4, 1 },
                    { 3, new DateTime(2020, 7, 20, 16, 15, 13, 363, DateTimeKind.Local).AddTicks(7664), "sciezka Photographer 3", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Piercers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Punctures", "Studio", "UserId" },
                values: new object[,]
                {
                    { 1, "nastolenia piercerka sluzy przekuciami", 1, "FACEBOOK link 1", "INSTAGRAM link 1", "TWITTER link 1", 2, "PierKRA", 1 },
                    { 2, "bardzo duzo pracy - wciaz znajduje czas na pierscienie :)", 2, "FACEBOOK link 2", "INSTAGRAM link 2", "TWITTER link 2", 1, "PiercerRZ", 2 },
                    { 3, null, 0, null, null, null, 0, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Piercings",
                columns: new[] { "Id", "Date", "ImgSrc", "Puncture", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 18, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(7208), "sciezka PIERCING 1", 1, 1 },
                    { 2, new DateTime(2020, 6, 19, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(7674), "sciezka PIERCING 2", 2, 2 },
                    { 3, new DateTime(2020, 6, 20, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(7693), "sciezka PIERCING 3", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tattooers",
                columns: new[] { "Id", "About", "Experience", "MediaFB", "MediaInstagram", "MediaTwitter", "Studio", "TattooStyle", "UserId" },
                values: new object[,]
                {
                    { 2, null, 0, null, null, null, null, 0, 2 },
                    { 3, null, 0, null, null, null, null, 0, 3 },
                    { 1, null, 0, null, null, null, null, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tattoos",
                columns: new[] { "Id", "Color", "Date", "ImgSrc", "TattooStyle", "Technique", "UserId" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2020, 6, 30, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(5081), "sciezka TATTOO 2", 2, 1, 2 },
                    { 3, 1, new DateTime(2020, 7, 1, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(5107), "sciezka TATTOO 3", 3, 2, 3 },
                    { 1, 2, new DateTime(2020, 6, 29, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(4213), "sciezka TATTOO 1", 1, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Rozmowy1_Content", new DateTime(2020, 6, 18, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(741), "sciezka IMG 1", "Rozmowy1-Title", 1 },
                    { 2, 1, "Rozmowy2_Content", new DateTime(2020, 6, 19, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1624), "sciezka IMG 2", "Rozmowy2-Title", 1 },
                    { 3, 1, "Rozmowy3e_Content", new DateTime(2020, 6, 20, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1650), "sciezka IMG 3", "Rozmowy3e-Title", 1 },
                    { 4, 1, "Rozmowy4_Content", new DateTime(2020, 6, 21, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1655), "sciezka IMG 4", "Rozmowy4-Title", 1 },
                    { 5, 1, "Rozmowy5_Content", new DateTime(2020, 6, 22, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1659), "sciezka IMG 5", "Rozmowy5-Title", 1 },
                    { 6, 2, "Wydarzenia1_Content", new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1663), "sciezka IMG 1", "Wydarzenia1-Title", 2 },
                    { 7, 2, "Wydarzenia2_Content", new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1667), "sciezka IMG 2", "Wydarzenia2-Title", 2 },
                    { 8, 2, "Wydarzenia3_Content", new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1671), "sciezka IMG 3", "Wydarzenia3-Title", 2 },
                    { 9, 2, "Wydarzenia4_Content", new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1675), "sciezka IMG 4", "Wydarzenia4-Title", 2 },
                    { 10, 2, "Wydarzenia5_Content", new DateTime(2020, 6, 17, 16, 15, 13, 358, DateTimeKind.Local).AddTicks(1679), "sciezka IMG 5", "Wydarzenia5-Title", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleSubcategoryId",
                table: "Articles",
                column: "ArticleSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleSubCategories_ArticleCategoryId",
                table: "ArticleSubCategories",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableDesigns_UserId",
                table: "AvailableDesigns",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_UserId",
                table: "Models",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModelsPhotos_UserId",
                table: "ModelsPhotos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotographersPhotos_UserId",
                table: "PhotographersPhotos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Piercers_UserId",
                table: "Piercers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piercings_UserId",
                table: "Piercings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tattooers_UserId",
                table: "Tattooers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tattoos_UserId",
                table: "Tattoos",
                column: "UserId");
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
                name: "Models");

            migrationBuilder.DropTable(
                name: "ModelsPhotos");

            migrationBuilder.DropTable(
                name: "Photographers");

            migrationBuilder.DropTable(
                name: "PhotographersPhotos");

            migrationBuilder.DropTable(
                name: "Piercers");

            migrationBuilder.DropTable(
                name: "Piercings");

            migrationBuilder.DropTable(
                name: "Tattooers");

            migrationBuilder.DropTable(
                name: "Tattoos");

            migrationBuilder.DropTable(
                name: "ArticleSubCategories");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ArticleCategories");
        }
    }
}

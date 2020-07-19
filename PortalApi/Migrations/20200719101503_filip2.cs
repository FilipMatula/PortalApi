using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class filip2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(2524), "https://picsum.photos/402/422" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3708), "https://picsum.photos/440/439" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3749), "https://picsum.photos/437/437" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3757), "https://picsum.photos/438/438" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3764), "https://picsum.photos/407/404" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3770), "https://picsum.photos/401/433" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3776), "https://picsum.photos/408/403" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3784), "https://picsum.photos/428/435" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3804), "https://picsum.photos/441/413" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3810), "https://picsum.photos/423/422" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3816), "https://picsum.photos/406/424" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3823), "https://picsum.photos/433/444" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3830), "https://picsum.photos/438/444" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3838), "https://picsum.photos/406/409" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3843), "https://picsum.photos/411/419" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3850), "https://picsum.photos/400/423" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleSubcategoryId", "Content", "Date", "ImgSrc", "Title", "UserId" },
                values: new object[,]
                {
                    { 96, 12, "Rozmowy_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4337), "https://picsum.photos/433/438", "Rozmowy_8-Title", 2 },
                    { 95, 12, "Rozmowy_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4332), "https://picsum.photos/441/401", "Rozmowy_7-Title", 2 },
                    { 94, 12, "Rozmowy_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4326), "https://picsum.photos/431/401", "Rozmowy_6-Title", 2 },
                    { 93, 12, "Rozmowy_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4321), "https://picsum.photos/436/438", "Rozmowy_5-Title", 2 },
                    { 92, 12, "Rozmowy_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4315), "https://picsum.photos/405/412", "Rozmowy_4-Title", 2 },
                    { 91, 12, "Rozmowy_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4310), "https://picsum.photos/416/426", "Rozmowy_3-Title", 2 },
                    { 90, 12, "Rozmowy_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4304), "https://picsum.photos/410/420", "Rozmowy_2-Title", 2 },
                    { 97, 13, "Różne_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4343), "https://picsum.photos/421/404", "Różne_1-Title", 2 },
                    { 89, 12, "Rozmowy_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4299), "https://picsum.photos/418/443", "Rozmowy_1-Title", 2 },
                    { 81, 11, "Różne_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4246), "https://picsum.photos/403/430", "Różne_1-Title", 2 },
                    { 86, 11, "Różne_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4281), "https://picsum.photos/421/445", "Różne_6-Title", 2 },
                    { 85, 11, "Różne_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4276), "https://picsum.photos/443/445", "Różne_5-Title", 2 },
                    { 84, 11, "Różne_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4270), "https://picsum.photos/434/437", "Różne_4-Title", 2 },
                    { 83, 11, "Różne_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4264), "https://picsum.photos/413/437", "Różne_3-Title", 2 },
                    { 82, 11, "Różne_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4258), "https://picsum.photos/404/432", "Różne_2-Title", 2 },
                    { 98, 13, "Różne_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4349), "https://picsum.photos/411/411", "Różne_2-Title", 2 },
                    { 80, 10, "Rozmowy_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4241), "https://picsum.photos/412/402", "Rozmowy_8-Title", 2 },
                    { 79, 10, "Rozmowy_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4235), "https://picsum.photos/405/405", "Rozmowy_7-Title", 2 },
                    { 88, 11, "Różne_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4293), "https://picsum.photos/433/404", "Różne_8-Title", 2 },
                    { 99, 13, "Różne_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4354), "https://picsum.photos/440/404", "Różne_3-Title", 2 },
                    { 106, 14, "Rozmowy_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4395), "https://picsum.photos/448/411", "Rozmowy_2-Title", 2 },
                    { 101, 13, "Różne_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4366), "https://picsum.photos/446/427", "Różne_5-Title", 2 },
                    { 120, 15, "Różne_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4479), "https://picsum.photos/416/417", "Różne_8-Title", 2 },
                    { 119, 15, "Różne_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4474), "https://picsum.photos/405/401", "Różne_7-Title", 2 },
                    { 118, 15, "Różne_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4468), "https://picsum.photos/424/438", "Różne_6-Title", 2 },
                    { 117, 15, "Różne_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4458), "https://picsum.photos/434/443", "Różne_5-Title", 2 },
                    { 116, 15, "Różne_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4452), "https://picsum.photos/413/413", "Różne_4-Title", 2 },
                    { 115, 15, "Różne_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4446), "https://picsum.photos/403/422", "Różne_3-Title", 2 },
                    { 114, 15, "Różne_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4441), "https://picsum.photos/424/422", "Różne_2-Title", 2 },
                    { 113, 15, "Różne_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4435), "https://picsum.photos/411/432", "Różne_1-Title", 2 },
                    { 112, 14, "Rozmowy_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4429), "https://picsum.photos/446/442", "Rozmowy_8-Title", 2 },
                    { 111, 14, "Rozmowy_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4424), "https://picsum.photos/405/433", "Rozmowy_7-Title", 2 },
                    { 110, 14, "Rozmowy_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4418), "https://picsum.photos/446/425", "Rozmowy_6-Title", 2 },
                    { 109, 14, "Rozmowy_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4413), "https://picsum.photos/424/442", "Rozmowy_5-Title", 2 },
                    { 108, 14, "Rozmowy_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4407), "https://picsum.photos/435/426", "Rozmowy_4-Title", 2 },
                    { 107, 14, "Rozmowy_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4401), "https://picsum.photos/445/441", "Rozmowy_3-Title", 2 },
                    { 78, 10, "Rozmowy_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4229), "https://picsum.photos/408/416", "Rozmowy_6-Title", 2 },
                    { 105, 14, "Rozmowy_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4389), "https://picsum.photos/441/404", "Rozmowy_1-Title", 2 },
                    { 104, 13, "Różne_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4384), "https://picsum.photos/446/417", "Różne_8-Title", 2 },
                    { 103, 13, "Różne_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4378), "https://picsum.photos/445/419", "Różne_7-Title", 2 },
                    { 102, 13, "Różne_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4372), "https://picsum.photos/420/403", "Różne_6-Title", 2 },
                    { 100, 13, "Różne_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4360), "https://picsum.photos/408/416", "Różne_4-Title", 2 },
                    { 77, 10, "Rozmowy_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4224), "https://picsum.photos/432/425", "Rozmowy_5-Title", 2 },
                    { 87, 11, "Różne_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4287), "https://picsum.photos/427/414", "Różne_7-Title", 2 },
                    { 75, 10, "Rozmowy_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4212), "https://picsum.photos/449/416", "Rozmowy_3-Title", 2 },
                    { 43, 6, "Ze_świata_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4016), "https://picsum.photos/408/427", "Ze_świata_3-Title", 2 },
                    { 42, 6, "Ze_świata_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4009), "https://picsum.photos/449/441", "Ze_świata_2-Title", 2 },
                    { 41, 6, "Ze_świata_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4002), "https://picsum.photos/409/415", "Ze_świata_1-Title", 2 },
                    { 40, 5, "Różne_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3997), "https://picsum.photos/408/439", "Różne_8-Title", 2 },
                    { 39, 5, "Różne_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3991), "https://picsum.photos/425/428", "Różne_7-Title", 2 },
                    { 38, 5, "Różne_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3984), "https://picsum.photos/447/421", "Różne_6-Title", 2 },
                    { 37, 5, "Różne_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3978), "https://picsum.photos/437/410", "Różne_5-Title", 2 },
                    { 36, 5, "Różne_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3973), "https://picsum.photos/435/416", "Różne_4-Title", 2 },
                    { 76, 10, "Rozmowy_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4218), "https://picsum.photos/415/423", "Rozmowy_4-Title", 2 },
                    { 34, 5, "Różne_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3961), "https://picsum.photos/427/413", "Różne_2-Title", 2 },
                    { 33, 5, "Różne_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3955), "https://picsum.photos/403/428", "Różne_1-Title", 2 },
                    { 32, 4, "Relacje_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3947), "https://picsum.photos/426/438", "Relacje_8-Title", 2 },
                    { 44, 6, "Ze_świata_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4023), "https://picsum.photos/428/422", "Ze_świata_4-Title", 2 },
                    { 31, 4, "Relacje_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3940), "https://picsum.photos/430/429", "Relacje_7-Title", 2 },
                    { 29, 4, "Relacje_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3929), "https://picsum.photos/439/446", "Relacje_5-Title", 2 },
                    { 28, 4, "Relacje_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3923), "https://picsum.photos/446/427", "Relacje_4-Title", 2 },
                    { 27, 4, "Relacje_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3917), "https://picsum.photos/444/432", "Relacje_3-Title", 2 },
                    { 26, 4, "Relacje_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3911), "https://picsum.photos/410/423", "Relacje_2-Title", 2 },
                    { 25, 4, "Relacje_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3903), "https://picsum.photos/410/420", "Relacje_1-Title", 2 },
                    { 24, 3, "Porady_o_tatuazu_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3897), "https://picsum.photos/434/441", "Porady_o_tatuazu_8-Title", 2 },
                    { 23, 3, "Porady_o_tatuazu_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3891), "https://picsum.photos/436/449", "Porady_o_tatuazu_7-Title", 2 },
                    { 22, 3, "Porady_o_tatuazu_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3885), "https://picsum.photos/449/405", "Porady_o_tatuazu_6-Title", 2 },
                    { 21, 3, "Porady_o_tatuazu_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3879), "https://picsum.photos/424/435", "Porady_o_tatuazu_5-Title", 2 },
                    { 20, 3, "Porady_o_tatuazu_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3873), "https://picsum.photos/426/412", "Porady_o_tatuazu_4-Title", 2 },
                    { 19, 3, "Porady_o_tatuazu_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3868), "https://picsum.photos/449/425", "Porady_o_tatuazu_3-Title", 2 },
                    { 18, 3, "Porady_o_tatuazu_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3862), "https://picsum.photos/433/432", "Porady_o_tatuazu_2-Title", 2 },
                    { 30, 4, "Relacje_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3935), "https://picsum.photos/400/443", "Relacje_6-Title", 2 },
                    { 45, 6, "Ze_świata_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4036), "https://picsum.photos/448/405", "Ze_świata_5-Title", 2 },
                    { 35, 5, "Różne_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3967), "https://picsum.photos/420/445", "Różne_3-Title", 2 },
                    { 47, 6, "Ze_świata_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4048), "https://picsum.photos/425/432", "Ze_świata_7-Title", 2 },
                    { 74, 10, "Rozmowy_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4206), "https://picsum.photos/415/414", "Rozmowy_2-Title", 2 },
                    { 73, 10, "Rozmowy_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4200), "https://picsum.photos/404/431", "Rozmowy_1-Title", 2 },
                    { 72, 9, "Porady_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4194), "https://picsum.photos/437/422", "Porady_8-Title", 2 },
                    { 71, 9, "Porady_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4188), "https://picsum.photos/442/445", "Porady_7-Title", 2 },
                    { 70, 9, "Porady_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4183), "https://picsum.photos/407/414", "Porady_6-Title", 2 },
                    { 69, 9, "Porady_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4177), "https://picsum.photos/444/434", "Porady_5-Title", 2 },
                    { 68, 9, "Porady_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4171), "https://picsum.photos/417/438", "Porady_4-Title", 2 },
                    { 67, 9, "Porady_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4166), "https://picsum.photos/426/400", "Porady_3-Title", 2 },
                    { 66, 9, "Porady_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4160), "https://picsum.photos/412/414", "Porady_2-Title", 2 },
                    { 65, 9, "Porady_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4154), "https://picsum.photos/428/402", "Porady_1-Title", 2 },
                    { 64, 8, "O_przekłuciu_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4148), "https://picsum.photos/440/404", "O_przekłuciu_8-Title", 2 },
                    { 63, 8, "O_przekłuciu_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4142), "https://picsum.photos/402/432", "O_przekłuciu_7-Title", 2 },
                    { 62, 8, "O_przekłuciu_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4137), "https://picsum.photos/415/414", "O_przekłuciu_6-Title", 2 },
                    { 61, 8, "O_przekłuciu_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4131), "https://picsum.photos/449/405", "O_przekłuciu_5-Title", 2 },
                    { 46, 6, "Ze_świata_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4042), "https://picsum.photos/443/403", "Ze_świata_6-Title", 2 },
                    { 17, 3, "Porady_o_tatuazu_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(3856), "https://picsum.photos/405/444", "Porady_o_tatuazu_1-Title", 2 },
                    { 56, 7, "Oferty_pracy_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4102), "https://picsum.photos/401/411", "Oferty_pracy_8-Title", 2 },
                    { 48, 6, "Ze_świata_8_Content", new DateTime(2020, 7, 27, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4054), "https://picsum.photos/431/445", "Ze_świata_8-Title", 2 },
                    { 49, 7, "Oferty_pracy_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4059), "https://picsum.photos/408/411", "Oferty_pracy_1-Title", 2 },
                    { 50, 7, "Oferty_pracy_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4065), "https://picsum.photos/401/407", "Oferty_pracy_2-Title", 2 },
                    { 51, 7, "Oferty_pracy_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4071), "https://picsum.photos/421/420", "Oferty_pracy_3-Title", 2 },
                    { 52, 7, "Oferty_pracy_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4078), "https://picsum.photos/420/414", "Oferty_pracy_4-Title", 2 },
                    { 58, 8, "O_przekłuciu_2_Content", new DateTime(2020, 7, 21, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4114), "https://picsum.photos/433/415", "O_przekłuciu_2-Title", 2 },
                    { 59, 8, "O_przekłuciu_3_Content", new DateTime(2020, 7, 22, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4119), "https://picsum.photos/430/434", "O_przekłuciu_3-Title", 2 },
                    { 53, 7, "Oferty_pracy_5_Content", new DateTime(2020, 7, 24, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4084), "https://picsum.photos/434/444", "Oferty_pracy_5-Title", 2 },
                    { 60, 8, "O_przekłuciu_4_Content", new DateTime(2020, 7, 23, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4125), "https://picsum.photos/429/426", "O_przekłuciu_4-Title", 2 },
                    { 55, 7, "Oferty_pracy_7_Content", new DateTime(2020, 7, 26, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4096), "https://picsum.photos/435/425", "Oferty_pracy_7-Title", 2 },
                    { 57, 8, "O_przekłuciu_1_Content", new DateTime(2020, 7, 20, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4108), "https://picsum.photos/437/411", "O_przekłuciu_1-Title", 2 },
                    { 54, 7, "Oferty_pracy_6_Content", new DateTime(2020, 7, 25, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(4090), "https://picsum.photos/435/433", "Oferty_pracy_6-Title", 2 }
                });

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 12, 15, 2, 926, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 12, 15, 2, 927, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "AvailableDesigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 22, 12, 15, 2, 927, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 8, 21, 12, 15, 2, 921, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 8, 22, 12, 15, 2, 921, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "ModelsPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 8, 22, 12, 15, 2, 921, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 30, 12, 15, 2, 926, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 8, 10, 12, 15, 2, 926, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "PhotographersPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 8, 21, 12, 15, 2, 926, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 20, 12, 15, 2, 920, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 21, 12, 15, 2, 920, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Piercings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 22, 12, 15, 2, 920, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 31, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 8, 1, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Tattoos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 8, 2, 12, 15, 2, 919, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 13, 15, 2, 914, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 14, 15, 2, 916, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 15, 15, 2, 916, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 17, 15, 2, 916, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 16, 15, 2, 916, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 12, 15, 2, 916, DateTimeKind.Local).AddTicks(6369));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 120);

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
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 25, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9734), "https://picsum.photos/415/402" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 26, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9742), "https://picsum.photos/445/434" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 27, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9748), "https://picsum.photos/423/437" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 20, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9755), "https://picsum.photos/433/402" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 21, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9762), "https://picsum.photos/423/430" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 22, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9768), "https://picsum.photos/427/436" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 23, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9775), "https://picsum.photos/422/411" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 24, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9783), "https://picsum.photos/448/412" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 25, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9790), "https://picsum.photos/441/423" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 26, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9797), "https://picsum.photos/425/429" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "ImgSrc" },
                values: new object[] { new DateTime(2020, 7, 27, 11, 54, 45, 476, DateTimeKind.Local).AddTicks(9807), "https://picsum.photos/402/427" });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 7, 19, 11, 54, 45, 474, DateTimeKind.Local).AddTicks(648));
        }
    }
}

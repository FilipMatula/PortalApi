using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApi.Migrations
{
    public partial class DescriptionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "Description",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

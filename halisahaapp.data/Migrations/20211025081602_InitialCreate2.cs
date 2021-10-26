using Microsoft.EntityFrameworkCore.Migrations;

namespace halisahaapp.data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Comments");
        }
    }
}

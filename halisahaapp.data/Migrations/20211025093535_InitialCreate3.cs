using Microsoft.EntityFrameworkCore.Migrations;

namespace halisahaapp.data.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AvgPoint",
                table: "Halisahas",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgPoint",
                table: "Halisahas");
        }
    }
}

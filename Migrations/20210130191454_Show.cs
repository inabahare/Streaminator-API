using Microsoft.EntityFrameworkCore.Migrations;

namespace Streaminator_API.Migrations
{
    public partial class Show : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "REL_Video",
                table: "Videos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "REL_Video",
                table: "Videos");
        }
    }
}

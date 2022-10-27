using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson23.Migrations
{
    public partial class AlterMechanicAddLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "level",
                table: "mechanic",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "level",
                table: "mechanic");
        }
    }
}

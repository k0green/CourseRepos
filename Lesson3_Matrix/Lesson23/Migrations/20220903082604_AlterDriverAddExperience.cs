using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson23.Migrations
{
    public partial class AlterDriverAddExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "experience",
                table: "drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "experience",
                table: "drivers");
        }
    }
}

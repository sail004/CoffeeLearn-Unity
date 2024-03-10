using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeLearnWebApi.Migrations
{
    /// <inheritdoc />
    public partial class DucumentResoursesAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "DocumentResourses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DocumentResourses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "DocumentResourses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DocumentResourses");
        }
    }
}

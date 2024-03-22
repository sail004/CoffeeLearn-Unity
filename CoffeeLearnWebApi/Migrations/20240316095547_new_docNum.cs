using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeLearnWebApi.Migrations
{
    /// <inheritdoc />
    public partial class new_docNum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentNumber",
                table: "DocumentResourses");

            migrationBuilder.AddColumn<int>(
                name: "DocumentNumber",
                table: "Documents",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentNumber",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "DocumentNumber",
                table: "DocumentResourses",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}

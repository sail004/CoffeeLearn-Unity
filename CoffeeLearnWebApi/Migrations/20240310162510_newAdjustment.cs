using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeLearnWebApi.Migrations
{
    /// <inheritdoc />
    public partial class newAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "DocumentResourses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DocumentResourses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}

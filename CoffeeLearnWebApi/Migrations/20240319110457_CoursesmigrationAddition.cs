using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeLearnWebApi.Migrations
{
    /// <inheritdoc />
    public partial class CoursesmigrationAddition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LectureId",
                table: "CourseStructures");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "CourseStructures");

            migrationBuilder.AddColumn<int>(
                name: "StructureId",
                table: "practiceTests",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StructureId",
                table: "Lecture",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Courses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StructureId",
                table: "practiceTests");

            migrationBuilder.DropColumn(
                name: "StructureId",
                table: "Lecture");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "LectureId",
                table: "CourseStructures",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "CourseStructures",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}

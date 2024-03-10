using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeLearnWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Password", "Role", "Name", "Surname" },
                values: new object[,]
                {
            { 1, "user1", "password1", "Стажёр", "Иван", "Иванов" },
            { 2, "user2", "password2", "бариста", "Петр", "Петров" },
            { 3, "user3", "password3", "Менеджер", "Анна", "Сидорова" },
            { 4, "user4", "password4", "Управляющий", "Мария", "Павлова" },
            { 5, "user5", "password5", "Менеджер по персоналу", "Сергей", "Смирнов" }
                });
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

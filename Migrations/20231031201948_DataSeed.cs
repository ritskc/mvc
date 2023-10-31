using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mvc.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 1, "rohit@bcci.com", "Rohit Sharma" },
                    { 2, 1, "shubhman@bcci.com", "Shubhman Gill" },
                    { 3, 1, "virat@bcci.com", "Virat Kohli" },
                    { 4, 1, "shreyas@bcci.com", "Shreyas Iyyer" },
                    { 5, 4, "rahul@bcci.com", "KL Rahul" },
                    { 6, 1, "surya@bcci.com", "Surya Yadav" },
                    { 7, 3, "hardik@bcci.com", "Hardik Pandya" },
                    { 8, 3, "jadeja@bcci.com", "Ravi Jadeja" },
                    { 9, 2, "kuldeep@bcci.com", "Kuldeep Yadav" },
                    { 10, 2, "shami@bcci.com", "Mohd. Shami" },
                    { 11, 2, "jasprit@bcci.com", "Jasprit Bumrah" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}

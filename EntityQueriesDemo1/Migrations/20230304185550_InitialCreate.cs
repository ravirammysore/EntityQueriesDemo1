using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityQueriesDemo1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "City", "Mark", "StudentName" },
                values: new object[,]
                {
                    { 1, "NYC", 73, "John Nigel" },
                    { 2, "CA", 51, "Alex Roma" },
                    { 3, "CA", 88, "Noha Shamil" },
                    { 4, "NYC", 60, "James Palatte" },
                    { 5, "NYC", 85, "Ron Jenova" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}

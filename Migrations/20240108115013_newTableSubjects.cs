using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentsManagement.Migrations
{
    /// <inheritdoc />
    public partial class newTableSubjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Credits", "Name" },
                values: new object[,]
                {
                    { 1, 10, "Operating systems" },
                    { 2, 10, "Database management systems" },
                    { 3, 10, "Computer networks" },
                    { 4, 10, "Web programming" },
                    { 5, 5, "Theory of computation and automata theory" },
                    { 6, 4, "Software engineering" },
                    { 7, 4, "GIS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "FirstName");
        }
    }
}

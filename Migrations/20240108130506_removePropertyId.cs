using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsManagement.Migrations
{
    /// <inheritdoc />
    public partial class removePropertyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "SubjectStudents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SubjectStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

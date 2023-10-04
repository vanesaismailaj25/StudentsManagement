using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentsManagement.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Password", "PhoneNumber", "RegistrationYear", "StudentYear" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "vanesa@gmail.com", "Vanesa", 1, "Ismailaj", "vanesa123$", "0681245789", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, new DateTime(2003, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mary@gmail.com", "Mary", 1, "John", "mary123$", "0681298456", new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2004, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "elon@gmail.com", "Elon", 0, "Smith", "elon123$", "0694590123", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demokrata.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Sueldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144)),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FechaNacimiento", "PrimerApellido", "PrimerNombre", "SegundoApellido", "SegundoNombre", "Sueldo" },
                values: new object[,]
                {
                    { 1, new DateOnly(1990, 1, 1), "González", "Carlos", "López", "Andrés", 50000m },
                    { 2, new DateOnly(1992, 5, 15), "Rodríguez", "María", "Martínez", "Isabel", 55000m },
                    { 3, new DateOnly(1985, 7, 20), "Fernández", "Javier", "Pérez", "Antonio", 60000m },
                    { 4, new DateOnly(1988, 11, 11), "García", "Lucía", "Hernández", "Mariana", 62000m },
                    { 5, new DateOnly(1995, 3, 10), "Ruiz", "Miguel", "Ramírez", "Ángel", 48000m },
                    { 6, new DateOnly(1991, 9, 30), "Moreno", "Ana", "Torres", "Sofía", 57000m },
                    { 7, new DateOnly(1987, 6, 5), "Romero", "José", "Vargas", "Luis", 51000m },
                    { 8, new DateOnly(1993, 8, 22), "Díaz", "Laura", "Castro", "Beatriz", 59000m },
                    { 9, new DateOnly(1989, 2, 14), "Ortiz", "Santiago", "Flores", "Tomás", 53000m },
                    { 10, new DateOnly(1984, 12, 25), "Vega", "Carmen", "Morales", "Victoria", 62000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

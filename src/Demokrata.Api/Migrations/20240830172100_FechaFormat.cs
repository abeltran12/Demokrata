using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demokrata.Api.Migrations
{
    /// <inheritdoc />
    public partial class FechaFormat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1992, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1985, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1988, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1991, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1987, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1993, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1989, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847), new DateTime(1984, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaNacimiento",
                table: "Employees",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1990, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1992, 5, 15) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1985, 7, 20) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1988, 11, 11) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1995, 3, 10) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1991, 9, 30) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1987, 6, 5) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1993, 8, 22) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1989, 2, 14) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FechaCreacion", "FechaModificacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 30, 4, 7, 30, 312, DateTimeKind.Utc).AddTicks(6144), new DateOnly(1984, 12, 25) });
        }
    }
}

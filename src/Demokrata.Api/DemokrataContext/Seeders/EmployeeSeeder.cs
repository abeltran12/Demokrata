namespace Demokrata.Api.DemokrataContext.Seeders;

using Demokrata.Api.Models;
using Microsoft.EntityFrameworkCore;

public static class EmployeeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var currentDate = DateTime.UtcNow;

        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                PrimerNombre = "Carlos",
                SegundoNombre = "Andrés",
                PrimerApellido = "González",
                SegundoApellido = "López",
                FechaNacimiento = new DateTime(1990, 1, 1),
                Sueldo = 50000m
            },
            new Employee
            {
                Id = 2,
                PrimerNombre = "María",
                SegundoNombre = "Isabel",
                PrimerApellido = "Rodríguez",
                SegundoApellido = "Martínez",
                FechaNacimiento = new DateTime(1992, 5, 15),
                Sueldo = 55000m
            },
            new Employee
            {
                Id = 3,
                PrimerNombre = "Javier",
                SegundoNombre = "Antonio",
                PrimerApellido = "Fernández",
                SegundoApellido = "Pérez",
                FechaNacimiento = new DateTime(1985, 7, 20),
                Sueldo = 60000m
            },
            new Employee
            {
                Id = 4,
                PrimerNombre = "Lucía",
                SegundoNombre = "Mariana",
                PrimerApellido = "García",
                SegundoApellido = "Hernández",
                FechaNacimiento = new DateTime(1988, 11, 11),
                Sueldo = 62000m
            },
            new Employee
            {
                Id = 5,
                PrimerNombre = "Miguel",
                SegundoNombre = "Ángel",
                PrimerApellido = "Ruiz",
                SegundoApellido = "Ramírez",
                FechaNacimiento = new DateTime(1995, 3, 10),
                Sueldo = 48000m
            },
            new Employee
            {
                Id = 6,
                PrimerNombre = "Ana",
                SegundoNombre = "Sofía",
                PrimerApellido = "Moreno",
                SegundoApellido = "Torres",
                FechaNacimiento = new DateTime(1991, 9, 30),
                Sueldo = 57000m
            },
            new Employee
            {
                Id = 7,
                PrimerNombre = "José",
                SegundoNombre = "Luis",
                PrimerApellido = "Romero",
                SegundoApellido = "Vargas",
                FechaNacimiento = new DateTime(1987, 6, 5),
                Sueldo = 51000m
            },
            new Employee
            {
                Id = 8,
                PrimerNombre = "Laura",
                SegundoNombre = "Beatriz",
                PrimerApellido = "Díaz",
                SegundoApellido = "Castro",
                FechaNacimiento = new DateTime(1993, 8, 22),
                Sueldo = 59000m
            },
            new Employee
            {
                Id = 9,
                PrimerNombre = "Santiago",
                SegundoNombre = "Tomás",
                PrimerApellido = "Ortiz",
                SegundoApellido = "Flores",
                FechaNacimiento = new DateTime(1989, 2, 14),
                Sueldo = 53000m
            },
            new Employee
            {
                Id = 10,
                PrimerNombre = "Carmen",
                SegundoNombre = "Victoria",
                PrimerApellido = "Vega",
                SegundoApellido = "Morales",
                FechaNacimiento = new DateTime(1984, 12, 25),
                Sueldo = 62000m
            }
        );

        modelBuilder.Entity<Employee>().Property<DateTime>("FechaCreacion").HasDefaultValue(currentDate);
        modelBuilder.Entity<Employee>().Property<DateTime>("FechaModificacion").HasDefaultValue(currentDate);
    }
}
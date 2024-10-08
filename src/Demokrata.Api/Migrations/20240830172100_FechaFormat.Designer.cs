﻿// <auto-generated />
using System;
using Demokrata.Api.DemokrataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demokrata.Api.Migrations
{
    [DbContext(typeof(DemokrataDbContext))]
    [Migration("20240830172100_FechaFormat")]
    partial class FechaFormat
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demokrata.Api.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847))
                        .HasColumnName("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 8, 30, 17, 20, 59, 781, DateTimeKind.Utc).AddTicks(2847))
                        .HasColumnName("FechaModificacion");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SegundoApellido")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SegundoNombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Sueldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaNacimiento = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "González",
                            PrimerNombre = "Carlos",
                            SegundoApellido = "López",
                            SegundoNombre = "Andrés",
                            Sueldo = 50000m
                        },
                        new
                        {
                            Id = 2,
                            FechaNacimiento = new DateTime(1992, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Rodríguez",
                            PrimerNombre = "María",
                            SegundoApellido = "Martínez",
                            SegundoNombre = "Isabel",
                            Sueldo = 55000m
                        },
                        new
                        {
                            Id = 3,
                            FechaNacimiento = new DateTime(1985, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Fernández",
                            PrimerNombre = "Javier",
                            SegundoApellido = "Pérez",
                            SegundoNombre = "Antonio",
                            Sueldo = 60000m
                        },
                        new
                        {
                            Id = 4,
                            FechaNacimiento = new DateTime(1988, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "García",
                            PrimerNombre = "Lucía",
                            SegundoApellido = "Hernández",
                            SegundoNombre = "Mariana",
                            Sueldo = 62000m
                        },
                        new
                        {
                            Id = 5,
                            FechaNacimiento = new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Ruiz",
                            PrimerNombre = "Miguel",
                            SegundoApellido = "Ramírez",
                            SegundoNombre = "Ángel",
                            Sueldo = 48000m
                        },
                        new
                        {
                            Id = 6,
                            FechaNacimiento = new DateTime(1991, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Moreno",
                            PrimerNombre = "Ana",
                            SegundoApellido = "Torres",
                            SegundoNombre = "Sofía",
                            Sueldo = 57000m
                        },
                        new
                        {
                            Id = 7,
                            FechaNacimiento = new DateTime(1987, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Romero",
                            PrimerNombre = "José",
                            SegundoApellido = "Vargas",
                            SegundoNombre = "Luis",
                            Sueldo = 51000m
                        },
                        new
                        {
                            Id = 8,
                            FechaNacimiento = new DateTime(1993, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Díaz",
                            PrimerNombre = "Laura",
                            SegundoApellido = "Castro",
                            SegundoNombre = "Beatriz",
                            Sueldo = 59000m
                        },
                        new
                        {
                            Id = 9,
                            FechaNacimiento = new DateTime(1989, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Ortiz",
                            PrimerNombre = "Santiago",
                            SegundoApellido = "Flores",
                            SegundoNombre = "Tomás",
                            Sueldo = 53000m
                        },
                        new
                        {
                            Id = 10,
                            FechaNacimiento = new DateTime(1984, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrimerApellido = "Vega",
                            PrimerNombre = "Carmen",
                            SegundoApellido = "Morales",
                            SegundoNombre = "Victoria",
                            Sueldo = 62000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

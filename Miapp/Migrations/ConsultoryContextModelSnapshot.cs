﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Miapp.Migrations
{
    [DbContext(typeof(ConsultoryContext))]
    partial class ConsultoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Miapp.Models.Municipio", b =>
                {
                    b.Property<int>("IDPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Enfermedad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Medicina")
                        .IsRequired()
                        .HasColumnType("text");

                  

                    b.HasKey("municipioID");

                    b.ToTable("Municipio");
                });
#pragma warning restore 612, 618
        }
    }
}
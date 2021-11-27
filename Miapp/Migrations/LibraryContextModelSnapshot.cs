﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace primeraAplicacion.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("primeraAplicacion.Models.Owner", b =>
                {
                    b.Property<int>("OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firsName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OwnerID");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("primeraAplicacion.Models.Perro", b =>
                {
                    b.Property<int>("perroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ownerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("raza")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("vaccine")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("perroID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Perro");
                });

            modelBuilder.Entity("primeraAplicacion.Models.Perro", b =>
                {
                    b.HasOne("primeraAplicacion.Models.Owner", "Owner")
                        .WithMany("Perros")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("primeraAplicacion.Models.Owner", b =>
                {
                    b.Navigation("Perros");
                });
#pragma warning restore 612, 618
        }
    }
}
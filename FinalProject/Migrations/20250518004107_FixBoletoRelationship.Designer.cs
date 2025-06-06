﻿// <auto-generated />
using System;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(FinalProjectDbContext))]
    [Migration("20250518004107_FixBoletoRelationship")]
    partial class FixBoletoRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject.Data.Boleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Asiento")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncion")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdFuncion");

                    b.ToTable("Boletos");
                });

            modelBuilder.Entity("FinalProject.Data.Funcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Formato")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("IdPelicula")
                        .HasColumnType("int");

                    b.Property<int>("IdSala")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPelicula");

                    b.HasIndex("IdSala");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("FinalProject.Data.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Clasificacion")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duracion")
                        .HasColumnType("time");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("FinalProject.Data.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("FinalProject.Data.Boleto", b =>
                {
                    b.HasOne("FinalProject.Data.Funcion", "Funcion")
                        .WithMany()
                        .HasForeignKey("IdFuncion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcion");
                });

            modelBuilder.Entity("FinalProject.Data.Funcion", b =>
                {
                    b.HasOne("FinalProject.Data.Pelicula", "Pelicula")
                        .WithMany()
                        .HasForeignKey("IdPelicula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("IdSala")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}

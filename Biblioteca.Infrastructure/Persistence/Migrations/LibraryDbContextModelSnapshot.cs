﻿// <auto-generated />
using Biblioteca.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.Domain.Entities.Autores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.AutoresHasLibros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutoresId")
                        .HasColumnType("int");

                    b.Property<int>("BookIBSN")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AutoresHasLibros");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Book", b =>
                {
                    b.Property<int>("IBSN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("editoriales_id")
                        .HasColumnType("int");

                    b.Property<int>("n_paginas")
                        .HasColumnType("int");

                    b.Property<string>("sinopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IBSN");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.editoriales_", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sede")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("editoriales");
                });
#pragma warning restore 612, 618
        }
    }
}

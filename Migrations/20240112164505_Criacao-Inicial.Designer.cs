﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoMVC2024.Data;

#nullable disable

namespace ProjetoMVC2024.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240112164505_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoMVC2024.Models.Formulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("longtext")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("SobreNome")
                        .HasColumnType("longtext")
                        .HasColumnName("SobreNome");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Formulario");
                });
#pragma warning restore 612, 618
        }
    }
}

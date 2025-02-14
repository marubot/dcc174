﻿// <auto-generated />
using System;
using Estagios.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estagios.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220807001844_Usersv1")]
    partial class Usersv1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Estagios.Models.Estagio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AgenteIntegracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AtividadeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataInicioEstagio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataTerminoEstagio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disciplina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailSupervisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormacaoSupervisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Formando")
                        .HasColumnType("int");

                    b.Property<string>("FuncaoSupervisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDiscente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeResponsavelEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeSupervisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orientador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SituacaoEstagio")
                        .HasColumnType("int");

                    b.Property<int>("TipoConcedente")
                        .HasColumnType("int");

                    b.Property<int>("TipoEstagio")
                        .HasColumnType("int");

                    b.Property<int>("TipoRemuneracao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estagios");
                });

            modelBuilder.Entity("Estagios.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

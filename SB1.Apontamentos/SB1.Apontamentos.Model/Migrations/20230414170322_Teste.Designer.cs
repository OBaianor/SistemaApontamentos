﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SB1.Apontamentos.Model;

#nullable disable

namespace SB1.Apontamentos.Model.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230414170322_Teste")]
    partial class Teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SB1.Apontamentos.Model.CadastroColaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Doc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Doc");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DtAtualizacao");

                    b.Property<DateTime>("DtInsercao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DtInsercao");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DtNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Senha");

                    b.Property<string>("TipoColaborador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoParc");

                    b.Property<string>("TipoDoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoDoc");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Usuario");

                    b.HasKey("Id");

                    b.ToTable("CadastroColaborador", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
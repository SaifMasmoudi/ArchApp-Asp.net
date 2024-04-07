﻿// <auto-generated />
using System;
using ExamanApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamanApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231213155337_base2")]
    partial class base2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamanApp.Models.Architecte", b =>
                {
                    b.Property<int>("ArchitecteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArchitecteId"));

                    b.Property<string>("NomArchitecte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenomArchitecte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArchitecteId");

                    b.ToTable("Architecte");
                });

            modelBuilder.Entity("ExamanApp.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<int?>("ArchitecteId")
                        .HasColumnType("int");

                    b.Property<string>("NomClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.HasIndex("ArchitecteId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ExamanApp.Models.Facture", b =>
                {
                    b.Property<int>("FactureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FactureId"));

                    b.Property<string>("Montant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjetId")
                        .HasColumnType("int");

                    b.HasKey("FactureId");

                    b.HasIndex("ProjetId");

                    b.ToTable("Facture");
                });

            modelBuilder.Entity("ExamanApp.Models.Projet", b =>
                {
                    b.Property<int>("ProjetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjetId"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomProjet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatutProjet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addresseProjet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjetId");

                    b.HasIndex("ClientId");

                    b.ToTable("Projet");
                });

            modelBuilder.Entity("ExamanApp.Models.Client", b =>
                {
                    b.HasOne("ExamanApp.Models.Architecte", "Architecte")
                        .WithMany()
                        .HasForeignKey("ArchitecteId");

                    b.Navigation("Architecte");
                });

            modelBuilder.Entity("ExamanApp.Models.Facture", b =>
                {
                    b.HasOne("ExamanApp.Models.Projet", "Projet")
                        .WithMany()
                        .HasForeignKey("ProjetId");

                    b.Navigation("Projet");
                });

            modelBuilder.Entity("ExamanApp.Models.Projet", b =>
                {
                    b.HasOne("ExamanApp.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}

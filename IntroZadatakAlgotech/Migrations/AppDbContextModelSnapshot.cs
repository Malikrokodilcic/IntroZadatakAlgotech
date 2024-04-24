﻿// <auto-generated />
using System;
using IntroZadatakAlgotech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntroZadatakAlgotech.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IntroZadatakAlgotech.Models.Kandidat", b =>
                {
                    b.Property<int>("KandidatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KandidatID"));

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Obrazovanje")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KandidatID");

                    b.HasIndex("JMBG")
                        .IsUnique();

                    b.ToTable("Kandidati");
                });

            modelBuilder.Entity("IntroZadatakAlgotech.Models.Pozicija", b =>
                {
                    b.Property<int>("PozicijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PozicijaID"));

                    b.Property<DateTime>("DatumKrajaPrijave")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NacinRada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PozicijaID");

                    b.ToTable("Pozicije");
                });

            modelBuilder.Entity("IntroZadatakAlgotech.Models.Prijava", b =>
                {
                    b.Property<int>("PrijavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrijavaID"));

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<int>("KandidatID")
                        .HasColumnType("int");

                    b.Property<int>("PozicijaID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrijavaID");

                    b.HasIndex("PozicijaID");

                    b.HasIndex("KandidatID", "PozicijaID")
                        .IsUnique();

                    b.ToTable("Prijave");
                });

            modelBuilder.Entity("IntroZadatakAlgotech.Models.Prijava", b =>
                {
                    b.HasOne("IntroZadatakAlgotech.Models.Kandidat", "Kandidat")
                        .WithMany("Prijave")
                        .HasForeignKey("KandidatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntroZadatakAlgotech.Models.Pozicija", "Pozicija")
                        .WithMany("Prijave")
                        .HasForeignKey("PozicijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kandidat");

                    b.Navigation("Pozicija");
                });

            modelBuilder.Entity("IntroZadatakAlgotech.Models.Kandidat", b =>
                {
                    b.Navigation("Prijave");
                });

            modelBuilder.Entity("IntroZadatakAlgotech.Models.Pozicija", b =>
                {
                    b.Navigation("Prijave");
                });
#pragma warning restore 612, 618
        }
    }
}

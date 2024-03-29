﻿// <auto-generated />
using System;
using DataWork.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataWork.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    partial class CinemaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataWork.Entities.Actors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Raiting")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Canada",
                            DateBirth = new DateTime(1980, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rayan Gosling",
                            Raiting = 10
                        },
                        new
                        {
                            Id = 2,
                            Country = "UK",
                            DateBirth = new DateTime(1955, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rowan Atkinson",
                            Raiting = 10
                        },
                        new
                        {
                            Id = 3,
                            Country = "UK",
                            DateBirth = new DateTime(1967, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jason Statham",
                            Raiting = 9
                        });
                });

            modelBuilder.Entity("DataWork.Entities.Sessions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hall")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFilm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            End = new DateTime(2023, 6, 1, 17, 40, 0, 0, DateTimeKind.Unspecified),
                            Hall = "Alpha",
                            NameFilm = "Schedryck",
                            Price = 100,
                            Start = new DateTime(2023, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            End = new DateTime(2023, 6, 1, 18, 25, 0, 0, DateTimeKind.Unspecified),
                            Hall = "Beta",
                            NameFilm = "Sky wars",
                            Price = 50,
                            Start = new DateTime(2023, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            End = new DateTime(2023, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall = "Alpha",
                            NameFilm = "Skazhene vesillya",
                            Price = 80,
                            Start = new DateTime(2023, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            End = new DateTime(2023, 6, 1, 12, 40, 0, 0, DateTimeKind.Unspecified),
                            Hall = "Beta",
                            NameFilm = "Titanic",
                            Price = 100,
                            Start = new DateTime(2023, 6, 9, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

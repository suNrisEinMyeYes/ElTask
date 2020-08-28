﻿// <auto-generated />
using System;
using ElTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ElTask.Migrations
{
    [DbContext(typeof(Data.AppContext))]
    [Migration("20200827200438_newdb")]
    partial class newdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ElTask.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Building")
                        .HasColumnType("integer");

                    b.Property<int>("Name")
                        .HasColumnType("integer");

                    b.Property<int>("Office")
                        .HasColumnType("integer");

                    b.Property<int>("RoomNumb")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ElTask.Models.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CPU")
                        .HasColumnType("text");

                    b.Property<DateTime>("CurrentStatus")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepreciationPeriod")
                        .HasColumnType("integer");

                    b.Property<string>("Graphics")
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OS")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("RAMsize")
                        .HasColumnType("integer");

                    b.Property<float>("ScreenSize")
                        .HasColumnType("real");

                    b.Property<DateTime>("StorageArrivingDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("StorageCapacity")
                        .HasColumnType("integer");

                    b.Property<string>("StorageType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("ElTask.Models.LaptopRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("InventoryNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("WriteOffDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Lreg");
                });
#pragma warning restore 612, 618
        }
    }
}

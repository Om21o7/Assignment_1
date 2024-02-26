﻿// <auto-generated />
using System;
using Assignment_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment_1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240224034541_CarRental")]
    partial class CarRental
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Assignment_1.Models.CarRental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Model")
                        .HasColumnType("longtext");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("RentalAgency")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CarRentals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAvailable = true,
                            Model = "Toyota Camry",
                            PricePerDay = 50.00m,
                            RentalAgency = "ABC Rentals"
                        },
                        new
                        {
                            Id = 2,
                            IsAvailable = false,
                            Model = "Honda Civic",
                            PricePerDay = 45.00m,
                            RentalAgency = "XYZ Rentals"
                        },
                        new
                        {
                            Id = 3,
                            IsAvailable = true,
                            Model = "Ford Mustang",
                            PricePerDay = 70.00m,
                            RentalAgency = "123 Rentals"
                        });
                });

            modelBuilder.Entity("Assignment_1.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Destination")
                        .HasColumnType("longtext");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Origin")
                        .HasColumnType("longtext");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalTime = new DateTime(2024, 2, 24, 0, 45, 40, 959, DateTimeKind.Local).AddTicks(6130),
                            DepartureTime = new DateTime(2024, 2, 23, 22, 45, 40, 959, DateTimeKind.Local).AddTicks(6100),
                            Destination = "City B",
                            FlightNumber = "ABC123",
                            Origin = "City A",
                            Price = 200f
                        },
                        new
                        {
                            Id = 2,
                            ArrivalTime = new DateTime(2024, 2, 24, 3, 45, 40, 959, DateTimeKind.Local).AddTicks(6140),
                            DepartureTime = new DateTime(2024, 2, 24, 1, 45, 40, 959, DateTimeKind.Local).AddTicks(6130),
                            Destination = "City C",
                            FlightNumber = "DEF456",
                            Origin = "City B",
                            Price = 250f
                        });
                });

            modelBuilder.Entity("Assignment_1.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<float>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAvailable = true,
                            Location = "City X",
                            Name = "Hotel ABC",
                            PricePerNight = 150f,
                            Rating = 4
                        },
                        new
                        {
                            Id = 2,
                            IsAvailable = true,
                            Location = "City Y",
                            Name = "Hotel XYZ",
                            PricePerNight = 120f,
                            Rating = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
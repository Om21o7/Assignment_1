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
    [Migration("20240223035317_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalTime = new DateTime(2024, 2, 23, 0, 53, 17, 328, DateTimeKind.Local).AddTicks(6130),
                            DepartureTime = new DateTime(2024, 2, 22, 22, 53, 17, 328, DateTimeKind.Local).AddTicks(6100),
                            Destination = "City B",
                            FlightNumber = "ABC123",
                            Origin = "City A",
                            Price = 200m
                        },
                        new
                        {
                            Id = 2,
                            ArrivalTime = new DateTime(2024, 2, 23, 3, 53, 17, 328, DateTimeKind.Local).AddTicks(6140),
                            DepartureTime = new DateTime(2024, 2, 23, 1, 53, 17, 328, DateTimeKind.Local).AddTicks(6130),
                            Destination = "City C",
                            FlightNumber = "DEF456",
                            Origin = "City B",
                            Price = 250m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

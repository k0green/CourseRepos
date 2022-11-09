﻿// <auto-generated />
using System;
using Lesson23;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lesson23.Migrations
{
    [DbContext(typeof(autoparkContext))]
    partial class autoparkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("Lesson23.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Message")
                        .HasColumnType("text")
                        .HasColumnName("message");

                    b.HasKey("Id");

                    b.ToTable("audit", (string)null);
                });

            modelBuilder.Entity("Lesson23.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Model")
                        .HasColumnType("text")
                        .HasColumnName("model");

                    b.Property<string>("Number")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("number");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int")
                        .HasColumnName("owner_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Number" }, "car_number_index")
                        .IsUnique();

                    b.HasIndex(new[] { "OwnerId" }, "owner_fk");

                    b.ToTable("car", (string)null);
                });

            modelBuilder.Entity("Lesson23.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<int>("Experience")
                        .HasColumnType("int")
                        .HasColumnName("experience");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("phone");

                    b.Property<string>("Surname")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name", "Surname" }, "driver_name_index");

                    b.HasIndex(new[] { "Phone" }, "phone")
                        .IsUnique();

                    b.ToTable("drivers", (string)null);
                });

            modelBuilder.Entity("Lesson23.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<string>("CarType")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("car_type");

                    b.Property<int?>("SecurityLevel")
                        .HasColumnType("int")
                        .HasColumnName("security_level");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CarId" }, "car_fk");

                    b.ToTable("garage", (string)null);
                });

            modelBuilder.Entity("Lesson23.Mechanic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("phone");

                    b.Property<string>("Specialization")
                        .HasColumnType("text")
                        .HasColumnName("specialization");

                    b.Property<string>("Surname")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Phone" }, "mechanic_phone_index")
                        .IsUnique();

                    b.ToTable("mechanic", (string)null);
                });

            modelBuilder.Entity("Lesson23.ServiceStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("MechanicId")
                        .HasColumnType("int")
                        .HasColumnName("mechanic_id");

                    b.Property<string>("Specialization")
                        .HasColumnType("text")
                        .HasColumnName("specialization");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "MechanicId" }, "mechanic_fk");

                    b.ToTable("service_station", (string)null);
                });

            modelBuilder.Entity("Lesson23.Car", b =>
                {
                    b.HasOne("Lesson23.Driver", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("owner_fk");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Lesson23.Garage", b =>
                {
                    b.HasOne("Lesson23.Car", "Car")
                        .WithMany("Garages")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("car_fk");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Lesson23.ServiceStation", b =>
                {
                    b.HasOne("Lesson23.Mechanic", "Mechanic")
                        .WithMany("ServiceStations")
                        .HasForeignKey("MechanicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("mechanic_fk");

                    b.Navigation("Mechanic");
                });

            modelBuilder.Entity("Lesson23.Car", b =>
                {
                    b.Navigation("Garages");
                });

            modelBuilder.Entity("Lesson23.Driver", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Lesson23.Mechanic", b =>
                {
                    b.Navigation("ServiceStations");
                });
#pragma warning restore 612, 618
        }
    }
}
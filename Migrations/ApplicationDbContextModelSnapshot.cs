﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assessmente_de_empleabilidad.Data;

#nullable disable

namespace assessmente_de_empleabilidad.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin One",
                            Password = "adminpassword",
                            RoleId = 1,
                            UserName = "admin123"
                        });
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("reason");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<int?>("doctor_id")
                        .HasColumnType("int");

                    b.Property<int?>("patient_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("doctor_id");

                    b.HasIndex("patient_id");

                    b.ToTable("appointments", t =>
                        {
                            t.Property("doctor_id")
                                .HasColumnName("doctor_id1");

                            t.Property("patient_id")
                                .HasColumnName("patient_id1");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 15, 11, 45, 18, 167, DateTimeKind.Local).AddTicks(540),
                            Date = new DateTime(2024, 11, 20, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorId = 1,
                            PatientId = 1,
                            Reason = "Routine Checkup"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 15, 11, 45, 18, 167, DateTimeKind.Local).AddTicks(543),
                            Date = new DateTime(2024, 11, 21, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorId = 2,
                            PatientId = 2,
                            Reason = "Consultation"
                        });
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("availability");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int")
                        .HasColumnName("specialty_id");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = true,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            RoleId = 2,
                            SpecialtyId = 1,
                            UserName = "johndoe"
                        },
                        new
                        {
                            Id = 2,
                            Availability = false,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            RoleId = 2,
                            SpecialtyId = 2,
                            UserName = "janesmith"
                        });
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice.brown@example.com",
                            FirstName = "Alice",
                            LastName = "Brown",
                            RoleId = 3,
                            UserName = "alicebrown"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob.white@example.com",
                            FirstName = "Bob",
                            LastName = "White",
                            RoleId = 3,
                            UserName = "bobwhite"
                        });
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Doctor"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Patient"
                        });
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cardiology"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Neurology"
                        });
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Admin", b =>
                {
                    b.HasOne("assessmente_de_empleabilidad.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Appointment", b =>
                {
                    b.HasOne("assessmente_de_empleabilidad.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("doctor_id");

                    b.HasOne("assessmente_de_empleabilidad.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("patient_id");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Doctor", b =>
                {
                    b.HasOne("assessmente_de_empleabilidad.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assessmente_de_empleabilidad.Models.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("assessmente_de_empleabilidad.Models.Patient", b =>
                {
                    b.HasOne("assessmente_de_empleabilidad.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}

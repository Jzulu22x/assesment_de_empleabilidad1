using System;
using Microsoft.EntityFrameworkCore;
using assessmente_de_empleabilidad.Models;

namespace assessmente_de_empleabilidad.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed para Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Administrator" },
                new Role { Id = 2, Name = "Doctor" },
                new Role { Id = 3, Name = "Patient" }
            );

            // Seed para Specialities
            modelBuilder.Entity<Speciality>().HasData(
                new Speciality { Id = 1, Name = "Cardiology" },
                new Speciality { Id = 2, Name = "Neurology" }
            );

            // Seed para Admins
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    UserName = "admin123",
                    Password = "adminpassword",
                    Name = "Admin One",
                    RoleId = 1 // Administrator
                }
            );

            // Seed para Doctors
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Availability = true,
                    SpecialtyId = 1, // Cardiology
                    RoleId = 2, // Doctor
                    UserName = "johndoe",
                    Email = "john.doe@example.com"
                },
                new Doctor
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Availability = false,
                    SpecialtyId = 2, // Neurology
                    RoleId = 2, // Doctor
                    UserName = "janesmith",
                    Email = "jane.smith@example.com"
                }
            );

            // Seed para Patients
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    Id = 1,
                    FirstName = "Alice",
                    LastName = "Brown",
                    Email = "alice.brown@example.com",
                    UserName = "alicebrown",
                    RoleId = 3 // Patient
                },
                new Patient
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "White",
                    Email = "bob.white@example.com",
                    UserName = "bobwhite",
                    RoleId = 3 // Patient
                }
            );

            // Seed para Appointments
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    Date = new DateTime(2024, 11, 20, 10, 0, 0), // 20 Nov 2024, 10:00 AM
                    Reason = "Routine Checkup",
                    DoctorId = 1,
                    PatientId = 1,
                    CreatedAt = DateTime.Now
                },
                new Appointment
                {
                    Id = 2,
                    Date = new DateTime(2024, 11, 21, 14, 0, 0), // 21 Nov 2024, 2:00 PM
                    Reason = "Consultation",
                    DoctorId = 2,
                    PatientId = 2,
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}

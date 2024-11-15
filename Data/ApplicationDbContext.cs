using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Models;
using Microsoft.EntityFrameworkCore;

namespace assessmente_de_empleabilidad.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Admin> Admins {get; set;}
    public DbSet <Role> Roles {get; set;}
    public DbSet <Speciality> Specialities {get; set;}
    public DbSet <Patient> Patients {get; set;}
    public DbSet <Doctor> Doctors {get; set;}    
    public DbSet <Appointment> Appointments {get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
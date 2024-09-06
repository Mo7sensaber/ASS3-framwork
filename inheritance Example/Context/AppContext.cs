using inheritance_Example.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Example.Context
{
    internal class AppContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TPC
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=inheritance;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}

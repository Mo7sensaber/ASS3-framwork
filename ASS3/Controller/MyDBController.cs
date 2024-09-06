using ASS3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3.Controller
{
    internal class MyDBController : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=Demo;Trusted_Connection=True;TrustServerCertificate=True");
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseStudent>().HasKey(k => new { k.StudentID, k.CourseID });
        }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Department> departments { get; set; }


        public DbSet<Course> courses {  get; set; } 
        public DbSet<Student> students { get; set; }
    }
}

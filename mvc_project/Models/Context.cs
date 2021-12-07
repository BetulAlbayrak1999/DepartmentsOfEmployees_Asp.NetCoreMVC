using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Models
{
    public class Context : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<Admin>().ToTable("Admins");

        }
    }
}

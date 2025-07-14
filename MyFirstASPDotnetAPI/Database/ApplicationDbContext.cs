using Microsoft.EntityFrameworkCore;
using MyFirstASPDotnetAPI.Entity.model;
using System.Reflection.Metadata;

namespace MyFirstASPDotnetAPI.Database {
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options) {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsRequired();
        }
    }
}

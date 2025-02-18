using BES_Task.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BES_Task.Data.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Managers)
                .WithOne(m => m.Department)
                .HasForeignKey(m => m.DepartmentId);

            // Adding default admin and user
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", PasswordHash = BCrypt.Net.BCrypt.HashPassword("a12345"), Role = "Admin" },
                new User { Id = 2, Username = "user", PasswordHash = BCrypt.Net.BCrypt.HashPassword("u12345"), Role = "User" }
            );
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

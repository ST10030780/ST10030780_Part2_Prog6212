// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using ST10030780_Part2_Prog6212.Models; // Ensure this namespace matches your Claim model

namespace ST10030780_Part2_Prog6212.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Claim> Claims { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
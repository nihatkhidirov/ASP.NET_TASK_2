using Mentor_App_Task_2.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Mentor_App_Task_2.Data
{
    public class MentorAppDbContext : DbContext
    {
        public DbSet<Services> Services { get; set; }
        public DbSet <Pricing> Pricing { get; set; }

        public MentorAppDbContext(DbContextOptions options) : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pricing>().Property(p=>p.Price).HasColumnType("decimal(18,2");
        }
    }
}

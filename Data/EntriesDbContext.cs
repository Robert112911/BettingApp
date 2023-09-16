using BettingApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Match = BettingApp.Models.Match;

namespace BettingApp.Data
{
    public class EntriesDbContext : DbContext
    {
        public EntriesDbContext(DbContextOptions<EntriesDbContext> options) : base(options)
        {
               
        }

        public DbSet<Match> Matches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Match>()
                .Property(m => m.Cota1)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            modelBuilder.Entity<Match>()
                .Property(m => m.Cota2)
                .HasColumnType("decimal(18, 2)"); // Configure Cota2 if necessary

            modelBuilder.Entity<Match>()
                .Property(m => m.CotaX)
                .HasColumnType("decimal(18, 2)");
        }
    }
}

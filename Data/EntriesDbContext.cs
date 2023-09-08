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
    }
}

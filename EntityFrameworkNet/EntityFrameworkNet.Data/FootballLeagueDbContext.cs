using System;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkNet.Domain;

namespace EntityFrameworkNet.Data
{
    public class FootballLeagueDbContext : DbContext
    {
        public FootballLeagueDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Intitial Catalog=FootballLeague_EfCore");
            
        }
        // Link to tables
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}

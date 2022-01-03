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

        // Link to tables
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}

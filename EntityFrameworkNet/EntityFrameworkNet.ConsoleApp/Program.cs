using EntityFrameworkNet.Data;
using EntityFrameworkNet.Domain;
using System;

namespace EntityFrameworkNet.ConsoleApp
{
    class Program
    {
        private static FootballLeagueDbContext context = new FootballLeagueDbContext();

        static void Main(string[] args)
        {
            context.Leagues.Add(new League { Name = "League with Toronto FC Division" });
            context.SaveChangesAsync();


            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}

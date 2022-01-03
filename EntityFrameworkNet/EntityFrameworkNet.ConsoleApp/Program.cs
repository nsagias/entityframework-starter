using EntityFrameworkNet.Data;
using EntityFrameworkNet.Domain;
using System;
using System.Threading.Tasks;

namespace EntityFrameworkNet.ConsoleApp
{
    class Program
    {
        private static FootballLeagueDbContext context = new FootballLeagueDbContext();

        static async Task Main(string[] args)
        {
            var league = new League { Name = "League with Toronto FC Division" };
            await context.Leagues.AddAsync(league);
            await context.SaveChangesAsync();


            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}

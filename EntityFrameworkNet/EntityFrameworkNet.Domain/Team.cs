using System;
namespace EntityFrameworkNet.Domain
{
    public class Team
    {
        public Team()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        // foreign key
        public int LeagueId { get; set; }
        public virtual League League { get; set; }
     }
}

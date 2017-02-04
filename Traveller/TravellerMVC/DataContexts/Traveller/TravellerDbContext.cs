using System.Data.Entity;
using Traveller.Domain;

namespace TravellerMVC.DataContexts.Traveller
{
    public class TravellerDbContext : DbContext
    {
        public TravellerDbContext() : base("TravellerConnection")
        {
        }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Proposal> ProposedTrips { get; set; }
    }
}
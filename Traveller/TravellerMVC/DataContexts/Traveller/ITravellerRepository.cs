using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traveller.Domain;

namespace TravellerMVC.DataContexts.Traveller
{
    public interface ITravellerRepository : IDisposable
    {
        void SaveChanges();

        IEnumerable<Trip> Trips { get; }

        Trip FindTripById(int? id);

        IEnumerable<Proposal> ProposedTrips { get; }

        Trip AddTrip(Trip trip);

        void UpdateTrip(Trip trip);

        Trip RemoveTrip(Trip trip);
    }
}
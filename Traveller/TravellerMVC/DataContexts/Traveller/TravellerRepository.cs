using System;
using System.Collections.Generic;
using System.Data.Entity;
using Traveller.Domain;

namespace TravellerMVC.DataContexts.Traveller
{
    public class TravellerRepository : ITravellerRepository
    {
        private bool disposed = false;
        private TravellerDbContext _context;

        public TravellerRepository(TravellerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Trip> Trips
        {
            get
            {
                return _context.Trips;
            }
        }

        public IEnumerable<Proposal> ProposedTrips
        {
            get
            {
                return _context.ProposedTrips;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Trip FindTripById(int? id)
        {
            return _context.Trips.Find(id);
        }

        public Trip AddTrip(Trip trip)
        {
            return _context.Trips.Add(trip);
        }

        public void UpdateTrip(Trip trip)
        {
            _context.Entry(trip).State = EntityState.Modified;
        }

        public Trip RemoveTrip(Trip trip)
        {
            return _context.Trips.Remove(trip);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
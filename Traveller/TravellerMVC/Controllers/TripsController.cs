using System.Linq;
using System.Net;
using System.Web.Mvc;
using Traveller.Domain;
using TravellerMVC.DataContexts.Traveller;

namespace TravellerMVC.Controllers
{
    public class TripsController : Controller
    {
        private ITravellerRepository _repo;

        public TripsController()
        {
            _repo = new TravellerRepository(new TravellerDbContext());
        }

        public TripsController(ITravellerRepository repository)
        {
            _repo = repository;
        }

        // GET: Trips
        public ActionResult Index()
        {
            return View(_repo.Trips.ToList());
        }

        // GET: Trips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = _repo.FindTripById(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // GET: Trips/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TripId,Name,Description,StartDate,EndDate,TripType,Rating")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTrip(trip);
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trip);
        }

        // GET: Trips/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = _repo.FindTripById(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // POST: Trips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TripId,Name,Description,StartDate,EndDate,TripType,Rating")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateTrip(trip);
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trip);
        }

        // GET: Trips/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = _repo.FindTripById(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // POST: Trips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trip trip = _repo.FindTripById(id);
            _repo.RemoveTrip(trip);
            _repo.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

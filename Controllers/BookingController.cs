using HotelBooking.Data;
using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HotelBooking.Controllers
{
    public class BookingController : Controller
    {
        static Booking lastBooking = new Booking();

        // GET: Booking
        public ActionResult Index(int? RoomId)
        {
            lastBooking.Room = db.Rooms.Find(RoomId);
            return View(lastBooking); 
        }

        private CustomersContext dbcust = new CustomersContext();

        // GET: Customers/Create
        public ActionResult CreateCustomer()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer([Bind(Include = "Id,Firstname,Lastname,DOB,Phone,Email,Address")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                dbcust.Customers.Add(customer);
                dbcust.SaveChanges();
                lastBooking.Customer = customer;
                return RedirectToAction("Rooms", "Booking");
            }

            return View(customer);
        }

        private ReservationsContext dbres = new ReservationsContext();

        // GET: Reservations/Create
        public ActionResult Reserve()
        {
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reserve([Bind(Include = "Id,CheckIn,CheckOut,NumberOfAdultGuests,NumberOfChildGuests,NumberOfRooms,ExtendedCheckOut")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                dbres.Reservations.Add(reservation);
                dbres.SaveChanges();
                lastBooking.Reservation = reservation;
                return RedirectToAction("CreateCustomer");
            }

            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public ActionResult EditReservation(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = dbres.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditReservation([Bind(Include = "Id,CheckIn,CheckOut,NumberOfAdultGuests,NumberOfChildGuests,NumberOfRooms,ExtendedCheckOut,RoomID,CustomerID")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                dbres.Entry(reservation).State = EntityState.Modified;
                dbres.SaveChanges();
                return RedirectToAction("Index", reservation);
            }
            return View(reservation);
        }

        private RoomContext db = new RoomContext();

        // GET: Rooms
        public ActionResult Rooms()
        {
            return View(db.Rooms.ToList());
        }
    }
}
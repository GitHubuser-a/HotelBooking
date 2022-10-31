using HotelBooking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HotelBooking.Models
{
    public class Booking
    {
        public Reservation Reservation { get; set; }
        public Room Room { get; set; }
        public Customer Customer { get; set; }

        public Booking()
        {
            Reservation = new Reservation();
            Room = new Room();
            Customer = new Customer();
        }


        
    }
}
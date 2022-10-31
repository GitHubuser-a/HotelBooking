using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }

        [Required]
        public int NumberOfAdultGuests { get; set; }
        [Required]
        public int NumberOfChildGuests { get; set; }
        [Required]
        public int NumberOfRooms { get; set; }
        public int ExtendedCheckOut { get; set; }
        public int RoomID { get; set; }
        public int CustomerID { get; set; }
        public TimeSpan Duration()
        {
            return CheckOut.Date - CheckIn.Date;
        }
        public Reservation()
        {
            
        }
        public Reservation(int id, DateTime checkIn, DateTime checkOut, int numberOfAdultGuests, int numberOfChildGuests, int numberOfRooms, int extendedCheckOut, int roomID, int customerID)
        {
            Id = id;
            CheckIn = checkIn;
            CheckOut = checkOut;
            NumberOfAdultGuests = numberOfAdultGuests;
            NumberOfChildGuests = numberOfChildGuests;
            NumberOfRooms = numberOfRooms;
            ExtendedCheckOut = extendedCheckOut;
            RoomID = roomID;
            CustomerID = customerID;
        }
    }


}
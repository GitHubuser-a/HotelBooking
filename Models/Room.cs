using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class Room
    {
        public int ID { get; set; }
        public bool AC { get; set; }
        public bool PrivatePool { get; set; }
        public bool King { get; set; }
        public string Image { get; set; }
        public Room()
        {
            ID = 1;
            AC = false;
            PrivatePool = false;
            King = false;
        }
        public Room(int iD, bool aC, bool privatePool, bool king, string image)
        {
            ID = iD;
            AC = aC;
            PrivatePool = privatePool;
            King = king;
            Image = image;
        }

        public double RoomRent()
        {
            double BaseCharge = 100;
            var ACCharge = AC ? 50.0 : 0.0;
            var PoolCharge = PrivatePool ? 100.0 : 0.0;
            var KingCharge = King ? 20.0 : 0.0;
            double RoomRent = BaseCharge;

            RoomRent += ACCharge + PoolCharge + KingCharge;
            return RoomRent;
        }
        public double StateTax()
        {
            return RoomRent() * 13 / 100;
        }
        public double TourismTax()
        {
            return RoomRent() * 7 / 100;
        }
    }
}
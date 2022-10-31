using HotelBooking.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class RoomsInitializer : DropCreateDatabaseAlways<RoomContext>
    {
        protected override void Seed(RoomContext context)
        {
            context.Rooms.Add(new Room
            {
                ID = 1,
                AC = false,
                PrivatePool = false,
                King = true,
                Image = "https://www.thespruce.com/thmb/Afg3IVBq0tV-7DHBME5woSNCZxQ=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/put-together-a-perfect-guest-room-1976987-hero-223e3e8f697e4b13b62ad4fe898d492d.jpg"
            });

            context.Rooms.Add(new Room
            {
                ID = 2,
                AC = true,
                PrivatePool = false,
                King = true,
                Image = "https://images.unsplash.com/photo-1611892440504-42a792e24d32?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8aG90ZWwlMjByb29tfGVufDB8fDB8fA%3D%3D&w=1000&q=80"
            });

            context.Rooms.Add(new Room
            {
                ID = 3,
                AC = true,
                PrivatePool = true,
                King = true,
                Image = "https://images.trvl-media.com/hotels/5000000/4600000/4595700/4595698/fe8a2351.jpg?impolicy=fcrop&w=670&h=385&p=1&q=medium"
            });

            context.Rooms.Add(new Room
            {
                ID = 4,
                AC = true,
                PrivatePool = true,
                King = true,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2y30DKt8dW1cxrCiCq7nCbdZB_d_9W34HLwDj-GCDpA&s"
            });
            context.Rooms.Add(new Room
            {
                ID = 5,
                AC = true,
                PrivatePool = false,
                King = true,
                Image = "https://s7d2.scene7.com/is/image/ritzcarlton/pnrqz-king-50661983?$XlargeViewport100pct$"
            });
        }
    }
}
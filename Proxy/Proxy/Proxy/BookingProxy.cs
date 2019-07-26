using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class BookingProxy : IHotelPage
    {
        private Booking booking;
        public int Id { get; set; }
        public int MainPhoto { get; set; }

        public BookingProxy(int id)
        {
            Id = id;
        }

        public void HotelView()
        {
            if (booking == null)
            {
                booking = new Booking(Id);
            }
            booking.HotelView();
        }
    }
}

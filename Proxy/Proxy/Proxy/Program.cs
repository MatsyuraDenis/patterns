using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Booking booking = new Booking(1);
            BookingProxy bookingProxy = new BookingProxy(1);
            bookingProxy.HotelView();
            Console.ReadKey();
        }
    }
}

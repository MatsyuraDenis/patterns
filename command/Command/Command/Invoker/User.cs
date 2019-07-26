using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class User
    {
        public IComand Booking { get; set; }

        public User(IComand booking)
        {
            Booking = booking;
        }

        public void Book()
        {
            Booking.Book();
        }

        public void Unbook()
        {
            Booking.Unbook();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class HotelRoom : Room
    {
        public override void Book()
        {
            Console.WriteLine("Room is booked, hidden from seach engine");
        }

        public override void GetOrder()
        {
            Console.WriteLine("Return new order");
        }
    }
}

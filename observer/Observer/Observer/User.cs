using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class User : IObserver
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(Hotel hotel)
        {
            if(hotel.IsFree)
                Console.WriteLine("Dear {0}, hotel№{1} has free room now!", Name, hotel.Id);

            if (!hotel.IsFree)
                Console.WriteLine("Dear {0}, in hotel№{1} last free room was booked", Name, hotel.Id);
        }
    }
}

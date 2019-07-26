using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Room> rooms = new List<Room>(); 
            for (int i = 0; i < 10; i++)
            {
                rooms.Add(new Room(random.Next(1,4), 120));
            }

            Hotel hotel = new Hotel(rooms);

            Console.WriteLine(hotel.GetCapacity());
            Console.WriteLine(hotel.GetTotalPrice());

            Console.ReadKey();
        }
    }
}

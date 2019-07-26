using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            List<Order> orders = new List<Order>();

            Room common = new CommonRoom(4, 120);
            Room standart = new StandartRoom(4, 120);

            hotel.AddRoom(common);
            hotel.AddRoom(standart);

            foreach (var room in hotel.Rooms)
            {
                Console.WriteLine(room);
            }
            Console.ReadKey();

        }
    }
}

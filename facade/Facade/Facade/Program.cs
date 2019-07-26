using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aplianses> aplianseses = new List<Aplianses>
            {
                new Aplianses("Oven", 12),
                new Aplianses("Fridge", 10)
            };

            List<Facilities> facilitieses = new List<Facilities>
            {
                new Facilities("Shower", 3),
                new Facilities("Hot water", 1),
                new Facilities("Wi Fi", 5)
            };

            Room room = new Room(aplianseses, facilitieses);

            room.GetOrder();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IRoom room = new NormalRoom(100, 2);
            Ship ship = new Ship(14, 5, 60);

            ShipAdapter adapter = new ShipAdapter(ship);

            Console.WriteLine((double)(adapter.GetBookPrice()));
            Console.ReadKey();
        }
    }
}

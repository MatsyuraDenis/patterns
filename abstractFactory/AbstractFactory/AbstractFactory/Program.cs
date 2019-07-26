using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostel = new Hotel(new HostelFactory());

            Console.WriteLine("Hostel: ");
            Console.WriteLine("  " + hostel.Nutrition);
            Console.WriteLine("  " + hostel.Type);

            var elite = new Hotel(new EliteHotelFactory());
            Console.WriteLine();
            Console.WriteLine("Elite hotel:");
            Console.WriteLine("  " + elite.Nutrition);
            Console.WriteLine("  " + elite.Type);

            Console.ReadKey();

        }
    }
}

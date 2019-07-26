using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Booking booking = new Booking(1,1);

            booking.StartRent();
            Days();
            booking.EndRent();



            Console.ReadKey();
        }


        static void Days()
        {
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("Day {0}", i);
                Thread.Sleep(200);
            }
        }
    }
}

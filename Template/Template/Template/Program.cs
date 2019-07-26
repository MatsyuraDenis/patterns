using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Room hostel = new HostelRoom();
            Room hotel = new HotelRoom();


            hotel.Template();
            hostel.Template();


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisit visit = new HtmlVisitor();

            Room hotel = new HotelRoom(300, 1, "hotel");
            Room hostel = new HostelRoom(120, 4, "hostel");

            Console.WriteLine(hostel.Updateformat(visit));
            Console.WriteLine(hotel.Updateformat(visit));

            Console.ReadKey();
        }
    }
}

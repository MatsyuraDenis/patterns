using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class HostelRoom : Room
    {
        public override void Book()
        {
            Console.WriteLine("Booked 1 bed, room have 2 more and not hidden from search engine");
        }

        public override void GetOrder()
        {
            Console.WriteLine("Return new order");
        }
    }
}

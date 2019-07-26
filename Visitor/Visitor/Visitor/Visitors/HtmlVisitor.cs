using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class HtmlVisitor : IVisit
    {
        public string Visit(HotelRoom room)
        {
            string str = string.Format("<p>Price: {0}, Capacity: {1}, Type: {2}</p>", room.Price, room.Capacity, room.Type);
            return str;
        }

        public string Visit(HostelRoom room)
        {
            string str = string.Format("<p>Price: {0}, Capacity: {1}, Type: {2}</p>", room.Price, room.Capacity, room.Type);
            return str;
        }
    }
}

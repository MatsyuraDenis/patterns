using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class HotelRoom : Room
    {
        public HotelRoom(int price, int capacity, string type) : base( price, capacity, type)
        {
        }

        public override string Updateformat(IVisit visit)
        {
            return visit.Visit(this);
        }
    }
}

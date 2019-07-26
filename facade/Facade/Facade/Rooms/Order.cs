using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Order
    {
        public Room Room { get; set; }

        public Order(Room room)
        {
            Room = room;
        }
    }
}

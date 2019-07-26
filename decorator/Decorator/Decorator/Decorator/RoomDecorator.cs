using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class RoomDecorator : IOrder
    {
        public Room Room { get; set; }

        protected RoomDecorator(Room room)
        {
            Room = room;
        }

        public abstract double GetCost();
    }
}

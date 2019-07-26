using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositor
{
    class Room : IComponent
    {
        public int Capacity { get; set; }
        public int Price { get; set; }

        public Room(int capacity, int price)
        {
            Capacity = capacity;
            Price = price;
        }

        public int GetCapacity()
        {
            return Capacity;
        }

        public int GetTotalPrice()
        {
            return Price * Capacity;
        }
    }
}

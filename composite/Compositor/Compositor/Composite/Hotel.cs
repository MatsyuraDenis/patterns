using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositor
{
    class Hotel : IComponent
    {
        public List<Room> Rooms;

        public Hotel(List<Room> rooms)
        {
            Rooms = rooms;
        }

        public int GetCapacity()
        {
            int capacity = 0;
            foreach (var room in Rooms)
            {
                capacity += room.GetCapacity();
            }

            return capacity;
        }

        public int GetTotalPrice()
        {
            int price = 0;
            foreach (var room in Rooms)
            {
                price += room.GetTotalPrice();
            }

            return price;
        }
    }
}

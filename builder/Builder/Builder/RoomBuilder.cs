using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class RoomBuilder
    {
        private Room room;

        public RoomBuilder()
        {
            room = new Room();
        }

        public RoomBuilder setCapacity(int capacity)
        {
            room.Capacity = capacity;
            return this;
        }

        public RoomBuilder setPrice(int price)
        {
            room.Price = price;
            return this;
        }

        public RoomBuilder setComforts(params Comforts[] comfortses)
        {
            foreach (var comfort in comfortses)
            {
                room.Comfortses.Add(comfort);
            }

            return this;
        }

        public Room Build()
        {
            return room;
        }
    }
}

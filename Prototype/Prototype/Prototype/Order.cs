using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    class Order
    {
        public Room Room { get; set; }
        public string UserName { get; set; }

        public Order(Room room, string userName)
        {
            Room = room;
            UserName = userName;
        }

        public Order Copy()
        {
            Room room = new Room(this.Room.HotelId, this.Room.Price);
            return new Order(room, UserName);
        }
    }
}

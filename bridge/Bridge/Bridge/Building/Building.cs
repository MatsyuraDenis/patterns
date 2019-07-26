using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Building
    {
        public List<Room> Rooms { get; set; }

        public Building()
        {
            Rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void BookRoom(int roomId)
        {
            Order order;
            if (Rooms[roomId].isFree)
                order = Rooms[roomId].ToBook();
        }
    }
}

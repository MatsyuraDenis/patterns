using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class RoomFactory
    {
        public Hashtable flyweights = new Hashtable();

        public IRoom CreateRoom(string name)
        {
            Room room = (Room) flyweights[name];

            if (room == null)
            {
                room = new Room(name);
                flyweights.Add(name, room);
                Console.WriteLine("create new {0} room", name);
            }

            return room;
        }
    }
}

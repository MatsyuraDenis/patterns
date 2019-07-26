using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class RoomList : IRoomIterator, IRoomNumerable
    {
        List<Room> Rooms = new List<Room>();
        private int current = -1;

        public Room this[int index]
        {
            get { return Rooms[index]; }
            set { Rooms.Add(value); }
        }

        Room IRoomIterator.Current => Rooms[current];

        public IRoomIterator GetIterator()
        {
            return this as IRoomIterator;
        }

        void IRoomIterator.Reset()
        {
            current = -1;
        }

        bool IRoomIterator.HasNext()
        {
            current++;
            return current<Rooms.Count;
        }
    }
}

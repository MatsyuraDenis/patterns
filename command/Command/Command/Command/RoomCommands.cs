using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class RoomCommands : IComand
    {
        public Room Room { get; set; }

        public RoomCommands(Room room)
        {
            this.Room = room;
        }

        public void Book()
        {
            Room.BookRoom();
        }

        public void Unbook()
        {
            Room.UnbookRoom();
        }
    }
}

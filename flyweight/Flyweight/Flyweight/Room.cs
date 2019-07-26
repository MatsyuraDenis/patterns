using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Room : IRoom
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public bool isFree { get; protected set; }
        public int Id { get; set; }
        protected static int Idi { get; set; } = 0;

        public Room(string type)
        {
            Type = type;
            isFree = true;
            Console.WriteLine(".....new {0} room.....", Type);
        }

        public void BookRoom()
        {
            Console.WriteLine("room booked");
            isFree = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Room№ {0}, price: {1}", Id, Price);
        }
    }
}

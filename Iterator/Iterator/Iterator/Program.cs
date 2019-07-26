using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomList roomList = new RoomList();
            roomList[0] = new Room("room 1");
            roomList[1] = new Room("room 1");
            roomList[2] = new Room("room 2");
            roomList[3] = new Room("room 3");
            roomList[4] = new Room("room 4");
            roomList[5] = new Room("room 5");

            IRoomIterator iterator = roomList.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current.Name);
            }
            iterator.Reset();

            Console.ReadKey();
        }
    }
}

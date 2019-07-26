using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            RoomHistory history = new RoomHistory(new Stack<RoomMemento>());

            room.RentRoom(1);
            RoomMemento memento = room.SaveState();
            history.Mementos.Push(memento);
            room.RentInfo();


            room.RentRoom(3);
            RoomMemento memento1 = room.SaveState();
            history.Mementos.Push(memento1);
            room.RentInfo();


            room.RentRoom(5);
            RoomMemento memento2 = room.SaveState();
            history.Mementos.Push(memento2);
            room.RentInfo();

            room.SetMemeto(memento);
            room.RentInfo();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomFactory factory = new RoomFactory();
            string Single = "single";
            string Double = "double";

            Room room = (Room)factory.CreateRoom(Single);
            room.Id = 1;
            room.Price = 120;
            Room room1 = (Room)factory.CreateRoom(Double);
            room1.Id = 2;
            room1.Price = 130;
            Room room2 = (Room)factory.CreateRoom(Single);
            room2.Price = 140;
            Room room3 = (Room)factory.CreateRoom(Double);
            room3.Price = 150;
            Room room4 = (Room)factory.CreateRoom(Single);
            room4.Price = 160;


            room.ShowInfo();
            room1.ShowInfo();
            room2.ShowInfo();
            room3.ShowInfo();
            room4.ShowInfo();
            Console.ReadKey();
        }
    }
}

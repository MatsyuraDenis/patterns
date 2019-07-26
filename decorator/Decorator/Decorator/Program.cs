using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Room single = new SingleRoom(120);
            Room doubleRoom = new DoubleRoom(200);

            RoomDecorator singleBussinesRoom = new BussinesRoomDecorator(single);
            RoomDecorator doubleBussinesRoom = new BussinesRoomDecorator(doubleRoom);

            Console.WriteLine("Single bussines room: {0}", singleBussinesRoom.GetCost());
            Console.WriteLine("Double bussines room: {0}", doubleBussinesRoom.GetCost());

            RoomDecorator standartSingle = new StandartRoomDecorator(single);
            RoomDecorator standartDouble = new StandartRoomDecorator(doubleRoom);

            Console.WriteLine("Single standart room: {0}", standartSingle.GetCost());
            Console.WriteLine("Double standart room: {0}", standartDouble.GetCost());

            Console.ReadKey();
        }
    }
}

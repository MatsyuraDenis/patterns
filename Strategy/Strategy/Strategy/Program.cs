using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();

            for (int i = 0; i < 15; i++)
            {
                if (i % 3 == 0)
                    rooms.Add(new Room(Type.Bussines));

                if (i % 3 == 1)
                    rooms.Add(new Room(Type.Standart));

                if (i % 3 == 2)
                    rooms.Add(new Room(Type.Cheap));
            }

            Hotel hotel = new Hotel(rooms);

            hotel.SetStrategy(new BussinesRoomsStrategy());
            List<Room> bussines = hotel.GetStrategyRooms();

            hotel.SetStrategy(new StandartRoomsStrategy());
            List<Room> standart = hotel.GetStrategyRooms();

            hotel.SetStrategy(new CheapRoomsStrategy());
            List<Room> cheap = hotel.GetStrategyRooms();


            Console.WriteLine("Bussines rooms:");
            foreach (var room in bussines)
            {
                Console.WriteLine(room.Id);
                //Console.WriteLine(room.Type.ToString());
            }

            Console.WriteLine("Standart rooms:");
            foreach (var room in standart)
            {
                Console.WriteLine(room.Id);
                //Console.WriteLine(room.Type.ToString());
            }

            Console.WriteLine("Cheap rooms:");
            foreach (var room in cheap)
            {
                Console.WriteLine(room.Id);
                //Console.WriteLine(room.Type.ToString());
            }


            Console.ReadKey();
        }
    }
}

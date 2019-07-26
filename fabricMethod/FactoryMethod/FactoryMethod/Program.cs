using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> Rooms = new List<Room>();
            HostelRoomFactory hostelRoomFactory = new HostelRoomFactory();
            HotelRoomFactory hotelRoomFactory = new HotelRoomFactory();
            for (int i = 0; i < 5; i++)
            {
                if(i % 2 == 0)
                Rooms.Add(hostelRoomFactory.CreateRoom(2, i * 100));
                else
                    Rooms.Add(hostelRoomFactory.CreateRoom(1, i * 50));

            }

            for (int i = 0; i < 5; i++)
            {
                Rooms.Add(hotelRoomFactory.CreateRoom((byte)(i+3), i * 100));
            }

            foreach (var room in Rooms)
            {
                Console.WriteLine(room);
            }

            Console.ReadKey();
        }
    }
}

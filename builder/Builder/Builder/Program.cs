using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomBuilder roomBuilder = new RoomBuilder();
            Room room = roomBuilder
                .setCapacity(4)
                .setPrice(300)
                .setComforts(Comforts.HotWater, Comforts.Shower, Comforts.WiFi)
                .Build();

            Console.WriteLine(room.Info());


            Console.ReadKey();
        }
    }
}

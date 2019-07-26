using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    class Room
    {
        public int HotelId { get; set; }
        public int Price { get; set; }

        public Room(int hotelId, int price)
        {
            HotelId = hotelId;
            Price = price;
        }
    }
}

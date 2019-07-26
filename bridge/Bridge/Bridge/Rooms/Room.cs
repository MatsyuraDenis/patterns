using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Room
    {
        public Room(int capacity, int price)
        {
            Capacity = capacity;
            Price = price;
            isFree = true;
        }

        public int Capacity { get; set; }
        public int Price { get; set; }
        public bool isFree { get; set; }

        public abstract Order ToBook();
    }
}

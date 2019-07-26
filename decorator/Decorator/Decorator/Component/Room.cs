using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Room : IOrder
    {


        public int Price { get; set; }
        public int Capacity { get; set; }
        public abstract double GetCost();

        public Room(int price)
        {
            Price = price;
        }
    }
}

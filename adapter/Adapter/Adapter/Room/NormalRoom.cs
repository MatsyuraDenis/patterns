using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class NormalRoom : IRoom
    {
        public int Price { get; set; }
        public int Capacity { get; set; }
        public bool isFree { get; set; }

        public NormalRoom(int price, int capacity)
        {
            Price = price;
            Capacity = capacity;
        }

        public double GetBookPrice()
        {
            return Price;
        }
    }
}

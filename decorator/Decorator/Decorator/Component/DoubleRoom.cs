using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DoubleRoom : Room
    {
        public DoubleRoom(int price) : base(price)
        {
            Capacity = 2;
        }

        public override double GetCost()
        {
            return Price;
        }
    }
}

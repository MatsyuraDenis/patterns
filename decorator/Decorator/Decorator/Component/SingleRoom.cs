using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SingleRoom : Room
    {
        public SingleRoom(int price) : base(price)
        {
            Capacity = 1;
        }

        public override double GetCost()
        {
            return Price;
        }
    }
}

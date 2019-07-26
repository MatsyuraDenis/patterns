using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class User
    {
        public Order Order { get; protected set; }

        public void AddOrder(Order order)
        {
            Order = order;
        }
    }
}

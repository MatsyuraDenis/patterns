using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Order
    {
        private static int ID { get; set; } = 0;
        public int Id { get; set; }

        public Order()
        {
            ID++;
            Id = ID;
        }
    }
}

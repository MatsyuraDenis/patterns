using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Room
    {
        private static int IdSimulator { get; set; } = 0;
        public int Id { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }

        protected Room(int price, int capacity, string type)
        {
            Id = IdSimulator++;
            Price = price;
            Capacity = capacity;
            Type = type;
        }

        public abstract string Updateformat(IVisit visit);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class StandartRoom : Room
    {
        public StandartRoom(int capacity, int price) : base(capacity, price) { }

        public override Order ToBook()
        {
            isFree = false;
            return new Order();;
        }

        public override string ToString()
        {
            return "Standart";
        }
    }
}

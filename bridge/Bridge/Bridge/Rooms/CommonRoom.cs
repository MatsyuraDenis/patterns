using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CommonRoom : Room
    {
        private int FreePlaces { get; set; }

        public CommonRoom(int capacity, int price) : base(capacity, price)
        {
            FreePlaces = capacity;
        }

        public override Order ToBook()
        {
                ChangeFreeStatus();
                return new Order();
        }

        private void ChangeFreeStatus()
        {
            FreePlaces -= 1;
            if (FreePlaces == 0)
                isFree = false;
        }

        public override string ToString()
        {
            return "Common";
        }
    }
}

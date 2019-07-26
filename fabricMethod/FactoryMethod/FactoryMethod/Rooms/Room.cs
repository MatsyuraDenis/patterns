using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Room
    {
        public int Id { get; protected set; }
        protected static int j { get; set; } = 0;
        public byte NumberOfPlaces { get; set; }
        public bool HaveFreePlaces { get; set; }
        public int Price { get; set; }

        public Room() { }

        public Room(byte numberOfPlaces, int price)
        {
            NumberOfPlaces = numberOfPlaces;
            Price = price;
            if (numberOfPlaces > 0)
                HaveFreePlaces = true;
            j++;
            Id = j;
        }
    }
}

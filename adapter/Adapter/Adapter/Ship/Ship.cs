using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Ship
    {
        public int CountryTax { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }

        public Ship(int countryTax, int distance, int price)
        {
            CountryTax = countryTax;
            Distance = distance;
            Price = price;
        }
    }
}

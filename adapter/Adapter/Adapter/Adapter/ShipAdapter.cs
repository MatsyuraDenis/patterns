using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ShipAdapter : IRoom
    {
        private Ship Ship { get; set; }

        public ShipAdapter(Ship ship)
        {
            this.Ship = ship;
        }
        public double GetBookPrice()
        {
            Console.WriteLine((double)this.Ship.CountryTax / 100 + 1);
            Console.WriteLine((double)this.Ship.Distance / 100 + 1);
            Console.WriteLine((double)this.Ship.Price);
            return (this.Ship.Price * ((double)this.Ship.CountryTax / 100 + 1) * ((double)this.Ship.Distance/100 + 1));
        }
    }
}

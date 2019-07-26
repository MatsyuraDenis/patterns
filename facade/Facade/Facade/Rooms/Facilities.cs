using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facilities
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Facilities(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} cost is {1}", Name, Price);
        }
    }
}

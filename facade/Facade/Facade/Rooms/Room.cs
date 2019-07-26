using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Room
    {
        public List<Aplianses> Aplianseses { get; set; } 
        public List<Facilities> Facilitieses { get; set; } 

        public Room()
        {
            Aplianseses = new List<Aplianses>();
            Facilitieses = new List<Facilities>();
        }

        public Room(List<Aplianses> aplianseses, List<Facilities> facilitieses)
        {
            Facilitieses = facilitieses;
            Aplianseses = aplianseses;
        }

        public void GetOrder()
        {
            int totalPrice = 100;
            foreach (var apliansese in Aplianseses)
            {
                totalPrice += apliansese.Price;
            }

            foreach (var facilitiese in Facilitieses)
            {
                totalPrice += facilitiese.Price;
            }
            Console.WriteLine("Total price: {0}", totalPrice);

            foreach (var apliansese in Aplianseses)
            {
                apliansese.ShowInfo();
            }

            foreach (var facilitiese in Facilitieses)
            {
                facilitiese.ShowInfo();
            }
        }

    }
}

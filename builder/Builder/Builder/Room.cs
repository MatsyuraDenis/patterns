using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Room
    {
        public int Capacity { get; set; }
        public int Price { get; set; }
        public List<Comforts> Comfortses { get; set; }

        public Room()
        {
            Comfortses = new List<Comforts>();
        }

        public string Info()
        {
            string info = string.Format("Capacity: {0}\n Price: {1}\n Comforts: ", Capacity, Price);



            if (Comfortses.Count == 0)
            {
                info += "No comforts :(";
            }
            else
            {
                info += "\n";
                foreach (var comfortse in Comfortses)
                {
                    info += string.Format("\t{0}\n",comfortse.ToString());
                }
            }

            return info;
        }
    }
}

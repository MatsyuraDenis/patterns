using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class HostelRoom : Room
    {
        public int FreePlaces { get; set; }

        public HostelRoom(byte numberOfPlaces, int price) : base(numberOfPlaces,price)
        {
            FreePlaces = numberOfPlaces;
        }

        public void BookAPlace()
        {
            if (HaveFreePlaces)
                FreePlaces -= 1;

            if (FreePlaces == 0)
            {
                HaveFreePlaces = false;
            }
        }

        public void UnBookAPlace()
        {
            if (FreePlaces >= NumberOfPlaces)
                throw new ArgumentException();

            if (FreePlaces == 0)
            {
                HaveFreePlaces = true;
            }

            FreePlaces += 1;
        }

        public override string ToString()
        {
            return string.Format(
                "Hostel room: \nId: {0}, Number of places: {1}, Price: {2}, FreePlaces: {3}"
                , Id, NumberOfPlaces, Price, FreePlaces);
        }
    }
}

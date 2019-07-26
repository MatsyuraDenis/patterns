using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HotelRoom : Room
    {
        public HotelRoom(byte numberOfPlaces, int price) : base(numberOfPlaces, price)
        {
        }

        public void BookRoom()
        {
            HaveFreePlaces = false;
        }

        public void UnbookRoom()
        {
            HaveFreePlaces = true;
        }
        public override string ToString()
        {
            return string.Format(
                "Hotel room: \nId: {0}, Number of places: {1}, Price: {2}"
                , Id, NumberOfPlaces, Price);
        }
    }
}

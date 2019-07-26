using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Booking : IHotelPage
    {
        public int Id { get; set; }
        public int MainPhoto { get; set; }

        public Booking(int id)
        {
            Id = id;
            LoadHotel();
        }

        public void HotelView()
        {
            Console.WriteLine("Page redirect to full hotel info!");
        }

        public void LoadHotel()
        {
            Console.WriteLine("Hotel info loaded succesfull");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Room
    {
        private DateTime startBooking;
        private DateTime endBooking;

        public Room() { }

        public void RentRoom(int days)
        {
            startBooking = DateTime.Now;
            endBooking = DateTime.Now.AddDays(days);
        }

        public void RentInfo()
        {
            Console.WriteLine("Start of rent: {0}", startBooking.ToShortDateString());
            Console.WriteLine("End of rent: {0}", endBooking.ToShortDateString());
        }

        public RoomMemento SaveState()
        {
            return new RoomMemento(startBooking, endBooking);
        }

        public void SetMemeto(RoomMemento memento)
        {
            startBooking = memento.StartBooking;
            endBooking = memento.EndBooking;
        }
    }
}

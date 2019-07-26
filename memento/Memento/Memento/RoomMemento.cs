using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class RoomMemento
    {
        public DateTime StartBooking { get; private set; }
        public DateTime EndBooking { get; private set; }

        public RoomMemento(DateTime startBooking, DateTime endBooking)
        {
            StartBooking = startBooking;
            EndBooking = endBooking;
        }
    }
}

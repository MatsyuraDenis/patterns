using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Booking
    {
        public IState State { get; private set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }

        public Booking(int userId, int roomId)
        {
            UserId = userId;
            RoomId = roomId;
            State = new WaitingState();
        }

        public void StartRent()
        {
            State = new ActiveState();
            State.ShowStatus();
        }

        public void EndRent()
        {
            State = new EndState();
            State.ShowStatus();
        }
    }
}

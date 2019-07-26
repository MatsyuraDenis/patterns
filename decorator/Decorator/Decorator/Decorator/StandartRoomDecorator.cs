using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class StandartRoomDecorator : RoomDecorator
    {
        public StandartRoomDecorator(Room room) : base(room)
        {
        }

        public override double GetCost()
        {
            return Room.GetCost() * 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BussinesRoomDecorator : RoomDecorator
    {
        public BussinesRoomDecorator(Room room):base(room)
        {
            
        }

        public override double GetCost()
        {
            return Room.GetCost() * 3;
        }
    }
}

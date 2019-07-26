using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    class HostelRoomFactory : RoomFactory
    {
        public override Room CreateRoom(byte numberOfPlaces, int Price)
        {
            return new HostelRoom(numberOfPlaces, Price);
        }
    }
}

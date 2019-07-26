using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface IStrategy
    {
        List<Room> Algorithm(List<Room> rooms);
    }

    class BussinesRoomsStrategy : IStrategy
    {
        public List<Room> Algorithm(List<Room> rooms)
        {
            List<Room> bussinesRooms = new List<Room>();

            foreach (var room in rooms)
            {
                if(room.Type == Type.Bussines)
                    bussinesRooms.Add(room);
            }

            return bussinesRooms;
        }
    }

    class StandartRoomsStrategy : IStrategy
    {
        public List<Room> Algorithm(List<Room> rooms)
        {
            List<Room> standartRooms = new List<Room>();

            foreach (var room in rooms)
            {
                if (room.Type == Type.Standart)
                    standartRooms.Add(room);
            }

            return standartRooms;
        }
    }

    class CheapRoomsStrategy : IStrategy
    {
        public List<Room> Algorithm(List<Room> rooms)
        {
            List<Room> cheapRooms = new List<Room>();

            foreach (var room in rooms)
            {
                if (room.Type == Type.Cheap)
                    cheapRooms.Add(room);
            }

            return cheapRooms;
        }
    }
}

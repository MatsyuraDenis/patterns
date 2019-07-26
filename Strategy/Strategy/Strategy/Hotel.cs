using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Hotel
    {
        public List<Room> Rooms { get; set; }
        private IStrategy strategy;


        public Hotel(List<Room> rooms)
        {
            Rooms = rooms;
        }

        public void SetStrategy(IStrategy _strategy)
        {
            strategy = _strategy;
        }

        public List<Room> GetStrategyRooms()
        {
            return strategy.Algorithm(Rooms);
        }
    }
}

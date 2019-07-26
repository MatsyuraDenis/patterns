using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Room
    {
        private static int sid = 0;
        public int Id { get; protected set; }
        public Type Type { get; set; }

        public Room(Type type)
        {
            Type = type;
            Id = sid++;
        }

    }


    enum Type
    {
        Bussines,
        Standart,
        Cheap
    }
}

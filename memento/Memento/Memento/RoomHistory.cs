using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class RoomHistory
    {
        public Stack<RoomMemento> Mementos { get; private set; }

        public RoomHistory(Stack<RoomMemento> mementos)
        {
            Mementos = mementos;
        }
    }
}

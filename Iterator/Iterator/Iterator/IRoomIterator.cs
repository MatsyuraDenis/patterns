using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IRoomIterator
    {
        bool HasNext();
        void Reset();
        Room Current { get; }
    }
}

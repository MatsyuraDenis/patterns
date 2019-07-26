using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositor
{
    interface IComponent
    {
        int GetCapacity();
        int GetTotalPrice();
    }
}

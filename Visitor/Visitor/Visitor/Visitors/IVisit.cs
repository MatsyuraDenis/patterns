using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IVisit
    {
        string Visit(HostelRoom room);
        string Visit(HotelRoom room);
    }
}

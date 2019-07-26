using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IMediator
    {
        void SendMessage(User user, string message);
        void GetMessage(User user, string message);
    }
}

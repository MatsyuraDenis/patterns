using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_chain_of_responsibility
{
    class VipService : ServiceType
    {
        public override void ShowService(User user)
        {
                Console.WriteLine("We get VIP service for our vip user");
        }
    }
}

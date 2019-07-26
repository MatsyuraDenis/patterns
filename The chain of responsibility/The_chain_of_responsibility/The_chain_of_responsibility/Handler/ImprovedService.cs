using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_chain_of_responsibility
{
    class ImprovedService : ServiceType
    {
        public override void ShowService(User user)
        {
            if ((int)user.Status < 20)
                Console.WriteLine("We get IMPROVED service regular users");
            else if (next != null)
                next.ShowService(user);

        }
    }
}

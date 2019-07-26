using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_chain_of_responsibility
{
    class UsualService : ServiceType
    {
        public override void ShowService(User user)
        {
            if((int)user.Status < 2)
                Console.WriteLine("We get standart service for all users");
            else if(next != null)
                next.ShowService(user);
                
        }
    }
}

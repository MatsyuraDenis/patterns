using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceType usual = new UsualService();
            ServiceType regular = new ImprovedService();
            ServiceType vip = new VipService();
            usual.SetServiceType(regular);
            regular.SetServiceType(vip);

            User student = new User(GuestStatus.Usual);
            User regularClient = new User(GuestStatus.Regular);
            User president = new User(GuestStatus.Vip);

            usual.ShowService(student);
            usual.ShowService(regularClient);
            usual.ShowService(president);

            Console.ReadKey();
        }
    }
}

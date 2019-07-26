using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat();
            User admin = new User("Admin", chat);
            User guest = new User("Guest", chat);

            guest.SendMessage("Hi! When will free single room in your hotel?");
            admin.SendMessage(string.Format("Hi! In {0} you can book one from 4 free single rooms", DateTime.Now));

            Console.ReadKey();
        }
    }
}

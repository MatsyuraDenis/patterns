using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Chat : IMediator
    {
        List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void GetMessage(User user, string message)
        {

            Console.WriteLine("{0} get new message: {1}", user.Name, message);           
        }

        public void SendMessage(User user, string message)
        {
            Console.WriteLine("{0} send new message: {1}", user.Name, message);

            foreach (var user1 in users)
            {
                if(user1 != user)
                    user1.GetMessage(message);
            }
        }
    }
}

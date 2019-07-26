using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        private Chat Chat { get; set; }
        public string Name { get; set; }

        public User(string name, Chat chat)
        {
            Chat = chat;
            Chat.AddUser(this);
            Name = name;
        }

        public void SendMessage(string message)
        {
            Chat.SendMessage(this, message);
        }

        public void GetMessage(string message)
        {
            Chat.GetMessage(this, message);
        }

    }
}

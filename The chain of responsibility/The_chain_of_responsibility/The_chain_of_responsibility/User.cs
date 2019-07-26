using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_chain_of_responsibility
{
    class User
    {
        public GuestStatus Status { get; set; }

        public User(GuestStatus status)
        {
            Status = status;
        }
    }
}

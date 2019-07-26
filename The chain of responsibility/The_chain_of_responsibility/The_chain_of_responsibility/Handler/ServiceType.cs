using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_chain_of_responsibility
{
    abstract class ServiceType
    {
        protected ServiceType next;

        public void SetServiceType(ServiceType service)
        {
            next = service;
        }

        public abstract void ShowService(User user);
    }
}

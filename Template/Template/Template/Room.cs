using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class Room
    {
        public abstract void Book();
        public abstract void GetOrder();

        public void Template()
        {
            Book();
            GetOrder();
        }
    }
}

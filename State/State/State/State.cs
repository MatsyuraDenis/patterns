using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IState
    {
        void ShowStatus();
    }

    public class ActiveState : IState
    {
        public void ShowStatus()
        {
            Console.WriteLine("This booking is active for this time");
        }
    }

    public class EndState : IState
    {
        public void ShowStatus()
        {
            Console.WriteLine("Booking time is completed");
        }
    }

    public class WaitingState : IState
    {
        public void ShowStatus()
        {
            Console.WriteLine("Room is planed for some user");
        }
    }
}

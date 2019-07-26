using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            Restaurant restaurant = new Restaurant();
            IComand roomCommands = new RoomCommands(room);
            IComand restaurantComand = new RestaurantCommand(restaurant);
            User user = new User(roomCommands);

            user.Book();
            user.Unbook();

            user.Booking = restaurantComand;

            user.Book();
            user.Unbook();

            Console.ReadKey();
        }
    }
}

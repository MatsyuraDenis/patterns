using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class RestaurantCommand : IComand
    {
        public Restaurant Restaurant { get; set; }

        public RestaurantCommand(Restaurant restaurant)
        {
            Restaurant = restaurant;
        }

        public void Book()
        {
            Restaurant.BookRestaurant();
        }

        public void Unbook()
        {
            Restaurant.UnbookRestaurant();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
    public class Hotel 
    {
        public int Id { get; set; }
        public List<Room> Rooms { get; set; }
        public Nutrition Nutrition { get; set; }
        public HotelType Type { get; set; }

        public Hotel(HotelFactory factory)
        {
            Nutrition = factory.ChooseNutrition();
            Type = factory.GetType();
        }
    }
}

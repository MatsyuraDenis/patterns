using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class EliteHotelFactory : HotelFactory
    {
        public override Nutrition ChooseNutrition()
        {
            return Nutrition.AllInclusive;
        }

        public override HotelType GetType()
        {
            return HotelType.FiveStarHotel;
        }
    }
}

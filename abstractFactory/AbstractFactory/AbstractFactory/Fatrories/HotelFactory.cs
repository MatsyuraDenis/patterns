using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class HotelFactory
    {
        public abstract Nutrition ChooseNutrition();
        public abstract HotelType GetType();
    }
}

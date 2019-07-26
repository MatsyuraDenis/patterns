using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HostelFactory : HotelFactory
    {
        public override Nutrition ChooseNutrition()
        {
            return Nutrition.OnlyBed;
        }

        public override HotelType GetType()
        {
            return HotelType.Hostel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class HotelsSet
    {
        public List<string> HotelNames { get; set; }
        private static HotelsSet set;
        private static object locker = new object();

        private HotelsSet() { }

        public static HotelsSet GetHotels()
        {
            lock (locker)
            {
                if (set == null)
                {
                    set = new HotelsSet();
                    set.HotelNames = new List<string>();
                }

            }

            return set;
        }

        public void ShowHotels()
        {
            foreach (var hotel in HotelNames)
            {
                Console.WriteLine(hotel);
            }
        }
    }
}

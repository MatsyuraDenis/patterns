using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelsSet set = HotelsSet.GetHotels();
            set.ShowHotels();

            HotelsSet set0 = HotelsSet.GetHotels();
            set0.ShowHotels();

            Console.WriteLine("Add to set");
            AddtoSet("Cheremosh", set);

            set0.ShowHotels();



            Console.WriteLine("Add to set0");
            AddtoSet("Bukovina", set0);

            set.ShowHotels();

            Console.ReadKey();

        }

        static void AddtoSet(string name, HotelsSet set)
        {
            set.HotelNames.Add(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hotel hotel = new Hotel(1);
            //User petro = new User("Petro");
            //User andriy = new User("Andriy");
            //User djon = new User("Djon");

            //hotel.AddObserver(petro);
            //hotel.AddObserver(andriy);
            //hotel.AddObserver(djon);

            //hotel.IsFree = true;
            //Console.WriteLine();
            //hotel.IsFree = true;

            //Console.WriteLine();
            //hotel.RemoveObserver(petro);


            User petro = new User("Petro");
            User andriy = new User("Andriy");
            User djon = new User("Djon");

            Hotel hotel = new Hotel(1, andriy, petro, djon);

            hotel.IsFree = true;
            hotel.IsFree = false;


            Console.WriteLine("Rendo");
            Console.ReadKey();
        }
    }
}

using System;

namespace Prototype
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(new Room(1, 120), "Petro");
            Order orderCopy = order.Copy();



            Console.WriteLine("Order:");
            Check(order);
            Console.WriteLine("Copy:");
            Check(orderCopy);


            Console.WriteLine();
            order.UserName = "John";

            Console.WriteLine("Order:");
            Check(order);
            Console.WriteLine("Copy:");
            Check(orderCopy);

            // With serialization
            //Order order = new Order(new Room(1, 120), "Petro");
            //Order orderCopy = order.DeepCopy();



            //Console.WriteLine("Order:");
            //Check(order);
            //Console.WriteLine("Copy:");
            //Check(orderCopy);


            //Console.WriteLine();
            //order.UserName = "John";

            //Console.WriteLine("Order:");
            //Check(order);
            //Console.WriteLine("Copy:");
            //Check(orderCopy);

            Console.ReadKey();
        }

        public static void Check(Order order)
        {
            Console.WriteLine("HotelId: {0}, Price: {1}, User: {2}", order.Room.HotelId, order.Room.Price, order.UserName);
            Console.WriteLine();
        }
    }
}

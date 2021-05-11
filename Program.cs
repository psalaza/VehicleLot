using System;

namespace VehicleLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("honda", "civic", "white", 4);
            Semi semi1 = new Semi("toyota", "semi", "black", 2);
       
            Console.WriteLine("---CAR---");
            car1.print();
            Console.WriteLine("---SEMI---");
            semi1.print();
        }
    }
}

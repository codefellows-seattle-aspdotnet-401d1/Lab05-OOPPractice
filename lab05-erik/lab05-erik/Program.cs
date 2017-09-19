using System;

namespace lab05_erik
{
    class Program
    {
        static void Main(string[] args)
        {
            Hybrid MyCar = new Hybrid();

            
            Console.WriteLine($"My car has {MyCar.Wheels()} wheels and its a ");
            MyCar.Sadan();
            Console.WriteLine("Sadan.");
            Console.WriteLine("engine:");
            MyCar.Engine();
            Console.WriteLine("country made:");
            MyCar.CountryOrign();

            Console.WriteLine("This car has a smart-mirror");
            MyCar.SmartMirror();
            Console.WriteLine("MPG:");
            MyCar.Mpg();
            Console.Read();
        }
    }
}

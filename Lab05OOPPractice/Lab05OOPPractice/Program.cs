using System;

namespace Lab05OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Bathrooms secondFloorShared = new Bathrooms();
            Console.WriteLine($"upper bathroom gets 1 " + secondFloorShared.OutletType);


            Office office = new Office();
            Console.WriteLine(office.OutletType);
            Console.Read();
        }

        
    }
}

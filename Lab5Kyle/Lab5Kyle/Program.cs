using System;

namespace Lab5Kyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Ready to get your dance on?");

            BumpperShoot seattle = new BumpperShoot();

            Console.WriteLine("Do you have a Venue to hold this concert?");
            seattle.HasVenue(); //override from base class

            Console.WriteLine("Do you have a dedicated stage?");
            seattle.HasStage(); //overide from outdoor concert class

            Console.WriteLine("How long is the concert?");
            seattle.VenueHours();

            Console.WriteLine("How much are tickets?");
            Console.WriteLine($"Tickets cost { seattle.TicketCost() } dollars.");

            Console.WriteLine("How many bands are playing?");
            Console.WriteLine($"There are { seattle.NumBands() } bands playing");

            Console.Read();
        }
    }
}

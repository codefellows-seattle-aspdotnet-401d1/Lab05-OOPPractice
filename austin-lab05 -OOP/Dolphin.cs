using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice
{
    class Dolphin : Air
    {
        public Dolphin()
        {
            Cost = 4;
            MaxPassengers = 5;
            Range = 2;
        }

        //Override subtracts 1 range from dolphin, causing a refuel to be required on returning to base.
        public override void Search(Mission Mission)
        {
            Mission.MissionCost += 1;
            Range--;
        }

        public override int Rescue(Mission Mission)
        {
            Console.WriteLine($"Your Dolphin has arrived on scene!");
            Mission.Victims = Mission.Victims - MaxPassengers;
            if (Mission.Victims > 0)
            {
                Console.WriteLine($"Good Job, but there are still {Mission.Victims} victims left to rescue!");
                Console.ReadLine();
                return Mission.Victims;
            }
            else
            {
                Console.WriteLine($"All survivors rescued. Returning to base.");
            }

            return Mission.Victims;
        }

        public override void DescribeUnit()
        {
            Console.WriteLine("DOLPHIN RESCUE CHOPPER:");
            Console.WriteLine("");
            Console.WriteLine("Cost to Deploy: 4.");
            Console.WriteLine("Cost to Refuel: 4.");
            Console.WriteLine("Maximum Passengers: 5.");
            Console.WriteLine("Trips before Refueling: 2.");
            Console.WriteLine("Search Cost: 1.");
            Console.WriteLine("ADDITIONAL SEARCH COST: If you search with this aircraft, your trips before refueling is reduced to 1.");
            Console.WriteLine("");

        }
    }
}

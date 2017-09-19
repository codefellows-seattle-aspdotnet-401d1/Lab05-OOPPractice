using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice
{
    class JayHawk : Air
    {
        public JayHawk()
        {
            Cost = 6;
            MaxPassengers = 8;
            Range = 1;
        }

        public override void DescribeUnit()
        {
            Console.WriteLine("JAYHAWK RESCUE CHOPPER");
            Console.WriteLine("Cost to Deploy: 6.");
            Console.WriteLine("Cost to Refuel: 3.");
            Console.WriteLine("Maximum Passengers: 8.");
            Console.WriteLine("Trips before Refueling: 1.");
            Console.WriteLine("Search Cost: 1.");
            Console.WriteLine("");

        }

        public override int Rescue(Mission Mission)
        {
            Mission.Victims = Mission.Victims - MaxPassengers;
            if (Mission.Victims > 0)
            {
                Console.WriteLine($"Good Job, but there are still {Mission.Victims} victims left to rescue!");
                return Mission.Victims;
            }
            return Mission.Victims;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice 
{
    class Guardian : Air
    {
        public Guardian()
        {
            Cost = 0;
        }

        public override void DescribeUnit()
        {
            Console.WriteLine("GUARDIAN SEARCH PLANE");
            Console.WriteLine("Use the Guardian to view the number of victims on site before deploying a rescue craft.");
            Console.WriteLine("The initial search cost is higher, but you will have a better idea of what vehicle use to pull off a more efficient mission");
            Console.WriteLine("Search Cost: 2.");
            Console.WriteLine("");

        }

        public override int Rescue(Mission Mission)
        {
            Mission.MissionCost += 2;
            Console.WriteLine("You Guardian Search Plane has been deployed. Your mission cost has increased by 2.");
            return Mission.Victims;
        }
    }
}

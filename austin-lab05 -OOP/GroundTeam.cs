using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice
{
    class GroundTeam : Land
    {
        public GroundTeam()
        {
            Cost = 1;
        }

        //Unit description
        public override void DescribeUnit()
        {
            Console.WriteLine("GROUND TEAM");
            Console.WriteLine("Use the Ground team to refuel your aircraft between trips.");
            Console.WriteLine("The Dolphin can take 2 trips without refueling as long as you don't use it to search.");
            Console.WriteLine("");

        }

        //Refuels Aicraft once they are depleted
        public override void Refuel(Mission Mission, Air ToRefuel)
        {
            ToRefuel.Range = 1;
            ToRefuel.HasFuel = true;
            Mission.MissionCost += (ToRefuel.Cost / 2);
            Console.WriteLine($"Your Aircraft has been refueled and your mission cost has increased.");
            if(ToRefuel.Equals(typeof(Dolphin)))
            {
                ToRefuel.Range = 2;
                Mission.MissionCost += 4;
            }
        }
    }
}

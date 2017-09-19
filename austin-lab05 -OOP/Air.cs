using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice
{
    abstract class Air:CG_Unit
    {
        internal bool HasFuel { get; set; }
        protected int MaxPassengers { get; set; }
        internal int Range { get; set; }

        //only derivatives can be of class Air.
        protected Air()
        {
            Operational = true;
            HasFuel = true;
        }

        //Overrides base to implement refuel capabilitie
        public override void DeployUnit(Mission Mission)
        {
            if (this.IsDeployed())
            {
                Console.WriteLine("This Unit is already in the field.");
            }
            else if (HasFuel == false)
            {
                Console.WriteLine("Aircraft must first be refueled.");
                
            } else
            {
                Console.WriteLine("Aircraft is now on route to mission.");
                this.Deployed = true;
                Mission.MissionCost += Cost;
            };
        }

        //Overrides base class to add passenger functionality
        public override void ReturnHome()
        {
            if (!this.IsDeployed())
            {
                Console.WriteLine("This Unit is already at home base.");
            }
            else
            {
                Console.WriteLine("Unit has returned home.");
                Range--;
                this.Deployed = false;
                if (Range <= 0)
                { HasFuel = false; }
            };
        }

        public void RequestSupport(Mission Mission, Air Backup)
        {
            Backup.DeployUnit(Mission);
            Mission.MissionCost += (Backup.Cost * 2);
        }

        public virtual void Search(Mission Mission)
        {
            Mission.MissionCost += 1;
        }

        public abstract int Rescue(Mission Mission);

    }
}

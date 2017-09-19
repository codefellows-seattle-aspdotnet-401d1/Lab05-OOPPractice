using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice
{
    abstract class Land : CG_Unit
    {
        protected string Supports { get; set; }

        //Only derivatives can be of class Land
        protected Land()
        {
            Operational = false;
        }

        //Overrides base class to inform user that this unit cannot be deployed.
        public override void DeployUnit(Mission Mission)
        {
            Console.WriteLine("This is an non-operational unit. Unable to deploy.");
        }

        public abstract void Refuel(Mission Mission, Air ToRefuel);

    }
}

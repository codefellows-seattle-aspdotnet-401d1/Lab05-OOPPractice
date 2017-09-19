using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice
{
    abstract class CG_Unit
    {
        protected bool Operational { get; set; }
        protected bool Deployed { get; set; }
        public int Cost { get; set; }

        protected bool IsDeployed()
        {
            if (Deployed == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void DeployUnit(Mission Mission)
        {
            if (IsDeployed())
            {
                Console.WriteLine("This Unit is already in the field.");
            }
            else {
                Console.WriteLine("Unit is now on route to mission.");
                Deployed = true;
            }
        }

        public virtual void ReturnHome()
        {
            if (!IsDeployed())
            {
                Console.WriteLine("This Unit is already at home base.");
            }
            else
            {
                Console.WriteLine("Unit has returned home.");
                Deployed = false;
            }
        }

        public abstract void DescribeUnit();

    }
}

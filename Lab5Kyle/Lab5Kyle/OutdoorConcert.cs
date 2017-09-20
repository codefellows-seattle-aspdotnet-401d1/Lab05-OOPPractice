using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Kyle
{
    abstract class OutdoorConcert : Concert
    {
        public virtual int VenueHours() // made virtual so it can change hours if needed
        {
            int VenueHours = 12;
            return VenueHours;
        }

        abstract public void HasStage(); // made abstract because to find out if they have a dedicated stage
    }
}

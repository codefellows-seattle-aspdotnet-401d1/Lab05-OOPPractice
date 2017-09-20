using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Kyle
{
    abstract class Concert
    {
        abstract public void HasVenue(); //abstract because required for all concert children

        public virtual int NumBands() // this is virtual because it can be changed to allow for any number of bands
        {
            int NumBands = 12;
            return NumBands;
        }

        public virtual int TicketCost() // made virtual because can change depending on concert
        {
            int TicketCost = 35;
            return TicketCost;
        }
    }
}

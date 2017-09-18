using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    class Master : Bedrooms
    {
        override public string CeilingLight
        {
            get
            {
                return "Hugger 52 in. LED Brushed Nickel Ceiling Fan";
            }
        }
        public override int Switches { get { return 2; } set { } }

        public override int Outlets { get { return 6; } set { } }
    }
}

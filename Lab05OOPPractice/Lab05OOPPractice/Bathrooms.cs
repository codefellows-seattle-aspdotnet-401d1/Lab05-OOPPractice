using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    class Bathrooms : SecondFloor
    {
        public override string OutletType
        {
            get
            {
                return "20 amp GFCI receptical";
            }
            set
            {

            }
        }
        public override int Switches { get { return 4; } set { } }

        public override int Outlets { get { return 2; } set { } }
    }
}

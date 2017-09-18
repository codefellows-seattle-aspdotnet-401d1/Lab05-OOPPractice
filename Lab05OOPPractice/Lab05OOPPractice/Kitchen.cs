using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    class Kitchen : UtilitySpace
    {
        public override int Switches { get { return 4; } set { } } //override to change number of switches for specific room

        public override int Outlets { get { return 6; } set { } } //override to change number of outlets for specific room
    }
}

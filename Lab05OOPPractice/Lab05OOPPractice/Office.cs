using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    class Office : FamilySpace
    {
        public override int Switches { get { return 2; } set { } }

        public override int Outlets { get { return 2; } set { } }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    class LivingRoom : FamilySpace
    {
        public bool MountedTvOutlet { get; set; }
        public override int Switches
        {
            get
            {
                return 5;
            }
            set
            {

            }
        }
        public override int Outlets
        {
            get
            {
                return 7;
            }
            set
            {

            }
        }
    }
}


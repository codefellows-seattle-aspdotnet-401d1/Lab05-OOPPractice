using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Kyle
{
    class BumpperShoot : OutdoorConcert
    {
        public override void HasVenue()
        {
            Console.WriteLine("It has a venue!");
        }

        public override void HasStage()
        {
            Console.WriteLine("It does not have a normal stage, one was built for it.");
        }

    }


}

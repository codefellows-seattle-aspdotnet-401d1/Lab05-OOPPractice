using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_erik
{
    abstract class Fusion : Ford // fusion derives from ford that derives from car. 
    {
        public virtual void Sadan() // carsize virtual because it can change
        {
            Console.WriteLine("Mid Size");
        }

        public abstract void Mpg();// the cars gas mpg
    }
}

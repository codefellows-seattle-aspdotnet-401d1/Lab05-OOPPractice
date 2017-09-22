using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    //abstract because this class is derived - it is a base class
    abstract class Mochi : IceCream
    {
        public bool IsSweet()
        {
            return true;
        }
        public virtual bool IsFried()
        {
            Console.WriteLine("If you're looking for tempura fried ice cream, you're in the wrong place.");
            return false;
        }
    }
}

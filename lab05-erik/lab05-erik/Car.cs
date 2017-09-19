using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_erik
{
   abstract class Car //This class is set to abstract because it is the base class.
    {   
        public abstract int Wheels(); // this method will later print number of wheels

        public virtual void Engine() //made this one virtual to be able to chage it later.  
        {
            Console.WriteLine("3.0L : vroom vroom."); 
        }
    }
}

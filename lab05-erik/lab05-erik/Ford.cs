using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_erik
{
    abstract class Ford : Car // ford derives from car and is abstract. layer 2 
    {
        public abstract void CountryOrign(); // that can be neat info 

        public virtual void SmartMirror() // virtual method incase i want to change it later.
        {
            Console.WriteLine("Its a little screen in your rear view mirror that has the back up cam feed.");
        }
    
    }
}

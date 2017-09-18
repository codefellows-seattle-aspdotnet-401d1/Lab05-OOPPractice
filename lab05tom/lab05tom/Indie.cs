using System;
using System.Collections.Generic;
using System.Text;

namespace lab05tom
{
    abstract class Indie : Movies //Abstract class
    {
        internal bool Oscar { get; set; }

        internal virtual bool WonOscar() //virtual method
        {
            bool oscar = Oscar;
            if (oscar == true)
            {
                Console.WriteLine("This movie won an Oscar");
                return true;
            }
            else
            {
                Console.WriteLine("This movie didn't win an Oscar");
                return false;
            }
        }

        internal virtual void ReleaseDate() //virtual method
        {
            Console.WriteLine("This movie came out in 2017");
        }
    }
}

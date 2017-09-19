using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_erik
{
    class Hybrid : Fusion // this class last class and what the oject will be instantiated from. 
    {   
        public override void CountryOrign() //overiding the abstract method 
        {
            Console.WriteLine("USA");
        }

        public override void Mpg() //overiding abstract method to use it
        {
            Console.WriteLine("on av 38per gal");
        }

        public override int Wheels() //overriding abstract method to set it and use
        {
            int wheels = 4;
            return wheels;
        }

        public override void Engine() //overriding virtual method to change engine size dbecuase hybrid models have smaller engines 
        {
            Console.WriteLine("2.2L for the hybrid");
        }
    }
}

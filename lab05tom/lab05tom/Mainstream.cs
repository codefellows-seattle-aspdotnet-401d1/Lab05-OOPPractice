using System;
using System.Collections.Generic;
using System.Text;

namespace lab05tom
{
    abstract class Mainstream : Movies //Abstract class
    {
        internal bool Blood { get; set; }

        internal sealed override string HasPlot() //override of virtual method in base class Movies
        {
            return base.HasPlot();
        }

        internal abstract bool HasBlood(); //abstract method

    }
}

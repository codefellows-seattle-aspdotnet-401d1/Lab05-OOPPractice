using System;
using System.Collections.Generic;
using System.Text;

namespace lab05tom
{
    abstract class Movies //Abstract class
    {
        //Encapsulation: I used internal access modifiers so that my variables and methods are accessible within the namespace lab05tom
        internal string Plot { get; set; }
        internal string Director { get; set; }
        internal string Actors { get; set; }

        internal abstract void HasDirector(); //abstract method

        internal abstract void HasActors(); //abstract method

        internal virtual string HasPlot() //virtual method
        {
            string plot = Plot;
            return plot;
        }
    }
}

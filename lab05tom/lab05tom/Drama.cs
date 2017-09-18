using System;
using System.Collections.Generic;
using System.Text;

namespace lab05tom
{
    class Drama : Indie
    {
        internal override void HasDirector() //override of abstract method from base class Movies. Required.
        {
            string director = Director;
            Console.WriteLine($"Directed by {director}");
        }

        internal override void HasActors() //override of abstract method from base class Movies. Required.
        {
            string actors = Actors;
            Console.WriteLine($"Starring {actors}");
        }

        internal sealed override void ReleaseDate() //override of virtual method from parent class Indie to change date
        {
            Console.WriteLine("This movie came out in 2016");
        }
    }
}

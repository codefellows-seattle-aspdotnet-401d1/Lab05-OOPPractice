using System;
using System.Collections.Generic;
using System.Text;

namespace lab05tom
{
    class Horror : Mainstream
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

        internal override bool HasBlood() //override of abstract method from parent class Mainstream. Required.
        {
            bool blood = Blood;
            if (blood == true)
            {
                Console.WriteLine("This movie is bloody!");
                return true;
            }
            else
            {
                Console.WriteLine("This movie isn't bloody");
                return false;
            }
        }
    }
}

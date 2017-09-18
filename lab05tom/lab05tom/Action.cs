using System;
using System.Collections.Generic;
using System.Text;

namespace lab05tom
{
    class Action : Mainstream
    {

        internal bool CarChase { get; set; }

        internal override void HasDirector() //override of abstract method from base class; Polymorphism
        {
            string director = Director;
            Console.WriteLine($"Directed by {director}");
        }

        internal override void HasActors() //override of abstract method from base class; Polymorphism
        {
            string actors = Actors;
            Console.WriteLine($"Starring {actors}");
        }

        internal bool HasCarChase()
        {
            bool carChase = CarChase;
            if (carChase == true)
            {
                Console.WriteLine("This movie has a car chase");
                return true;
            }
            else
            {
                Console.WriteLine("This movie doesn't have a car chase");
                return false;
            }
        }

        internal override bool HasBlood() //override of abstract method from parent class Mainstream
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

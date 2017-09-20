using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class Action : Movie
    {
        public string Star { get; set; }

        public Action(string title, string star)
        {
            Title = title;
            Star = star;
        }

        //This method is being overridden because it is abstract and therefore required
        public override void Cost(int price)
        {
            Console.WriteLine($"This movie costs ${price}.");
            Price = price;
        }

        //This method is an optional override. In this case, I am overriding to add more information
        public override void IsAvailable()
        {
            base.IsAvailable();
            Console.WriteLine($"{Title} is also available on BluRay");
        }

        public void HasExplosions()
        {
            Console.WriteLine("You better believe it has explosions.");
        }
    }
}

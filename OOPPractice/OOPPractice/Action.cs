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

        public override void Cost(int price)
        {
            Console.WriteLine($"This movie costs ${price}.");
            Price = price;
        }

        public void HasExplosions()
        {
            Console.WriteLine("You better believe it has explosions.");
        }
    }
}

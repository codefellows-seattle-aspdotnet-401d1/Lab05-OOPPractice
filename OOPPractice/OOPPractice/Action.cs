using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class Action : Movie
    {
        public override void Cost(int price)
        {
            Console.WriteLine($"This movie costs ${price}.");
            Price = price;
        }
    }
}

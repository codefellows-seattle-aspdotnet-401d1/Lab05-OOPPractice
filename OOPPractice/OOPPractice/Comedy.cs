using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class Comedy : Movie
    {
        public string Theme { get; set; }

        public Comedy(string title, string theme)
        {
            Title = title;
            Theme = theme;
        }

        //This method is a required override as a derivative of Media
        public override void Cost(int price)
        {
            Console.WriteLine($"This movie costs ${price}.");
            Price = price;
        }

        public void IsFunny()
        {
            Console.WriteLine("This movie is hilarious.");
        }
    }
}

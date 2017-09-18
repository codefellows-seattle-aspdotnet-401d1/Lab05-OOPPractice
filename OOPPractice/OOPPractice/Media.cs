using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    abstract class Media
    {
        public string Title { get; set; }
        public string Release { get; set; }
        public int Price { get; set; }


        public void IsReleased()
        {
            Console.WriteLine("This item has been released!");
        }

        public virtual void IsAvailable()
        {
            Console.WriteLine("This item is available for purchase!");
        }

        public abstract void Cost(int price);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class Bad : Music
    {
        public bool IsCountry { get; set; }

        public override void Cost(int price)
        {
            Console.WriteLine($"This garbage song costs ${price}.");
        }

        public override void HasMusicVideo()
        {
            Console.WriteLine("I dunno... probably.");
        }

        public void ShouldBurn()
        {
            Console.WriteLine("Yep. This should definitely burn.");
        }
    }
}

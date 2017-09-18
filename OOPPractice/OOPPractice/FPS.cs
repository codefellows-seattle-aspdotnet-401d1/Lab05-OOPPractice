using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class FPS : VideoGame
    {
        public int Price { get; set; }
        public bool Online { get; set; }

        public override void Cost(int price)
        {
            Console.WriteLine($"This game costs ${price}.");
            Price = price;
        }

        public override void IsAwesome(bool confirm)
        {
            if (confirm == true)
            {
                Console.WriteLine("This game has a storyline.");
            }
            else
            {
                Console.WriteLine("This game is Call of Duty.");
            }
        }

        public void HasCoolWeapons()
        {
            Console.WriteLine("This game has cool weapons.");
        }
    }
}

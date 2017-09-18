using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class RPG : VideoGame
    {
        public bool CustomCharacter { get; set; }

        public override void Cost(int price)
        {
            Console.WriteLine($"This game costs ${price}.");
            this.Price = price;
        }

        public override void IsAwesome(bool confirm)
        {
            if (confirm == true)
            {
                Console.WriteLine("This game is awesome.");
            }
            else
            {
                Console.WriteLine("This game is not awesome.");
            }
            CustomCharacter = confirm;
        }

        public void HasEpicStoryline()
        {
            Console.WriteLine("This game has an epic story!");
        }
    }
}

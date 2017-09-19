using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class FPS : VideoGame
    {
        public bool Online { get; set; }

        public FPS(string title, string platform, bool online)
        {
            Title = title;
            Platform = platform;
            Online = online;
        }

        //Here we are overriding the methods because they are abstract and therefore required
        public override void Cost(int price)
        {
            Console.WriteLine($"{Title} costs ${price}.");
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
            Console.WriteLine($"{Title} has cool weapons.");
        }
    }
}

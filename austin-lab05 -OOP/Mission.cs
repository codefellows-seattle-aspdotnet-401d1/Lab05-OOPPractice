using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpractice
{
    public class Mission
    {
        public int Victims { get; set; }
        public int MissionCost { get; set; }

        public void GenVictims()
        {
            MissionCost = 0;
            Random rand = new Random();
            Victims = rand.Next(1, 20);
        }
    }
}

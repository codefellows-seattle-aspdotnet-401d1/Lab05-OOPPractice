using System;

namespace lab05_brian
{
    internal class Redeemer : BlackOps
    {
        internal override void ResistanceProfile()
        {
            Console.WriteLine("Ships explosive resist is 73");
            Console.WriteLine("Ships kenetic resist is 70");
            Console.WriteLine("Ships termal resist is 45");
            Console.WriteLine("Ships em resist is 83");
        }

        internal override void HightSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }

        internal override void MidSlots()
        {
            Console.WriteLine("This ship has 4 mid slots");
        }

        internal override void LowSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }

        internal override void CanCloak()
        {
            Console.WriteLine("Stealth Battleships are hax");
        }
    }
}

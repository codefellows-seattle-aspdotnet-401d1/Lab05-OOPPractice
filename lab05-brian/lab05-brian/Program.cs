using System;

namespace lab05_brian
{
    internal abstract class Ship
    {
        internal void Fly()
        {
            Console.WriteLine("Zoom zoom!");
        }

        internal void UseGate()
        {
            Console.WriteLine("Changing System");
        }

        internal void Eject()
        {
            Console.WriteLine("Mistakes were made");
        }
    }

    internal abstract class Battleship : Ship
    {
        internal abstract void HightSlots();
        internal abstract void MidSlots();
        internal abstract void LowSlots();
    }

    internal abstract class AmarrBattleships : Battleship
    {
        internal virtual void ResistanceProfile()
        {
            Console.WriteLine("Ships explosive resist is 83");
            Console.WriteLine("Ships kenetic resist is 83");
            Console.WriteLine("Ships termal resist is 83");
            Console.WriteLine("Ships em resist is 83");
        }
    }

    internal abstract class BlackOps : AmarrBattleships
    {
        internal abstract void CanCloak();
    }

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

    internal abstract class Logistics : AmarrBattleships
    {

    }

    internal class Armageddon : Logistics
    {
        internal override void HightSlots()
        {
            Console.WriteLine("This ship has 8 high slots");

        }

        internal override void LowSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }

        internal override void MidSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }
    }

    internal abstract class Attack : AmarrBattleships
    {
        
    }

    internal class Abaddon : Attack
    {
        internal override void HightSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }

        internal override void MidSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }

        internal override void LowSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }
    }

    internal class Apocalypse : Attack
    {
        internal override void HightSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }

        internal override void MidSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }

        internal override void LowSlots()
        {
            Console.WriteLine("This ship has 8 high slots");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Redeemer aternaTenebris = new Redeemer();
            aternaTenebris.CanCloak();
            aternaTenebris.HightSlots();
            aternaTenebris.ResistanceProfile();
            Console.Read();
        }
    }
}

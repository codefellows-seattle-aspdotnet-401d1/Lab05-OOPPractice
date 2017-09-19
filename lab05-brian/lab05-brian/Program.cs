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
            int explosive = 85;
            int 
        }
    }

    internal abstract class BlackOps : AmarrBattleships
    {

    }

    internal class Redeemer : BlackOps
    {

    }

    internal abstract class Logistics : AmarrBattleships
    {

    }

    internal abstract class Armageddon
    {
        
    }

    internal abstract class Attack : AmarrBattleships
    {
        
    }

    internal class Abaddon : Attack
    {
        
    }

    internal class Apocalypse : Attack
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

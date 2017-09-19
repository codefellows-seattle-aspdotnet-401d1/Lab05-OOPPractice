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
}
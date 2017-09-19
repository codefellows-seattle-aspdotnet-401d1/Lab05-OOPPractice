using System;

namespace lab05_brian
{
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
}
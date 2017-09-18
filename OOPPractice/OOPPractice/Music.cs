using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    abstract class Music : Media
    {
        public string Artist { get; set; }

        public virtual void IsCollaboration()
        {
            Console.WriteLine("This song is a collaborative effort.");
        }

        public abstract void HasMusicVideo();
    }
}

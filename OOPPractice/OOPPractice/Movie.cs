using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    abstract class Movie : Media
    {
        public string TheaterRelease { get; set; }

        public virtual void HasSubtitles()
        {
            Console.WriteLine("This title has subtitles!");
        }
    }
}

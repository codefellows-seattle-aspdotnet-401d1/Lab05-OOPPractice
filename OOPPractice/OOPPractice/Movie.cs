using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    abstract class Movie : Media
    {
        public string TheaterRelease { get; set; }

        //This method is available to all classes derived from Movie, but can be overridden
        public virtual void HasSubtitles()
        {
            Console.WriteLine("This title has subtitles!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    abstract class VideoGame : Media
    {
        public string Platform { get; set; }

        public abstract void IsAwesome(bool confirm);
    }
}

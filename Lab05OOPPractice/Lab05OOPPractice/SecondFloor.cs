using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    abstract class SecondFloor : MainPanel
    {
        virtual public string CeilingLight
        {
            get
            {
                return "Commercial Electric 2-Light Brushed Nickel Flushmount";
            }
        }

    }
}

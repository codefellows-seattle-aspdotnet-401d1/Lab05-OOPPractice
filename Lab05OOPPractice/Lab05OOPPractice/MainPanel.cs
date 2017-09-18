using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    abstract class MainPanel
    {
        public int Switches { get; set; }

        public int Outlets { get; set; }

        public virtual int WireGauge
        {
            get
            {
                return 14;
            }
            set
            {

            }
        }

        public virtual int CircuitAmps
        {
            get
            {
                return 15;
            }
            set
            {

            }
        }

        public virtual string OutletType
        {
            get
            {
                return "Standard 15 amp receptical.";
            }
            set
            {

            }
        }
    }
}

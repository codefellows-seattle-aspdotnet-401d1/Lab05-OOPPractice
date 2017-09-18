using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    abstract class UtilitySpace : MainFloor
    {
        public override int WireGauge //overriding 14 guage wire becuase 12g is required in these spaces
        {
            get
            {
                return 12;
            }
            set
            {

            }
        }

        public string LightType { get; set; }

    }
}

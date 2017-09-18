using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05OOPPractice
{
    abstract class FamilySpace : MainFloor
    {
        static bool CeilingFan { get; set; }

        protected bool HSInternet //useing protected because data is sensitive and other classes shouldn't have access to the data line
        {
            get
            {
                return true;
            }
            set
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    //abstract because this class is derived - it is a base class
        class Mango : MikawayaBrand
    {
        public string Portable
        {
            get; set;
        }
        public string FreezerBurn
        {
            get; set;
        }
        public int HowManyYouCanEat
        {
            get; set;
        }
        //public so that access is not restricted
        public Mango(string VeryPortable, string FreezeBurned, int NumberEaten)
        {
            Portable = VeryPortable;
            FreezerBurn = FreezeBurned;
            HowManyYouCanEat = NumberEaten;
        }
        //add three override methods
    }
}

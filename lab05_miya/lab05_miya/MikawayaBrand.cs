using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    //MikawayaBrand inherits from Mochi class
    class MikawayaBrand : Mochi
    {
        public int NumberOfFlavors
        {
            get; set;
        }

        //public so that access is not restricted
        public override string CoolOffWithIceCream()
        {
            //throw new NotImplementedException();
            string stayCool = "It's hot outside! Grab some ice cream.";
            return stayCool;
        }

        //public so that access is not restricted
        public override bool PetsCanHaveSome()
        {
            Console.WriteLine("Pets should not eat your ice cream. It's for humans.");
            return false;
            //throw new NotImplementedException();
        }

        public virtual void SoldInStores()
        {
            Console.WriteLine("Mikawaya is sold in Uwajimaya and QFC, if you're looking for delicious mochi ice cream");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    abstract class IceCream : Desserts
    {
        //public so that access is not restricted
        //I made this abstract because it is a base class.
        public abstract bool PetsCanHaveSome();

        //public so that access is not restricted
        //this is void so that I won't be required to return anything
        public void EatTheStuff()
        {
            Console.WriteLine("You just bought the most enticingly arranged ice cream. What are you waiting for? Eat the stuff!");
        }
        //public so that access is not restricted
        //this is void so that I won't be required to return anything
        public void TossTheStuff()
        {
            Console.WriteLine("Before you consider tossing your ice cream, why not give it to a friend or stranger?");
        }
        //public so that access is not restricted
        //there is an int here so this method has to return an int
        public int TimesYouSharedIceCream()
        {
            return 0;
        }
    }
}

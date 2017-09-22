using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    //abstract because this class is derived - it is a base class
    abstract class Desserts
    {
        //public so that access is not restricted
        public string NameOfStores
        {
            get; set;
        }
        //public so that access is not restricted
        public int Budget
        {
            get; set;
        }
        //public so that access is not restricted
        protected int AddToDesserts()
        {
            int desserts = 0;
            return desserts;
        }
        public virtual int AskForPrice()
        {
            Console.WriteLine("The price is $5.");
            return 5;
        }
        public abstract string CoolOffWithIceCream();
    }
}

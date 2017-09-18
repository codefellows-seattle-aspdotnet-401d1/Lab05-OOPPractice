using System;

namespace Lab05OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Bathrooms secondFloorShared = new Bathrooms();
            Console.WriteLine("upper bathroom gets 1 " + secondFloorShared.OutletType);


            Office office = new Office();
            Console.WriteLine("office gets 5 " + office.OutletType);

            Kitchen kitchen = new Kitchen();
            kitchen.LightType = "Flourecent";
            Console.WriteLine("kitchen gets: " + kitchen.Switches + " switches " + kitchen.Outlets + " " + kitchen.OutletType + " run in " + kitchen.WireGauge + "AWG wire and " + kitchen.CircuitAmps + " amp breaker : Extra " + kitchen.LightType);

            Master master = new Master();
            Console.WriteLine("master bed gets: " + master.Switches +" switches " + master.Outlets + " " + master.OutletType + " useing " +master.WireGauge+ "AWG wire and " + master.CircuitAmps + "amp breaker");

            Console.Read();
        }

        
    }
}

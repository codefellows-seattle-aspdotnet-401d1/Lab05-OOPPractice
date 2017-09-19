using System;

namespace OOPpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Coast Guard Air Rescue Simulator!");
            Console.WriteLine("Try to complete a rescue mission while keeping your mission cost down.");
            Console.WriteLine("Each Unit has its strengths and weaknesses. Use these to complete a mission with the lowest cost you can.");
            GameLoop();
        }

        public static void GameLoop()
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            GroundTeam FuelTeam = new GroundTeam();
            Guardian Scout = new Guardian();
            Dolphin Light = new Dolphin();
            JayHawk Heavy = new JayHawk();
            Console.WriteLine("Enter a number to navigate.");
            Console.WriteLine("1. View Unit descriptions.");
            Console.WriteLine("2. Start Game.");
            Console.WriteLine("3. EXIT.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                Scout.DescribeUnit();
                Light.DescribeUnit();
                Heavy.DescribeUnit();
                FuelTeam.DescribeUnit();
                Console.ReadLine();
            }
            if (input == "2")
            {
                PlayGame();
            }
            if (input == "3")
            {
                Environment.Exit(0);
            }

            Console.Clear();
            MainMenu();

        }
        public static void PlayGame()
        {
            Mission Mission = new Mission();
            GroundTeam FuelTeam = new GroundTeam();
            Guardian Scout = new Guardian();
            Dolphin Light = new Dolphin();
            JayHawk Heavy = new JayHawk();
            Mission.GenVictims();
            int Victims = Mission.Victims;
            Console.WriteLine("New Rescue Mission Reported! Go Go GO!");
            Console.WriteLine("Would You Like to deploy the Guardian Searchplane to gather intel? Y/N.");
            string input = Console.ReadLine().ToUpper();
            if (input == "Y")
            {
                Console.WriteLine($"Your search plane has reported that there are {Scout.Rescue(Mission)} survivors in the water!");
            }
            while (Victims > 0)
            {
                Console.WriteLine("Which Rescue Chopper would you like to deploy?");
                Console.WriteLine("1. Deploy Dolphin");
                Console.WriteLine("2. Deploy Jayhawk");
                string CraftInput = Console.ReadLine();
                if (CraftInput == "1")
                {
                    Light.DeployUnit(Mission);
                    if(Light.HasFuel ==  false )
                    {
                       FuelTeam.Refuel(Mission, Light);
                       Light.DeployUnit(Mission);
                    }
                    if(input == "N")
                    {
                        Light.Search(Mission);
                        Console.WriteLine($"Mission located, there are {Mission.Victims} survivors in the water!");
                    }
                    Victims = Light.Rescue(Mission);
                    Light.ReturnHome();
                }
                if (CraftInput == "2")
                {
                    Heavy.DeployUnit(Mission);
                    if (Heavy.HasFuel == false)
                    {
                        FuelTeam.Refuel(Mission, Heavy);
                        Heavy.DeployUnit(Mission);
                    }
                    if (input == "N")
                    {
                        Heavy.Search(Mission);
                        Console.WriteLine($"Mission located, there are {Mission.Victims} survivors in the water!");
                    }
                    Victims = Heavy.Rescue(Mission);
                    Heavy.ReturnHome();
                }
                




            }

            Console.WriteLine("Good Job! All Survivors have been rescued!");
            Console.WriteLine($"Total Mission Cost: {Mission.MissionCost}");
            Console.ReadLine();



        }
    }
}

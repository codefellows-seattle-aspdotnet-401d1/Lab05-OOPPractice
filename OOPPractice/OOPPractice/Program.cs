using System;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just a series of demo instantiations for each of the derivative classes
            RPG finalFantasy = new RPG("Final Fantasy", "NES", true);
            finalFantasy.HasEpicStoryline();
            finalFantasy.IsAvailable();
            finalFantasy.IsReleased();

            FPS callOfDuty = new FPS("Call of Duty 3", "PC, PS4, XBox One", true);
            callOfDuty.HasCoolWeapons();
            callOfDuty.IsAwesome(false);
            callOfDuty.Cost(60);

            Action dieHard = new Action("Die Hard", "Bruce Willis");
            dieHard.HasExplosions();
            dieHard.HasSubtitles();
            dieHard.Cost(18);

            Comedy scaryMovie = new Comedy("Scary Movie", "Horror Comedy");
            scaryMovie.IsAvailable();
            scaryMovie.IsFunny();
            scaryMovie.HasSubtitles();

            Good inTheEnd = new Good("In the End", "Linkin Park", "Guitar");
            inTheEnd.HasGoodBeat();
            inTheEnd.HasMusicVideo();
            inTheEnd.IsReleased();

            Bad honkyTonk = new Bad("Honky Tonk Badonkadonk", "Trace Adkins", true);
            honkyTonk.HasMusicVideo();
            honkyTonk.ShouldBurn();

            Console.Read();
        }
    }
}

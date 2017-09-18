using System;

namespace lab05tom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are some characteristics of Wonder Woman");
            Action wonderWoman = new Action(); //instantiation of object
            wonderWoman.Plot = "Plot: Diana Prince has superpowers and ends World War I"; //virtual method inherited from abstract class Mainstream, which overrides a virtual method from base class Movies.
            Console.WriteLine(wonderWoman.HasPlot()); //virtual method inherited from abstract class Mainstream, which overrides a virtual method from base class Movies.
            wonderWoman.Director = "Patty Jenkins"; //inherited from class Action, which overrides an abstract method from base class Movies.
            wonderWoman.Actors = "Gal Gadot and Chris Pine"; //inherited from class Action, which overrides an abstract method from base class Movies.
            wonderWoman.HasDirector(); //inherited from class Action, which overrides an abstract method from base class Movies.
            wonderWoman.HasActors(); //inherited from class Action, which overrides an abstract method from base class Movies.

            Console.WriteLine();
            Console.WriteLine("Here are some characteristics of John Wick: Chapter 2");
            Action johnWick = new Action(); //instantiation of object
            johnWick.Actors = "Keanu Reeves and Laurence Fishburne"; //inherited from class Action, which overrides an abstract method from base class Movies.
            johnWick.HasActors(); //inherited from class Action, which overrides an abstract method from base class Movies.
            johnWick.CarChase = true; //inherited from class Action, which is derived from abstract class Mainstream which is derived from base class Movies.
            johnWick.HasCarChase(); //inherited from class Action, which is derived from abstract class Mainstream which is derived from base class Movies.

            Console.WriteLine();
            Console.WriteLine("Here are some characteristics of It");
            Horror itMovie = new Horror(); //instantiation of object
            itMovie.Blood = true; //inhertied from class Horror, which overrides an abstract method from Mainstream, which is derived from base class Movies.
            itMovie.HasBlood(); //inhertied from class Horror, which overrides an abstract method from Mainstream, which is derived from base class Movies.
            itMovie.Plot = "Plot: A killer clown terrorizes kids in a small town"; //virtual method inherited from abstract class Mainstream, which overrides a virtual method from base class Movies.
            Console.WriteLine(itMovie.HasPlot()); //virtual method inherited from abstract class Mainstream, which overrides a virtual method from base class Movies.

            Console.WriteLine();
            Console.WriteLine("Here are some characteristics of Moonlight");
            Drama moonlight = new Drama(); //instantiation of object
            moonlight.Oscar = true; //virtual method inherited from abstract class Indie, which is derived from base class Movies
            moonlight.WonOscar(); //virtual method inherited from abstract class Indie, which is derived from base class Movies
            moonlight.Director = "Barry Jenkins"; //inherited from class Drama, which overrides an abstract method from base class Movies.
            moonlight.HasDirector(); //inherited from class Drama, which overrides an abstract method from base class Movies.
            moonlight.ReleaseDate(); //virtual method inherited from class Drama, which overrides virtual method from abstract class Indie, which is derived from base class Movies.

            Console.Read();
        }
    }
}

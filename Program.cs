using System;
using System.Collections.Generic;

namespace H1_SuperHeroFightArena
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Superhero> superheroes = new List<Superhero>();
            List<Superhero> semifinalists = new List<Superhero>();
            List<Superhero> finalists = new List<Superhero>();
            List<Superhero> endingPlaces = new List<Superhero>();

            superheroes.Add(new Superhero("KongFuHarry", 2, 2, 5, 5, 120));
            superheroes.Add(new Superhero("SuperDogDino", 6, 8, 2, 8, 70));
            superheroes.Add(new Superhero("QuickCarl", 2, 5, 3, 3, 90));
            superheroes.Add(new Superhero("PoisonGunner", 1, 13, 5, 5, 90));
            superheroes.Add(new Superhero("MiniMuoseMikkel", 9, 9, 9, 9, 40));
            superheroes.Add(new Superhero("CatTiger", 3, 6, 4, 4, 35)); //add extra life and plus 3 Not yet implemented
            superheroes.Add(new Superhero("RubberGoatIvan", 6, 6, 8, 8, 70));
            superheroes.Add(new Superhero("EgonTheMoose", 5, 11, 4, 4, 90));


            Console.WriteLine("Welcome to the fight arena. Let thi fight begin!");


        }
    }
}

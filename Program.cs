using System;
using System.Collections.Generic;

namespace Lists_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string> // A list of all strings called Games
            {
                "Half Life 2",
                "Left4Dead2",
                "Halo ODST",
                "Terraria",
                "Silent Hill3"
            };

            string[] otherGames = new string[]
            {
                "Tiny Tina's Wonderlands",
                "Farcry 3",
            };

            foreach(string game in games) // For each game in the "games" list it will print it to the console.
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($"\nGames in list: {games.Count}"); //Number of games in list

            games.AddRange(otherGames); // Adds range to are "games" list

            Console.WriteLine($"\nGames in list: {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!!"); //if the games list contains halo it will print "MASTER CHIEF IS IN THE HOUSE" to the console, if not it adds it to the list
            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6; //if less than 6 removes at index 6

            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            Console.WriteLine("\nAll games in the list:"); // prints all games in the list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            games.Sort();

            Console.WriteLine("\nSorted games list:"); // Sorts and prints all games in the list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList); //copies list to new list

            games.Clear();

            Console.WriteLine("\nNew List:"); //prints new list
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}

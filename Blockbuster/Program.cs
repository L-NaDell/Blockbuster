using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster store = new Blockbuster();
            string another = "y";

            Console.WriteLine("Welcom to Blockbuster!");

            do
            {
                try
                {
                    Movie selectedMovie = store.CheckOut();

                    Console.WriteLine("\nYou selected: ");
                    selectedMovie.PrintInfo();

                    Console.Write("\nDo you want to play a scene from this movie (s), play the whole movie (p), select a new movie (m), or exit (x).  ");
                    string playOption = Console.ReadLine().ToLower().Trim();

                    switch (playOption)
                    {
                        case "s":
                            selectedMovie.Play();
                            break;
                        case "p":
                            selectedMovie.PlayWholeMovie();
                            break;
                        case "m":
                            another = "y";
                            break;
                        case "x":
                            another = "n";
                            break;
                    }
                    if (selectedMovie is VHS vhs)
                    {
                        Console.Write("\nDo you want to rewind? (y/n) ");
                        string backToStart = Console.ReadLine().ToLower().Trim();

                        if (backToStart == "y")
                        {
                            vhs.Rewind();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong. Please try again.");
                    another = "y";

                }
            }
            while (another == "y");

            Console.WriteLine("Goodbye!");
        }
    }
}

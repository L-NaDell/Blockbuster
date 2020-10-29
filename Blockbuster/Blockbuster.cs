using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class Blockbuster
    {
        public List<Movie> Movies {get; set;} = new List<Movie>();

        //movies, so so many movies...6 to be exact
        public Blockbuster()
        {
            List<string> titanicScenes = new List<string>();
            titanicScenes.Add("He's poor");
            titanicScenes.Add("She's rich");
            titanicScenes.Add("Dancing");
            titanicScenes.Add("Big ice");
            titanicScenes.Add("He's dead");
            VHS Titanic = new VHS("Titanic", Genre.Romance, 194, titanicScenes);

            List<string> shreckScenes = new List<string>();
            shreckScenes.Add("Ogre");
            shreckScenes.Add("Dragons!");
            shreckScenes.Add("Eddy Murphy");
            shreckScenes.Add("Music");
            DVD Shreck = new DVD("Shreck", Genre.Comedy, 120, shreckScenes);

            List<string> mermaidScenes = new List<string>();
            mermaidScenes.Add("Sisters");
            mermaidScenes.Add("Storm");
            mermaidScenes.Add("Laryngitis");
            mermaidScenes.Add("Child bride");
            VHS theLittleMermaid = new VHS("The Little Mermaid", Genre.Drama, 105, mermaidScenes);

            Movies.Add(Titanic);
            Movies.Add(Shreck);
            Movies.Add(theLittleMermaid);

            List<string> bestInShowScenes = new List<string>();
            bestInShowScenes.Add("Dog");
            bestInShowScenes.Add("Eugene Levy");
            bestInShowScenes.Add("Catherine O'Hara");
            bestInShowScenes.Add("MORE DOGS!");
            bestInShowScenes.Add("God Loves a Terrier");
            VHS bestInShow = new VHS("Best in Show", Genre.Drama, 194, bestInShowScenes);

            List<string> itScenes = new List<string>();
            itScenes.Add("Origami");
            itScenes.Add("Space clown");
            itScenes.Add("Fight!");
            itScenes.Add("Party");
            DVD it = new DVD("IT", Genre.Horror, 110, itScenes);

            List<string> fightClubScenes = new List<string>();
            fightClubScenes.Add("Don't talk about it.");
            fightClubScenes.Add("Soap");
            fightClubScenes.Add("Imaginary friends are great!");
            fightClubScenes.Add("Boom!");
            DVD fightClub = new DVD("Fight Club", Genre.Action, 145, fightClubScenes);

            Movies.Add(bestInShow);
            Movies.Add(it);
            Movies.Add(fightClub);
        }
        public void PrintMovie()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"{i} : {m.Title}");
            }
        }
        public Movie CheckOut()
        {
            Console.WriteLine("\nAvaliable Movies");
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            PrintMovie();
            Console.Write("\nPlease select a movie:");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movie output = Movies[index];

            return output;
        }
    }
}

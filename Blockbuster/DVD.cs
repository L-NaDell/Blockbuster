using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    // allow user to select a scene from list and print it
    //**************other half in VHS****PlayWholeMovie to play each scene from start-finish
    internal class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {

        }
        public override void Play()
        {
            PrintScenes();
            Console.WriteLine("What scene would you like to watch?");
            int watchThis = int.Parse(Console.ReadLine());
            try
            {
                string output = Scenes[watchThis];
                Console.WriteLine(output);
            }
            catch
            {
                Console.WriteLine("Please select a valid scene.");
            }
        }
        public override void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine(scene);
            }
        }
    }
}

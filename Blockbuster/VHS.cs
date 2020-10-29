using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    //**************other half in DVD****PlayWholeMovie to play each scene from start-finish

    internal class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play() 
        { 
            try
            {
            string scene = Scenes[CurrentTime];
            Console.WriteLine($"{CurrentTime} : {scene}");
            CurrentTime++;

            }
            catch
            {
                Console.WriteLine("Be kind. Rewind.");
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
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

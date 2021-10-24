using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            PrintScenes(this);
            int input = 0;

            try
            {
                Console.WriteLine("Select a scene: ");
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid option.");
                Play();
            }


            if (input > this.Scenes.Count)
            {
                Console.WriteLine("That is not a valid option.");
                Play();
            }
            else
            {
                Console.WriteLine($"Now Playing - {this.Title}\n");
                for(int i = input; i < this.Scenes.Count; i++)
                {
                    Console.WriteLine(this.Scenes[i]);
                }
            }
        }
    }
}

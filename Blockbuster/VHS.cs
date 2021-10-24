using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string Title, string Category, int Runtime, List<string> Scenes, int CurrentTime) : base(Title, Category, Runtime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }

        public override void Play()
        {
            Console.WriteLine($"Now Playing - {this.Title}\n");
            for (int i = this.CurrentTime; i < this.Scenes.Count; i++)
            {
                Console.WriteLine(this.Scenes[i]);
                this.CurrentTime++;
            }
        }

        public void Rewind(VHS movie)
        {
            for (int i = movie.CurrentTime-1; i>= 0; i--)
            {
                movie.CurrentTime = i;
            }

            Console.WriteLine("VHS is rewound.");
        }
    }
}

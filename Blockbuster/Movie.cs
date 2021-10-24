using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; } = new List<string>();
        public string Category { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo(Movie movie)
        {
            Console.WriteLine("");
            string input = $"[Title] {movie.Title}\n";
            input += $"[Category] {movie.Category}\n";
            input += $"[Runtime] {movie.RunTime}\n";
            Console.WriteLine(input);
        }
        public virtual void PrintScenes(Movie movie)
        {
            for (int i = 0; i < movie.Scenes.Count; i++)
            {
                Console.WriteLine(i + ") " + movie.Scenes[i]);
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"Now Playing - {this.Title}\n");
            for(int i = 0; i< this.Scenes.Count; i++)
            {
                Console.WriteLine(this.Scenes[i]);
            }
        }
    }
}

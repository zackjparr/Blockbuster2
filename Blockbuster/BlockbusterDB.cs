using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class BlockbusterDB
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public BlockbusterDB()
        {

            List<string> DVDScenes1 = new List<string>();
            DVDScenes1.Add("Dom gets the Family together");
            DVDScenes1.Add("Dom buys the Family a nice dinner");
            DVDScenes1.Add("The Rock steals the dinner");
            DVDScenes1.Add("Dom and The Rock fight");
            DVDScenes1.Add("Dom and The Rock make peace and eat together");

            List<string> DVDScenes2 = new List<string>();
            DVDScenes2.Add("Terminator and Robocop face off.");
            DVDScenes2.Add("They realize there's more to life than fighting");
            DVDScenes2.Add("They fall in love and start a Robofamily.");
            DVDScenes2.Add("They grow old and watch their family grow");
            DVDScenes2.Add("They die together as their OS are out of date.");

            List<string> DVDScenes3 = new List<string>();
            DVDScenes3.Add("Scooby and the gang find the killer.");
            DVDScenes3.Add("The IRS finds Scooby and the gang");
            DVDScenes3.Add("Scooby and the gang gets busted for years of tax evasion");
            DVDScenes3.Add("The gang gets served 15 years in prison");
            DVDScenes3.Add("Scooby serves no time as he is a dog");

            List<string> VHSScenes1 = new List<string>();
            VHSScenes1.Add("Zuckerberg gets caught peaking into people's privacy");
            VHSScenes1.Add("People camp out side Mark's house");
            VHSScenes1.Add("Mark comes outside with a flamethrower");
            VHSScenes1.Add("It doesn't work and he blows up");
            VHSScenes1.Add("Tom from MySpace returns");

            List<string> VHSScenes2 = new List<string>();
            VHSScenes2.Add("Godzilla takes a flight to the Maldives");
            VHSScenes2.Add("Godzilla lays down on the beach sipping on a Mojito");
            VHSScenes2.Add("Godzilla dreams about being able to fly");
            VHSScenes2.Add("Godzilla gets a deep tissue massage at the resort");
            VHSScenes2.Add("Godzilla flies home to Tokyo");

            List<string> VHSScenes3 = new List<string>();
            VHSScenes3.Add("Freddy Kreuger looks to broaden his stock portfolio");
            VHSScenes3.Add("He invests all his assests into $AMC and $GME");
            VHSScenes3.Add("Freddy Kreuger waits as he has diamond hands");
            VHSScenes3.Add("He still holds.");
            VHSScenes3.Add("Still holding.");


            Movies.Add(new DVD("Fast & Furious 10: Family", "Action", 300, DVDScenes1));
            Movies.Add(new DVD("Terminator vs. Robocop", "Romance", 250, DVDScenes2));
            Movies.Add(new DVD("Scooby Doo Meets The IRS", "Drama", 200, DVDScenes3));

            Movies.Add(new VHS("The Social Network 2: Zuckerburg's Revenge", "Horror", 400, VHSScenes1, 0));
            Movies.Add(new VHS("Godzilla's Day Off", "Comedy", 200, VHSScenes2, 0));
            Movies.Add(new VHS("Nightmare on Wall Street", "Drama", 300, VHSScenes3, 0));
        }

        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"({i}): {Movies[i].Title}");
            }
        }

        public Movie CheckOut()
        {
            int input = 0;

            Movie m = Movies[0];

            PrintMovies();
            Console.WriteLine();
            Console.WriteLine("What movie would you like to purchase?");

            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid movie selection");
            }

            try
            {
                m = Movies[input];
                m.PrintInfo(m);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("That was not a valid selection.");
                CheckOut();
            }
            return m;
        }
    }
}

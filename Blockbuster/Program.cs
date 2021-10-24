using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockbusterDB movies = new BlockbusterDB();

            Console.WriteLine("**Welcome to Blockbuster!**\nWhat movie(s) would you like to watch?\n");

            Movie selection = movies.CheckOut();

            selection.Play();
        }
    }
}

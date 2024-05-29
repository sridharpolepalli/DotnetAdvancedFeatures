using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.EventDemo
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //callback with Events
            MovieList_Events_1 movies = new MovieList_Events_1();
            movies.MovieAdded += new ConfirmHandler(Movies_MovieAdded);
            movies.AddMovie(new Movie("Movie1", "Director1", 2000, "Action", 9.1));
            Console.WriteLine(movies.Count);
            movies.MovieAdded -= new ConfirmHandler(Movies_MovieAdded);
            Console.ReadLine();
        }
        private static void Movies_MovieAdded(object o, ConfirmEventArgs args)
        {
            Console.WriteLine(args.Message);
        }
    }
}

using DelegateDemos.DelegateDemos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new ChainInvocation().CreateAndExecuteNotifyChain();

            //new MulticastDelegateWithReturnType().DisplayAllReturnValues();

            ////returning delegates
            //new MovieCollection_1().FilterMovies(MovieFilterAttribute.Director, "Christopher Nolan");

            ////callback with delegates
            //MovieList movies = new MovieList();
            ////movies.MovieAdded = new ConfirmHandler(Movies_MovieAdded);
            //movies.AddMovie(new Movie("Movie1", "Director1", 2000, "Action", 9.1));
            //Console.WriteLine(movies.Count);

            ////callback with Events
            //MovieList_Events_1 movies = new MovieList_Events_1();
            //movies.MovieAdded += new ConfirmHandler(Movies_MovieAdded);
            //movies.AddMovie(new Movie("Movie1", "Director1", 2000, "Action", 9.1));
            //Console.WriteLine(movies.Count);
            //movies.MovieAdded -= new ConfirmHandler(Movies_MovieAdded);


            //Closure Demo
            //ClosureDemo.Test();
            //ClosureDemo2.Test();
            //ClosureDemo2.Test();

            Console.ReadLine();
        }
        //private static void Movies_MovieAdded(object o, ConfirmEventArgs args)
        //{
        //    Console.WriteLine(args.Message);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.ReturnDelegateType
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //returning delegates
            new MovieCollection_1().FilterMovies(MovieFilterAttribute.Genre, "Action");
            Console.ReadLine();
        }
    }
}

﻿using System;
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
            new MovieCollection_1().FilterMovies(MovieFilterAttribute.Director, "Christopher Nolan");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.ChainDemo
{
    internal class ChainDemoMainclass
    {
        static void Main(string[] args)
        {
            new ChainInvocation().CreateAndExecuteNotifyChain();
            Console.ReadLine();
        }
    }
}

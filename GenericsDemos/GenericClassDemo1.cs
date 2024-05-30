using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemos
{
    public class GenericClassDemo1
    {
        private static readonly ILogger log = Log.ForContext<GenericClassDemo1>();
        public static void TestMethod()
        {
            log.Debug("This is a debug message.");
            log.Information("This is an info message.");
            log.Warning("This is a warning message.");
            log.Error("This is an error message.");
            log.Fatal("This is a fatal message.");
        }
    }
}

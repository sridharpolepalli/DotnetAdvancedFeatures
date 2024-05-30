using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs\\myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Example logging
            Log.Information("Application is starting...");

            try
            {
                // Your application code here
                Log.Debug("Debugging...");
                Log.Warning("This is a warning...");
                GenericClassDemo1.TestMethod();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An unexpected error occurred");
            }

            Log.Information("Application is closing...");

            // Flush and close log
            Log.CloseAndFlush();

        }
    }
}

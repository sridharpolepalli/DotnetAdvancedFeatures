using log4net;
using log4net.Config;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    internal class Program
    {
        ////Log4Net configuration
        //private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            //// Initialize log4net
            //XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            //log.Info("Application is starting...");
            //try
            //{
            //    log.Info("Executing the Operation1...");
            //    Console.WriteLine("Enter a number");
            //    int i = int.Parse(Console.ReadLine());
            //    Console.WriteLine(i);
            //}
            //catch(Exception ex)
            //{
            //    log.Error(ex.StackTrace);
            //    log.Debug("Debugging...");
            //    log.Warn("This is a warning...");
            //    log.Error("This is an error...");
            //    log.Fatal("This is a fatal error...");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    log.Info("Completed");
            //}

            //Console.WriteLine("-----------Nullable demo------------");
            //NullableType.Demo();


            //Console.WriteLine("-----------yield return demo------------");
            //foreach (int number in YieldDemo.GetNumbers())
            //{
            //    Console.WriteLine(number);
            //}


            //Console.WriteLine("-----------yield break demo------------");
            //IEnumerable values = YieldDemo.GetEvenNumbers(10);
            //foreach (int number in values)
            //{
            //    Console.WriteLine(number);
            //}


            //Console.WriteLine("-----------Equals Demo------------");
            //ObjectDemo.EqualsDemo1();

            //Console.WriteLine("------------Equals Demo2----------");
            //ObjectDemo.EqualsDemo2();

            //Console.WriteLine("-----------GetType Demo------------");
            //ObjectDemo.GetTypeDemo();

            //Console.WriteLine("-----------ReferenceEquals Demo------------");
            //ObjectDemo.ReferenceEqualsDemo();

            //Console.WriteLine("-----------MemberwiseClone Demo (Shallow copy)------------");
            //ObjectDemo.MemberwiseCloneDemo();

            //Console.WriteLine("-----------Extension method Demo ------------");
            //string phrase = "Hello, world! Welcome to C# extension methods.";
            //Console.WriteLine($"Word Count: {phrase.WordCount()}");

            //var cloudMarketPlaceAPIs = new[]
            //{
            //        new { name = "Microsoft", documentation = "https://learn.microsoft.com/en-us/marketplace/" },
            //        new { name = "AWS", documentation = "https://docs.aws.amazon.com/marketplace/" },
            //        new { name = "GCP", documentation = "https://cloud.google.com/marketplace/docs/" }
            //};
            //Console.WriteLine($"Cloud marketplace List: {cloudMarketPlaceAPIs.ToJson()}");
        }
    }
}

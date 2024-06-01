using log4net;
using log4net.Config;
using OtherFeatures.InterfaceCallback;
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
        #region Log4net class level configuration
        ////Log4Net configuration
        //private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        static void Main(string[] args)
        {
            #region Log4net configuration
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
            #endregion

            #region Nullable demo
            //Console.WriteLine("-----------Nullable demo------------");
            //NullableType.Demo();
            #endregion

            #region yield return demo
            //Console.WriteLine("-----------yield return demo------------");
            //foreach (int number in YieldDemo.GetNumbers())
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region yield break demo
            //Console.WriteLine("-----------yield break demo------------");
            //IEnumerable values = YieldDemo.GetEvenNumbers(10);
            //foreach (int number in values)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Equals Demo
            //Console.WriteLine("-----------Equals Demo------------");
            //ObjectDemo.EqualsDemo1();
            #endregion

            #region Equals Demo2
            //Console.WriteLine("------------Equals Demo2----------");
            //ObjectDemo.EqualsDemo2();
            #endregion

            #region GetType Demo
            //Console.WriteLine("-----------GetType Demo------------");
            //ObjectDemo.GetTypeDemo();
            #endregion

            #region ReferenceEquals Demo
            //Console.WriteLine("-----------ReferenceEquals Demo------------");
            //ObjectDemo.ReferenceEqualsDemo();
            #endregion

            #region MemberwiseClone Demo (Shallow copy)
            //Console.WriteLine("-----------MemberwiseClone Demo (Shallow copy)------------");
            //ObjectDemo.MemberwiseCloneDemo();
            #endregion

            #region Extension method Demo
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
            #endregion

           
        }
    }
}

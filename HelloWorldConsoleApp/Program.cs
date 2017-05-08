#region History
//Nayan Shah| Sample Hello World | 05/08/2017
#endregion History


using log4net;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the context
            IApplicationContext applicationContext = ContextRegistry.GetContext();

            // Get the instance through Spring configuration
            IHelloWorld obj = (IHelloWorld)applicationContext["IHelloWorld"];

            //configure log4net logger
            log4net.Config.BasicConfigurator.Configure();
            ILog log = log4net.LogManager.GetLogger(typeof(Program));
            
            
            //call the method to run and log the results
            log.Debug(obj.Run());
           
            Console.ReadLine();

        
          
           
        }


    }
}

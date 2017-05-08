#region History
//Nayan Shah| Sample Hello World | 05/08/2017
#endregion History


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    interface IHelloWorld
    {
        /// <summary>
        ///     Runs the main Hello World Console Application
        /// </summary>
        /// <param name="arguments">The command line arguments.</param>
        string Run();
    }
}

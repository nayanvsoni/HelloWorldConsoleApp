#region History
//Nayan Shah| Sample Hello World | 05/08/2017
#endregion History


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldConsoleApp
{

    public class HelloWorld : IHelloWorld
    {
        /// <summary>
        /// this method call the web api and returns the results
        /// </summary>
        /// <returns></returns>
        public string Run()
        {
            // call the webapi and return the results
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(ConfigurationManager.AppSettings["UriString"]).Result;
            var contents = response.Content.ReadAsStringAsync().Result;

            return contents;

        }

    }

    
}

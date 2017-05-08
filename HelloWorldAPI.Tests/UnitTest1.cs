using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;

namespace HelloWorldAPI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTestHelloWorldConsoleApp()
        {
           
            //test method to test the api
            const string Data = "\"Hello World\"";
            const string WebApiIUrl = "http://localhost:61656/api/Hello";

            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(WebApiIUrl).Result;
            var contents = response.Content.ReadAsStringAsync().Result;

            Assert.IsNotNull(contents);
            Assert.AreEqual(Data, contents);
        }

    }
}

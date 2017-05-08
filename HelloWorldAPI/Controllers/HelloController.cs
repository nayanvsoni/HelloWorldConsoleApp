#region History
//Nayan Shah| Sample Hello World | 05/08/2017
#endregion History

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldAPI.Controllers
{
    public class HelloController : ApiController
    {
        public IHttpActionResult Get()
        {
         
            // this api get returns the text 
            return Ok("Hello World");
        }

    }
}

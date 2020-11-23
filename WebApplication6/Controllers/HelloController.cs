using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication6.Controllers
{
    [Route("/{action}")]
    public class HelloController
    {
        [Route("/Say")]
        public String SayHello()
        {
            return "Hello !";
        }

        [Route("/Yell")]
        public String YellHello()
        {
            return "HELLO !";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOne.Models;
using AllForOne.Services;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloService data;

        public SayHelloController(SayHelloService dataFromService)
        {
            data = dataFromService;
        }
       
       
        [HttpPost]
        public string SayHello(SayHelloModel userinput)
        {
            return data.SayHello(userinput);
        }
    }
}
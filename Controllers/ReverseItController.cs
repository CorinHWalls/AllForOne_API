using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOne.Services;
using AllForOne.Models;
namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItService data;

        public ReverseItController(ReverseItService dataFromService)
        {
            data = dataFromService;
        }

        [HttpPost]

        public string Reverse(ReverseItModel userinput)
        {
            return data.Reverse(userinput);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;
using AllForOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddEvenController : ControllerBase
    {
        private readonly OddEvenService data;

        public OddEvenController(OddEvenService dataFromService)
        {
            data = dataFromService;
        }

         [HttpPost]
        public string OddEven(OddEvenModel userinput)
        {
            return data.OddEven(userinput);
        }
    }
}
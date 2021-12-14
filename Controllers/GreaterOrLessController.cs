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
    public class GreaterOrLessController : ControllerBase
    {

        private readonly GreaterOrLessService data;

        public GreaterOrLessController(GreaterOrLessService dataFromService)
        {
            data = dataFromService;
        }
        [HttpPost]
        public string GreaterOrLess(GreaterOrLessModel userinput)
        {
            return data.GreaterOrLess(userinput);
        }
    }
}
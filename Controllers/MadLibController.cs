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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices data;

        public MadLibController(MadLibServices dataFromServices)
        {
            data = dataFromServices;
        }

        [HttpPost]
public string Madlib(MadLibModel userinput)
        {
            return data.Madlib(userinput);
        }
        
    }
}
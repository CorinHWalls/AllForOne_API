using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService data; 

        public Magic8BallController(Magic8BallService dataFromService)
        {
            data = dataFromService;
        }

        [HttpPost]

        public string Magic8Ball()
        {
          return data.Magic8Ball();
        }
        
    }
    
}
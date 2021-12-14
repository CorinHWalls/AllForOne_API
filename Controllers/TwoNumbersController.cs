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
    public class TwoNumbersController : ControllerBase
    {
        private readonly TwoNumbersService data;

        public TwoNumbersController(TwoNumbersService dataFromService)
        {
            data = dataFromService;
        }
        //Default Route
        [HttpPost]

        public int AddingTwoNumbers(TwoNumbersModel userinput)
        {
            return data.AddingTwoNumbers(userinput);
        }
    }
}
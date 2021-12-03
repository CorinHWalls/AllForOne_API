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
    public class AskingQuestionsController : ControllerBase
    {
         //.              Datatype       Variable
        private readonly AskingQuestionsService data;
        // constructor that will handle connection to the service. 
        //                                   The Datatype      Variable
        public AskingQuestionsController(AskingQuestionsService dataFromService)
        {
            // Data = The variable that we want to use within the controller to get access to the service data /functions.
            //dataFromService = This is what passess the data / functions into our controller for us to have access to them.
            data = dataFromService;
        }
       
        [HttpGet]

        public string AskingQuestions(AskingQuestionModel userinput)
        {
           //What is your name and what time did you wake up today? 
            return data.AskingQuestions(userinput);
        }
    }
}
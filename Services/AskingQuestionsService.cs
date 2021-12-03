using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class AskingQuestionsService
    {
    
        public string AskingQuestions(AskingQuestionModel userinput)
        {
           //What is your name and what time did you wake up today? 
            return "So your name is " + userinput.name + " and you woke up at " + userinput.time + " !";
        }
    }
}
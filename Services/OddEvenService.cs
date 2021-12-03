using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class OddEvenService
    {
        public string OddEven(OddEvenModel userinput)
        {
            string answer = "Odd";
        if (userinput.num % 2 == 0)
        {
            answer = "Even";
        }
        return answer;
        }
    }
}
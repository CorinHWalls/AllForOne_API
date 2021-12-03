using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class TwoNumbersService
    {
        public int AddingTwoNumbers(TwoNumbersModel userinput)
        {
            return userinput.Num1 + userinput.Num2;
        }
    }
}
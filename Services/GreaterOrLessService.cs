using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class GreaterOrLessService
    {
        public string GreaterOrLess(GreaterOrLessModel userinput)
        {
         
         //generate new random
         Random rnd = new Random();
         // create random number between 1-100
         int num = rnd.Next(1,100);
         string answer = userinput.num + " equals " + num;
        
        if (num < userinput.num)
        {
            answer = userinput.num + " is greater than " + num;
        }
        else if(num > userinput.num)
        {
            answer = userinput.num + " is less than " + num;
        }

        return answer;
      
    
        }
    }
}
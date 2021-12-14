using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class ReverseItService
    {
        public string Reverse(ReverseItModel userinput)
        {
            // var resultString = new string(userinput.enteredString.ToCharArray().Reverse().ToArray());
            // return resultString;
            

            string reverseString = "";
            int a;
            bool res;
            
            res = int.TryParse(userinput.enteredString, out a);

            if(res == true){
                for(int i = userinput.enteredString.Length -1; i >= 0; i--)
                {
                    reverseString += userinput.enteredString[i];
                }
            }
            else{
                for(int i = userinput.enteredString.Length -1; i >= 0; i--)
            {
               reverseString += userinput.enteredString[i];
            }
            }

           
            return reverseString;
        }
    }
}
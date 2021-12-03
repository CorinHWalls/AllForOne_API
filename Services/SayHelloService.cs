using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class SayHelloService
    {
         public string SayHello(SayHelloModel userinput)
        {
            return "Hello, " + userinput.name;
        }
    }
}
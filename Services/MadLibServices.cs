using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class MadLibServices
    {

        public string Madlib(MadLibModel userinput)
        {
            string story = "Today I went to my favorite Taco Stand called the " + userinput.noun + ". " + " Unlike most food stands, they cook and prepare the food in a " + userinput.noun2 + " while you " + userinput.verb + "." + " The best thing on the menu is the " + userinput.noun3 +  ". " + "Instead of ground beef they fill the taco with, " + userinput.animal + " cheese, and top it off with a salsa made from " + userinput.bodypart + ". " + "If that doesn't make your mouth water, then it " + userinput.adjective + " just like " + userinput.noun4 + " always says: " + userinput.funnyword + " " + userinput.name + "!" ;
            return story;
        }

    }
}
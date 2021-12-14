using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.Services
{
    public class Magic8BallService
    {

        public string Magic8Ball()
        {
        List<string> answers = new List<string>(new string[] 
          {"It is certain.", 
          "It is decidedly so.", 
          "Without a doubt.", 
          "Yes - definitely.", 
          "You may rely on it.",
          "As I see it, yes.",
          "Most likely.",
          "Outlook good.",
          "Yes.",
          "My reply is no.",
          "My sources say no.",
          "Very doubtful.",
          "My sources say no."
          }); 

          Random r = new Random();
          int index = r.Next(answers.Count);

          return answers[index];
        }
       
    }
}
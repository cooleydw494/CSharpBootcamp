using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab65
{
    class AnswerGenerator
    {
        string[] answers = new string[]
        {
            "Ask Again Later", "Can Not Predict Now", "Without a Doubt", "Is Decidedly So", "Concentrate and Ask Again",
            "My Sources Say No", "Yes, Definitely", "Don't Count On It", "Signs Point to Yes", "Better Not Tell You Now",
            "Outlook Not So Good", "Most Likely", "Very Doubtful", "As I See It, Yes", "My Reply is No", "It is Certain",
            "Yes", "You May Rely On It", "Outlook Good", "Reply Hazy Try Again"
        };

        public string GetRandomAnswer(string question)
        {
            Random rand = new Random();
            return answers[rand.Next(0, answers.Length - 1)];
        }
    }
}

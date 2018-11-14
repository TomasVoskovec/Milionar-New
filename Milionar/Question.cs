using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionar
{
    class Question
    {
        public string Text;
        public string Answer;
        public List<string> WrongAnswers;

        public Question(string text, string answer, List<string> wrongAnswers)
        {
            if (wrongAnswers.Count() == 3)
            {
                this.Text = text;
                this.Answer = answer;
                this.WrongAnswers = wrongAnswers;
            }
            else
            {
                throw new Exception("List wrongAnswares must has 3 elements");
            }
        }
    }
}
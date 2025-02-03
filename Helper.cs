using eamination_system.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eamination_system
{
    internal class Helper
    {
        public static string GetAnswerText(List<Answer> answers, int answerId)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].AnswerId == answerId)
                    return answers[i].AnswerText;
            }
            return "Not Found";
        }
    }
}

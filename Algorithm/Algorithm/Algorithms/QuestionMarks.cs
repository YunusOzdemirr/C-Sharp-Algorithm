using System.Linq;
using System.Runtime.InteropServices;

namespace Algorithm.Algorithms;

public static class QuestionMarks
{
    public static string QuestionsMarks(string str)
    {
        string questionMark = "?";
        bool startQuestionMark = false;
        int questionMarkCount = 0;
        int successQuestions = 0;
        bool Status = false;
        for (int i = 0; i < str.Length; i++)
        {
            char letter = str[i];
            if (char.IsNumber(letter))
            {
                if (startQuestionMark == true)
                {
                    startQuestionMark = false;
                    if (questionMarkCount < 3 ||  questionMarkCount>3)
                    {
                        return "false";
                    }
                    questionMarkCount = 0;
                }

                startQuestionMark = true;
            }

            if (startQuestionMark == true)
            {
                if (letter == '?')
                    questionMarkCount++;
                if (questionMarkCount == 3)
                {
                    successQuestions++;
                    Status = true;
                }
            }
        }

        if (Status == true)
            return "true";

        return "false";
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfTest.Question
{
    interface IQuestion
    {
        String Describe { get; set; }
        Dictionary<char, String> Choice { get; set; }
        char[] CorrectAnswer { get; set; }
        bool IsCorrect(char[] answer);


    }
}

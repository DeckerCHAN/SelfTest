using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SelfTest.Question
{
    class Question:IQuestion
    {
        public Question(String questiongText)
        {
            Regex
        }
        public string Describe { get; set; }
        public Dictionary<char, string> Choice { get; set; }
        public char[] CorrectAnswer { get; set; }
        public bool IsCorrect(char[] answer)
        {
            return false;
        }
    }
}

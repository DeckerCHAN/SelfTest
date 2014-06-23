using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SelfTest.Question
{
    class QuestionBank
    {

        public List<IQuestion> Questions {  get; private set; }
        private QuestionBank()
        {

        }

        public void ReadQuestionsFromString(String questionsText)
        {
            var reg = new Regex(@"\s+\d+[\s\S]*?(?=\s+\d+)");
            foreach (var matchResult in reg.Match(questionsText).Groups)
            {
                this.Questions.Add(new Question(matchResult.ToString()));
            }
           
            
        }

        public void ReadQuestionFromFile(String fullPath)
        {
            this.ReadQuestionsFromString(File.ReadAllText(fullPath));
        }









        private static QuestionBank Instance;

        public static QuestionBank GetInstance()
        {
            if (Instance == null)
            {
                Instance = new QuestionBank();

            }
            return Instance;
        }
    }
}

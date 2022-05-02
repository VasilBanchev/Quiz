using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer;
using BusinessLayer;

namespace PresentationLayer
{
   public class QuestionView
    {
        private int _level;
        public QuestionView(int level)
        {
            _level = level;
        }

        public Question ChooseQuestion()
        {
            QuestionManager questionManager = new QuestionManager(DBContextManager.GetContext());
            List<Question> questionsCurrLevel = questionManager.ReadAll().Where(x => x.Level == _level).ToList();
            Random ran = new Random();
            Question question = questionsCurrLevel[ ran.Next(0, questionsCurrLevel.Count)];

            return question;
        }

        public List<string> AnswersRand(Question question)
        {
            List<string> aswRan = new List<string>();
            aswRan.Add(question.CorrectAnswer);
            aswRan.Add(question.InCorrectAnswer1);
            aswRan.Add(question.InCorrectAnswer2);
            aswRan.Add(question.InCorrectAnswer3);
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                
                int random = ran.Next(0, 4); ;
                string a = aswRan[i];
                aswRan[i] = aswRan[random];
                aswRan[random] = a;
            }
            return aswRan;
        }

       
    }
}

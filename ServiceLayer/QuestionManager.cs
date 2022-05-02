using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
   public class QuestionManager : IContext<Question, int>
    {
        private QuestionContext _QuestionContext;


        public QuestionManager(QuizDBContext context)
        {
            this._QuestionContext = new QuestionContext(context);
        }
        
        public void Create(Question Question)
        {
            try
            {
                _QuestionContext.Create(Question);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Question Read(int key)
        {
            try
            {
                return _QuestionContext.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Question> ReadAll()
        {
            try
            {
                return _QuestionContext.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Question item)
        {
            try
            {
                _QuestionContext.Update(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                _QuestionContext.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}


using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class QuestionContext : IDB<Question, int>
    {
        private QuizDBContext _context;

        public QuestionContext(QuizDBContext context)
        {
            _context = context;
        }
        public void Create(Question item)
        {
            try
            {
                _context.Questions.Add(item);
                _context.SaveChanges();
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
                Question QuestionFromDB = Read(key);

                _context.Questions.Remove(QuestionFromDB);
                _context.SaveChanges();
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
                return _context.Questions.Find(key);
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
                return _context.Questions.ToList();
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
                Question QuestionFromDB = Read(item.Id);

                _context.Entry(QuestionFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

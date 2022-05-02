using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class DBContextManager
    {
        private static QuizDBContext _context;

        static DBContextManager()
        {
            _context = new QuizDBContext();
        }

        public static QuizDBContext CreateContext()
        {
            _context = new QuizDBContext();
            return _context;
        }

        public static QuizDBContext GetContext()
        {
            return _context;
        }

        public static void SetAutoDetectChanges(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }
    }
}

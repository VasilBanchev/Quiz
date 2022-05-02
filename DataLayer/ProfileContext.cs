using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProfileContext : IDB<Profile, int>
    {
        private QuizDBContext _context;

        public ProfileContext(QuizDBContext context)
        {
            _context = context;
        }
        public void Create(Profile item)
        {
            try
            {
                _context.Profiles.Add(item);
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
                Profile ProfileFromDB = Read(key);

                _context.Profiles.Remove(ProfileFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Profile Read(int key)
        {
            try
            {
                return _context.Profiles.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Profile> ReadAll()
        {
            try
            {
                return _context.Profiles.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Profile item)
        {
            try
            {
                Profile ProfileFromDB = Read(item.Id);

                _context.Entry(ProfileFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

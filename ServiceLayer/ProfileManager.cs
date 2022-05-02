using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProfileManager : IContext<Profile, int>
    {
        private ProfileContext _ProfileContext;


        public ProfileManager(QuizDBContext context)
        {
            this._ProfileContext = new ProfileContext(context);
        }

        public void Create(Profile Profile)
        {
            try
            {
                _ProfileContext.Create(Profile);
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
                return _ProfileContext.Read(key);
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
                return _ProfileContext.ReadAll();
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
                _ProfileContext.Update(item);
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
                _ProfileContext.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CorrectLogin(string username, string password)
        {
            List<Profile> users = ReadAll().ToList();
            try
            {
               Profile user = users.Find(x => x.Username == username && x.Password == password);

                if (user !=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {

                throw;
                return false;
            }
           

        }
    }
}

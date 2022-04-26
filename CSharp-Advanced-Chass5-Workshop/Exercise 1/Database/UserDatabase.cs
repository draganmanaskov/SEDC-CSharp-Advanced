using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1.Database
{
    internal class UserDatabase : BaseDatabase<User>
    {
        public UserDatabase()
        {
        }

        public UserDatabase(List<User> entities) : base(entities)
        {
        }

        public User ValidLogin(string userName, string password)
        {
            foreach(User user in Entities)
            {
                if(user.Username == userName && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }

        public bool UserExists(string userName)
        {
            foreach (User user in Entities)
            {
                if (user.Username == userName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

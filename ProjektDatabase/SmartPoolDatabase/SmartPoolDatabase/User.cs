using System.Collections.Generic;
using System.Data.Entity;

namespace SmartPoolDatabase
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class DatabaseAccess
    {
        /// <summary>
        /// Inserts User into SmartPoolDatabase.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Return 0 on success.</returns>
        public int InsertUserIntoDatabase(User user)
        {
            using (var db = new SmartPoolDatabase())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

            return 0;
        }

        public void PrintUsersInDatabase()
        {
            
        }
    }

    public class SmartPoolDatabase : DbContext
    {
        public DbSet<User> Users { get; set; } 
    }
}

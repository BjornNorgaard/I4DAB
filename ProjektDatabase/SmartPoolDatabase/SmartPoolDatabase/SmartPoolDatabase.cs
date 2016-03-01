using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SmartPoolDatabase
{
    public class SmartPoolDatabase : DbContext
    {
        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            Name = "John Smith";
            Email = "fuckyou@thatswhy.com";
            Password = "password123";
        }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
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
            using (var db = new SmartPoolDatabase())
            {
                var query = from u in db.Users
                            orderby u.Name
                            select u;

                Console.WriteLine("**** USERS IN DATABASE *****");
                foreach (User user in query)
                {
                    Console.WriteLine("\t" + user.Name);
                }
            }
        }
    }
}

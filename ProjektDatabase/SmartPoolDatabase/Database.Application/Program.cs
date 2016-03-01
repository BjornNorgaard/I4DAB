using System;
using SmartPoolDatabase;

namespace Database.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            User Nors = new User("Nors", "derp@gmail.com", "motdepasse");

            databaseAccess.InsertUserIntoDatabase(Nors);
            databaseAccess.PrintUsersInDatabase();

            Console.WriteLine("Done");
        }
    }
}

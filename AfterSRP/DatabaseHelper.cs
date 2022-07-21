using System;

namespace AfterSRP
{
    internal class DatabaseHelper
    {
        internal void Save(User user)
        {
            Console.WriteLine($"User {user.Name} added to DB");
        }
    }
}
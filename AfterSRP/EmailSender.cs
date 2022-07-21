using System;

namespace AfterSRP
{
    internal class EmailSender
    {
        internal void Send(User user)
        {
            Console.WriteLine("email sent to " + user.Email);
        }
    }
}
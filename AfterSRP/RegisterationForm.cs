using System;

namespace AfterSRP
{
    internal class RegisterationForm
    {
        public User ReadInputs()
        {
            var user = new User();

            //Input gathering
            Console.Write("Please enter your name: ");
            user.Name = Console.ReadLine();
            Console.Write("Please enter your email address: ");
            user.Email = Console.ReadLine();

            return user;
        }
    }
}
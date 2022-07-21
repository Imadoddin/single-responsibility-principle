using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input gathering
            var registerationForm = new RegisterationForm();
            var user = registerationForm.ReadInputs();

            //Validation
            var validator = new Validator();
            var isValidUser = validator.Validate(user);
            if(!isValidUser)
            {
                Console.WriteLine("Error: invalid user");
                Console.ReadLine();
                return;
            }

            //Add user to database
            var dbHelper = new DatabaseHelper();
            dbHelper.Save(user);

            //Send welcome email
            var emailSender = new EmailSender();
            emailSender.Send(user);

            Console.Read();
        }
    }
}

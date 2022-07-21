using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input gathering
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Please enter your email address: ");
            var email = Console.ReadLine();

            //Validation
            if (!email.Contains("@"))
            {
                Console.WriteLine("Error: invalid user");
                Console.ReadLine();
                return;
            }

            //Add user to database
            //For simplicity, I am not writing actual code. It is not in the scope of this example
            Console.WriteLine($"User {name} added to DB");

            //Send welcome email
            //For simplicity, I am not writing actual code. It is not in the scope of this example
            Console.WriteLine("email sent to " + email);

            Console.ReadLine();
        }
    }
}

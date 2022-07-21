using System;

namespace AfterSRP
{
    internal class Validator
    {
        public bool Validate(User user)
        {
            return user.Email.Contains("@");
        }
    }
}
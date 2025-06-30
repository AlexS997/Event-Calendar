using System.Text.RegularExpressions;
using System;

namespace EventCalendar.Class
{
    public class CheckEmail
    {
        internal bool IsValidEmail(string email)
        {
            /* controlla l'esttezza formale dell'email*/
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
                return emailRegex.IsMatch(email);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

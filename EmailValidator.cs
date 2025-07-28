using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Demo_Email_Validation
{
    public class EmailValidator
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            // ^ - start of the string
            //[^@\s]+ - one or more characters that are not @ or whitespace(\s)
            // $ - end of the string
            // @ - at symbol
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Mobile no: @"^[6-9]\d{9}$"
            return Regex.IsMatch(email, pattern);// defined insided the Regex Package
        }
    }
}

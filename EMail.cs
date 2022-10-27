using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class EMail
    {
        public static string EMAIL_REGEX = "[a-z]{10}[0-9]{3}@gmail.com";
        public bool validateEMail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
    }
}
       
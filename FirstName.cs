using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class FirstName
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2}$";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }
    }
}

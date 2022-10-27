using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class LastName
    {
        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{7}$";
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME) ;
        }
    }
}
   
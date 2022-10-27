using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class Password
    {
        public static string PASSWORD_REGEX = "[a-z]{8}$";
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD_REGEX);
        }
    }
}

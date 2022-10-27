using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class MobileNumber
    {
        public static string REGEX_MOBILENUMBER = "^[9][1]?[0-9]{10}$";
        public bool validateMobileNumber(string mobilenumber)
        {
            return Regex.IsMatch(mobilenumber, REGEX_MOBILENUMBER);
        }
    }
}

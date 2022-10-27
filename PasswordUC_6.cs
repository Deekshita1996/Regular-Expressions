using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class PasswordUC_6
    {
        public static string PASSWORDUC_6_REGEX = "[A-Z]{1}[a-z]{7}$";
        public bool validatePasswordUC_6(string passwordUC_6)
        {
            return Regex.IsMatch(passwordUC_6, PASSWORDUC_6_REGEX);
        }
    }
}


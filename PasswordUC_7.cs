using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class PasswordUC_7
    {
        public static string REGEX_PASSWORDUC_7 = "[a-z]{7}[0-9]{1}$";
        public bool validatePasswordUC_7(string passwordUC_7)
        {
            return Regex.IsMatch(passwordUC_7, REGEX_PASSWORDUC_7);
        }
    }
}


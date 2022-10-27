using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class PasswordUC_9
    {
        public static string REGEX_PASSWORDUC_9 = "[A-Z]{1}[a-z]{4}#[0-9]{3}$";
        public bool validatePasswordUC_9(string passwordUC_9)
        {
            return Regex.IsMatch(passwordUC_9, REGEX_PASSWORDUC_9);
        }
    }
}

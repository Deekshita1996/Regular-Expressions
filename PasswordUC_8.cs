using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class PasswordUC_8
    {
        public static string REGEX_PASSWORDUC_8 = "[a-z]{7}[#]{1}$";
        public bool validatePasswordUC_8(string passwordUC_8)
        {
            return Regex.IsMatch(passwordUC_8, REGEX_PASSWORDUC_8);
        }
    }
}


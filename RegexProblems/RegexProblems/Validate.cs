using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems
{
    internal class Validate
    {
        public string pattern = @"ab{2,3}";
        public string sequence = @"[a-z]+_[A-Z]+";
        public void validateString(string str)
        {
            if (Regex.IsMatch(str, pattern))
            {
                Console.WriteLine("Input string is correct : " + str);
            }
            else
            {
                Console.WriteLine("Input string is incorrect");
            }
        }

        public void validateLowerCaseString(string lowerCase)
        {
            if (Regex.IsMatch(lowerCase, pattern))
            {
                Console.WriteLine("Input string is correct : " + lowerCase);
            }
            else
            {
                Console.WriteLine("Input string is incorrect");
            }
        }
    }
}

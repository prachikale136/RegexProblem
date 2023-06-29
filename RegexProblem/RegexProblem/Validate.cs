using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexProblem
{
    internal class Validate
    {
        public string pattern = "^[A-Za-z]{8,}[A-Z]+[0-9]+@([!@#$%^&*])$";

        public void ValidateString(string inputString)
        {
            if (Regex.IsMatch(fName, pattern))
            {
                Console.WriteLine("Input string is correct : " + fName);
            }
            else
            {
                Console.WriteLine("Input string is incorrect");
            }
        }

    }
}

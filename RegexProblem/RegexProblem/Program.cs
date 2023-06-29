using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("");
            string firstName = "Prachi";

            Validate validate = new Validate();
            validate.ValidateString(firstName);
            Console.ReadKey();




        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class InputValidation
    {
        public string StringValid()
        {
            string userString = Console.ReadLine();

            if (Regex.IsMatch(userString, @"^[a-zA-Z]+$"))
            {
                return userString;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.ReadLine();
                userString = null;
            }
            return userString;
        }

        public string NumberValid()
        {
            string userNumber = Console.ReadLine();

            if (Regex.IsMatch(userNumber, @"^[0-9]+$"))
            {
                return userNumber;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.ReadLine();
                userNumber = null;
            }
            return userNumber;
        }
    }
}

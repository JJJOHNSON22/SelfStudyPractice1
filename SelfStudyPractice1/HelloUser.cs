using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class HelloUser
    {
        public void Hello()
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            InputValidation validation = new InputValidation();
            string userString = validation.StringValid();
            if (userString == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine($"Hello, {userString}!");
                Console.ReadLine();
            }
            
        }
    }
}

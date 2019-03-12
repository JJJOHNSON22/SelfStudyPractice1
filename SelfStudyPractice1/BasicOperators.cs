using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class BasicOperators
    {
        public void DoMath()
        {
            Console.Clear();
            int total;
            InputValidation valid = new InputValidation();
            Console.WriteLine("Enter the first number.");
            string number1 = valid.NumberValid();
            int n1 = Convert.ToInt32(number1);
            if(number1 == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine("Enter the second number.");
                string number2 = valid.NumberValid();
                int n2 = Convert.ToInt32(number2);
                if(number2 == null)
                {
                    Menu menu = new Menu();
                    menu.UserMenu();
                }
                else
                {
                    total = n1 + n2;
                    Console.WriteLine($"{n1} + {n2} = {total}");
                    total = n1 - n2;
                    Console.WriteLine($"{n1} - {n2} = {total}");
                    total = n1 * n2;
                    Console.WriteLine($"{n1} * {n2} = {total}");
                    total = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {total}");
                    Console.ReadLine();
                }
            }
        }
    }
}

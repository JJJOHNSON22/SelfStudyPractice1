using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class SumNumbers
    {
        public void Sum()
        {
            Console.Clear();
            Console.WriteLine("Please enter a number.");
            InputValidation valid = new InputValidation();
            string number1 = valid.NumberValid();
            int n1 = Convert.ToInt32(number1);
            if (number1 == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine("Please enter a second number.");
                string number2 = valid.NumberValid();
                int n2 = Convert.ToInt32(number2);
                if (number2 == null)
                {
                    Menu menu = new Menu();
                    menu.UserMenu();
                }
                else
                {
                    int total = n1 + n2;
                    Console.WriteLine($"{n1} + {n2} = {total}");
                    Console.ReadLine();
                }
            }
        }
    }
}

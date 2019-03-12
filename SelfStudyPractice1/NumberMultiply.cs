using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class NumberMultiply
    {
        public void Product()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("Enter the first number to multiply.");
            string number1 = valid.NumberValid();
            int n1 = Convert.ToInt32(number1);
            if (number1 == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine("Enter the second number to multiply.");
                string number2 = valid.NumberValid();
                int n2 = Convert.ToInt32(number2);
                if(number2 == null)
                {
                    Menu menu = new Menu();
                    menu.UserMenu();
                }
                else
                {
                    Console.WriteLine("Enter the third number to multiply.");
                    string number3 = valid.NumberValid();
                    int n3 = Convert.ToInt32(number3);
                    if (number3 == null)
                    {
                        Menu menu = new Menu();
                        menu.UserMenu();
                    }
                    else
                    {
                        int total = n1 * n2 * n3;
                        Console.WriteLine($"{n1} * {n2} * {n3} = {total}");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class SwapNumbers
    {
        public void Swap()
        {
            Console.Clear();
            int temp;
            InputValidation vaid = new InputValidation();
            Console.WriteLine("Input the first number.");
            string firstNumber = vaid.NumberValid();
            int n1 = Convert.ToInt32(firstNumber);
            if (firstNumber == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine("Input the second number.");
                string secondNumber = vaid.NumberValid();
                int n2 = Convert.ToInt32(secondNumber);
                if (secondNumber == null)
                {
                    Menu menu = new Menu();
                    menu.UserMenu();
                }
                else
                {
                    temp = n1;
                    n1 = n2;
                    n2 = temp;
                    Console.WriteLine($"The first number is now {n1} and the second number is now {n2}.");
                    Console.ReadLine();
                }
            }
        }
    }
}

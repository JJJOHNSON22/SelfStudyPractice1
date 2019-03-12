using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class DivideNumbers
    {
        public void Divide()
        {
            Console.Clear();
            Console.WriteLine("Pick a number to divide.");
            InputValidation valid = new InputValidation();
            string number1 = valid.NumberValid();
            float n1 = Convert.ToInt32(number1);
            if (number1 == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine("Choose a number to divide by.");
                string number2 = valid.NumberValid();
                float n2 = Convert.ToInt32(number2);
                if (number2 == null)
                {
                    Menu menu = new Menu();
                    menu.UserMenu();
                }
                else
                {
                    float total = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {total:0.00}.");
                    Console.ReadLine();
                }
            }
        }
    }
}

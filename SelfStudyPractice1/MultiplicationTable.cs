using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class MultiplicationTable
    {
        public void Table()
        {
            Console.Clear();
            int x;
            int total;
            InputValidation valid = new InputValidation();
            Console.WriteLine("Please enter a number.");
            string number = valid.NumberValid();
            int n1 = Convert.ToInt32(number);
            if(number == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                for (x = 0; x <= 10; x++)
                {
                    total = n1 * x;
                    Console.WriteLine($"{n1} * {x} = {total}");
                    Console.ReadLine();
                }
            }
        }
    }
}

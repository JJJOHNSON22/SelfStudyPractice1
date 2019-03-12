using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class AverageFourNumbers
    {
        public void Average()
        {
            Console.Clear();
            List<int> list = new List<int>();
            InputValidation valid = new InputValidation();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter number {i + 1}.");
                string number = valid.NumberValid();
                int num = Convert.ToInt32(number);
                list.Add(num);
                if (number == null)
                {
                    Menu menu = new Menu();
                    menu.UserMenu();
                }
            }
            int count = 0;
            foreach(int num in list)
            {
                count++;
            }
            double average = list.Average();
            Console.WriteLine($"The average of {String.Join(", ", list)} is {average}.");
            Console.ReadLine();
        }
    }
}

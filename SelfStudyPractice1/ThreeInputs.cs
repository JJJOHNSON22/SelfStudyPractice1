using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class ThreeInputs
    {
        public void Calculate()
        {
            Console.Clear();
            List<int> list = new List<int>();
            InputValidation valid = new InputValidation();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter number {i + 1}.");
                string number = valid.NumberValid();
                if (number == null)
                {
                    Menu menu = new Menu();
                    menu.UserMenu();
                }
                int num = Convert.ToInt32(number);
                list.Add(num);
            }
            int x = list[0]; int y = list[1]; int z = list[2];
            Console.WriteLine($"x = {list[0]} y = {list[1]} z = {list[2]}");
            Console.WriteLine($"The result of (x + y) * z is {(x + y) * z} and x * y + y * z is {x * y + y * z}");
            Console.ReadLine();
        }
    }
}

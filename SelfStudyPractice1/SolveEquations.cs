using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class SolveEquations
    {
        public void Equations()
        {
            int eq1 = -1 + 4 * 6;
            int eq2 = (35 + 5) % 7;
            int eq3 = 14 + -4 * 6 / 11;
            int eq4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.Clear();
            Console.WriteLine($"-1 + 4 * 6 = {eq1}");
            Console.WriteLine($"(35 + 5) % 7 = {eq2}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {eq3}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {eq4}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice1
{
    class Menu
    {
        public void UserMenu()
        {
            string display = "0";
            while (display != "x")
            {
                Console.Clear();
                Console.WriteLine("Choose which thing you want to do.");
                Console.WriteLine();
                Console.WriteLine("{1}:Hello user");
                Console.WriteLine("{2}:Sum of numbers");
                Console.WriteLine("{3}:Divide numbers");
                Console.WriteLine("{4}:Solve for set equations");
                Console.WriteLine("{5}:Swap given numbers");
                Console.WriteLine("{6}:Multiply numbers");
                Console.WriteLine("{7}:Basic operators");
                Console.WriteLine("{8}:Multiplication table up to 10");
                Console.WriteLine("{9}:Average of numbers");
                Console.WriteLine("{10}:Three input equations");
                Console.WriteLine("{X}Exit.");
                Console.WriteLine();
                display = Console.ReadLine();

                switch (display)
                {
                    case "1": HelloUser hello = new HelloUser(); hello.Hello(); break;
                    case "2": SumNumbers sum = new SumNumbers(); sum.Sum(); break;
                    case "3": DivideNumbers div = new DivideNumbers(); div.Divide(); break;
                    case "4": SolveEquations equ = new SolveEquations(); equ.Equations(); break;
                    case "5": SwapNumbers swap = new SwapNumbers(); swap.Swap(); break;
                    case "6": NumberMultiply mult = new NumberMultiply(); mult.Product(); break;
                    case "7": BasicOperators basic = new BasicOperators(); basic.DoMath(); break;
                    case "8": MultiplicationTable table = new MultiplicationTable(); table.Table(); break;
                    case "9": AverageFourNumbers average = new AverageFourNumbers(); average.Average(); break;
                    case "10": ThreeInputs calc = new ThreeInputs(); calc.Calculate(); break;
                    case "x": break;
                    default: break;
                }
            }
        }
    }
}

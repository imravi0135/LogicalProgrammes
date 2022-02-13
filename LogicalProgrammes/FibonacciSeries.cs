using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammes
{
    internal class FibonacciSeries
    {
        public static void Fib()
        {
            int num1 = 0, num2 = 1, num3, i, num;
            Console.WriteLine("Enter the number:- ");
            num = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < num; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }

    }
}

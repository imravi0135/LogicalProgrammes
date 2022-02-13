using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammes
{
    internal class ReverseAnumber
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

        static void Perfect()
        {
            int num, sum = 0, n;
            Console.Write("enter the Number");
            num = int.Parse(Console.ReadLine());
            n = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }

        public static void Prime()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the number to check : ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }

        public static void Reverse()
        {
            int num, rev = 0, rem;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            Console.Write("Reversed Number: " + rev);
        }

    }
}

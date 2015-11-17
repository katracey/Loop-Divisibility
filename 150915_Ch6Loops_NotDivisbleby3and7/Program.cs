using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150915_Ch6Loops_NotDivisbleby3and7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
            //The number N should be read from the standard input.

            Console.WriteLine("What is the integer n?");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            while (n > num)
            {
                if ((num % 3) == 0 && (num % 7) == 0)
                {                    
                    num++;                    
                } 
                else
                {
                    Console.WriteLine(num);
                    num++;
                }
            }
        }
    }
}
